using System;
using System.Diagnostics;
using System.Net;
using System.Net.Security;
using System.Text;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Threading;
using System.Linq;

namespace RyujinxAutoUpdate
{
    class NintendoCDN
    {
        private static string did = "0000000000000000";
        private static string fw = "5.1.0-0";
        private static string ver = "0";
        public  static string CertPath = "./certs/nx_tls_client_cert.pfx";

        private static Random random = new Random();

        private static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private static bool AcceptAllCertifications(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }

        private static string ByteArrayToString(byte[] ByteIn)
        {
            StringBuilder HexIn = new StringBuilder(ByteIn.Length * 2);
            foreach (byte b in ByteIn) HexIn.AppendFormat("{0:x2}", b);
            return HexIn.ToString();
        }

        public static GameList.GameListNACP GetGameMetadata(string TitleID)
        {
            Process hactool = null;
            ProcessStartInfo startInfo = new ProcessStartInfo();

            did = RandomString(16);

            // Set up the inital Certificate and URL
            ServicePointManager.ServerCertificateValidationCallback = AcceptAllCertifications;
            string MetaURL = "https://atum.hac.lp1.d4c.nintendo.net/t/a/" + TitleID + "/" + ver;
            X509Certificate2 Cert = new X509Certificate2(CertPath, "switch");

            // Get the Meta NCA ID
            HttpWebRequest GetMetaNCAID = (HttpWebRequest)WebRequest.Create(MetaURL);
            GetMetaNCAID.ClientCertificates.Add(Cert);
            GetMetaNCAID.Method = "HEAD";
            GetMetaNCAID.UserAgent = "NintendoSDK Firmware/" + fw + " (platform:NX; did:" + did + "; eid:lp1)";
            HttpWebResponse ParseMetaNCAID = (HttpWebResponse)GetMetaNCAID.GetResponse();
            ParseMetaNCAID.Close();

            // Download The Meta NCA
            string MetaNCAURL = "https://atum.hac.lp1.d4c.nintendo.net/c/a/" + ParseMetaNCAID.GetResponseHeader("x-nintendo-content-id");
            HttpWebRequest GetMetaNCA = (HttpWebRequest)WebRequest.Create(MetaNCAURL);
            GetMetaNCA.ClientCertificates.Add(Cert);
            GetMetaNCA.UserAgent = "NintendoSDK Firmware/" + fw + " (platform:NX; did:" + did + "; eid:lp1)";
            HttpWebResponse ParseMetaNCA = (HttpWebResponse)GetMetaNCA.GetResponse();
            BinaryReader MetaNCA = new BinaryReader(ParseMetaNCA.GetResponseStream());
            File.WriteAllBytes(ver, MetaNCA.ReadBytes(100000));
            MetaNCA.Close();
            ParseMetaNCA.Close();

            // Use Hactool to extract the CNMT
            startInfo.FileName = "hactool.exe";
            startInfo.Arguments = "-k keys.txt " + ver + " --section0dir=CNMT";
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.UseShellExecute = true;
            hactool = Process.Start(startInfo);
            hactool.Start();
            hactool.WaitForExit();

            File.Delete(ver);

            // Parse the CNMT to get the NCA ID
            BinaryReader OpenCNMT = new BinaryReader(File.Open("CNMT/Application_" + TitleID + ".cnmt", FileMode.Open));
            string ParseCNMT = ByteArrayToString(OpenCNMT.ReadBytes(1000));
            OpenCNMT.Close();
            string ContNCAID = "";

            if (ParseCNMT.Substring(32, 2) == "03")
            {
                if (ParseCNMT.Substring(316, 2) == "03") ContNCAID = ParseCNMT.Substring(272, 32);
                else if (ParseCNMT.Substring(428, 2) == "03") ContNCAID = ParseCNMT.Substring(384, 32);
            }
            else if (ParseCNMT.Substring(32, 2) == "04")
            {
                if (ParseCNMT.Substring(316, 2) == "03") ContNCAID = ParseCNMT.Substring(272, 32);
                else if (ParseCNMT.Substring(428, 2) == "03") ContNCAID = ParseCNMT.Substring(384, 32);
                else if (ParseCNMT.Substring(540, 2) == "03") ContNCAID = ParseCNMT.Substring(496, 32);
            }

            Directory.Delete("./CNMT", true);

            // Get the Control NCA
            string ContNCAURL = "https://atum.hac.lp1.d4c.nintendo.net/c/c/" + ContNCAID;
            HttpWebRequest GetContNCA = (HttpWebRequest)WebRequest.Create(ContNCAURL);
            GetContNCA.ClientCertificates.Add(Cert);
            GetContNCA.UserAgent = "NintendoSDK Firmware/" + fw + " (platform:NX; did:" + did + "; eid:lp1)";
            HttpWebResponse ParseContNCA = (HttpWebResponse)GetContNCA.GetResponse();
            BinaryReader ContNCA = new BinaryReader(ParseContNCA.GetResponseStream());
            File.WriteAllBytes("TempCont", ContNCA.ReadBytes(10000000));
            ParseContNCA.Close();

            // Finally extract the Control NCA into a folder called Cont
            startInfo.Arguments = " -k keys.txt TempCont --section0dir=Cont";
            hactool = Process.Start(startInfo);
            hactool.Start();
            hactool.WaitForExit();

            File.Delete("TempCont");

            GameList.GameListNACP res = GameList.ParseControlNacp("./Cont/control.nacp");

            // Get the Icon File (and default to American English)
            string IconFile = "";
            
            if (File.Exists("Cont/icon_AmericanEnglish.dat")) IconFile = "Cont/icon_AmericanEnglish.dat";
            else
            {
                foreach (string s in Directory.GetFiles("./Cont"))
                {
                    if (Path.GetFileName(s).StartsWith("icon_"))
                    {
                        IconFile = s;
                        break;
                    }
                }
            }

            if (File.Exists("./Images/GameThumbnails/" + TitleID + ".jpg")) File.Delete("./Images/GameThumbnails/" + TitleID + ".jpg");
            File.Copy(IconFile, "./Images/GameThumbnails/" + TitleID + ".jpg");

            Directory.Delete("./Cont", true);

            return res;
        }
    }
}
