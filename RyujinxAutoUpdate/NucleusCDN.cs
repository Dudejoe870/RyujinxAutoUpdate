using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace RyujinxAutoUpdate
{
    class NucleusCDN
    {
        private static readonly string NucleusURL = "https://gamechat.network/nucleus.php";

        public enum ReturnType
        {
            MissingTitle,
            InvalidTitle,
            Success
        };

        public struct GameHeader
        {
            public ReturnType Return;
            public string GameName;
            public string Publisher;
        };

        public static GameHeader MakeHeadRequest(string TitleID)
        {
            HttpWebRequest Request = (HttpWebRequest)WebRequest.Create(NucleusURL + $"?title_id={TitleID}");
            Request.Method = "HEAD";
            HttpWebResponse Response = (HttpWebResponse)Request.GetResponse();
            if (Response.Headers.Get("X-GCN-Status-Code") == "Success")
            {
                JObject JSON = JObject.Parse(Response.Headers.Get("X-GCN-Game-Meta"));
                Response.Dispose();
                return new GameHeader()
                {
                    Return    = ReturnType.Success,
                    GameName  = JSON["applications"][0]["name"].ToString(),
                    Publisher = JSON["publisher"]["name"].ToString()
                };
            }
            else
            {
                switch (Response.Headers.Get("X-GCN-Failure"))
                {
                    case "MISSING_TITLE": Response.Dispose(); return new GameHeader() { Return = ReturnType.MissingTitle, GameName = null, Publisher = null };
                    case "INVALID_TITLE": Response.Dispose(); return new GameHeader() { Return = ReturnType.InvalidTitle, GameName = null, Publisher = null };
                    default: throw new NotImplementedException();
                }
            }
            
        }

        public static byte[] MakeIconRequest(string TitleID)
        {
            HttpWebRequest Request   = (HttpWebRequest)WebRequest.Create(NucleusURL + $"?title_id={TitleID}");
            HttpWebResponse Response = (HttpWebResponse)Request.GetResponse();
            
            return new BinaryReader(Response.GetResponseStream()).ReadBytes((int)Response.ContentLength);
        }
    }
}
