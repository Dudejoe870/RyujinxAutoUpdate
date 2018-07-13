using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.IO.Compression;
using System.Net;
using System.Diagnostics;
using System.Linq;

namespace RyujinxAutoUpdateUpdater
{
    public partial class MainForm : Form
    {
        private static string DownloadPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\RyujinxAutoUpdate";
        private static string[] IgnoredFiles = { "Ryujinx.log", "Build.log" }; // Would add Settings.ini, but this could change in Updates.

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Icon = new Icon("Images/main.ico");
        }

        private void DownloadUpdate_Click(object sender, EventArgs e)
        {
            DownloadLatestUpdate();
        }

        private void DownloadLatestUpdate()
        {
            string ZipDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string ZipFile = ZipDir + "\\RyujinxAutoUpdate.zip";

            Stopwatch Timer = new Stopwatch();

            File.Create(ZipFile).Dispose();

            string Url = "https://ci.appveyor.com/api/projects/Dudejoe870/ryujinxautoupdate/artifacts/RyujinxAutoUpdate.zip";
            WebClient webClient = new WebClient();

            Status.Text = "Downloading Ryujinx Auto Update";
            Timer.Start();
            webClient.DownloadFile(Url, ZipFile);

            webClient.Dispose();

            Status.Text = "Extracting Ryujinx Auto Update";
            if (Directory.Exists(DownloadPath + "\\Release") && !IsDirectoryEmpty(DownloadPath + "\\Release"))
            {
                Directory.CreateDirectory(DownloadPath + "\\Release\\FileTMP");
                foreach (string s in IgnoredFiles)
                {
                    if (File.Exists(DownloadPath + "\\Release\\" + s)) File.Move(DownloadPath + "\\Release\\" + s, DownloadPath + "\\Release\\FileTMP\\" + s);
                }
            }

            if (!IsDirectoryEmpty(DownloadPath))
            {
                DirectoryInfo di = new DirectoryInfo(DownloadPath + "\\Release");

                foreach (FileInfo file in di.GetFiles()) file.Delete();

                foreach (DirectoryInfo dir in di.GetDirectories()) if (dir.Name != "Ryujinx" && dir.Name != "FileTMP") dir.Delete(true);
            }

            System.IO.Compression.ZipFile.ExtractToDirectory(ZipFile, DownloadPath);

            if (Directory.Exists(DownloadPath + "\\Release\\FileTMP") && !IsDirectoryEmpty(DownloadPath + "\\Release\\FileTMP"))
            {
                foreach (string s in IgnoredFiles)
                {
                    if (File.Exists(DownloadPath + "\\Release\\FileTMP\\" + s))
                    {
                        File.Delete(DownloadPath + "\\Release\\" + s);
                        File.Move(DownloadPath + "\\Release\\FileTMP\\" + s, DownloadPath + "\\Release\\" + s);
                    }
                }
            }

            if (Directory.Exists(DownloadPath + "\\Release\\FileTMP")) Directory.Delete(DownloadPath + "\\Release\\FileTMP");

            Timer.Stop();

            Status.Text = "Done!  It Took: " + (((double)Timer.ElapsedMilliseconds) / 1000) + " Second(s)";
        }

        private bool IsDirectoryEmpty(string path)
        {
            return !Directory.EnumerateFileSystemEntries(path).Any();
        }
    }
}
