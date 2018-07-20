using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using IniParser;
using IniParser.Model;

namespace RyujinxAutoUpdate
{
    class GameList
    {
        private static FileIniDataParser   Parser;
        private static IniData             GameListData;
        public static  List<GameListEntry> Games;

        public static void Init()
        {
            Parser       = new FileIniDataParser();
            GameListData = Parser.ReadFile("./Gamelist.ini");
            Games        = GetAllEntrysFromINI();
        }

        public struct GameListEntry
        {
            public string AppName;
            public string Publisher;
            public string TitleID;
            public string GamePath;
        }

        public struct GameListNPDM
        {
            public uint   ACIoOff;
            public string TitleID;
        };

        public struct GameListNACP
        {
            public string TitleName;
            public string Publisher;
        };

        public struct GameListMetaData
        {
            public GameListNPDM npdm;
            public GameListNACP nacp;
        };

        public static List<GameListEntry> GetAllEntrysFromINI()
        {
            List<GameListEntry> res = new List<GameListEntry>();

            foreach (SectionData data in GameListData.Sections)
                res.Add(GetGameListEntry(data.SectionName));

            return res;
        }

        public static bool IsGameDirectoryValid(string dir)
        {
            bool hasRomFS = false;
            bool hasNpdm  = false;

            foreach (string s in Directory.GetFiles(dir))
            {
                if (hasRomFS && hasNpdm) break;
                if (Path.GetExtension(s).ToUpper() == ".ROMFS" 
                    || Path.GetExtension(s).ToUpper() == ".ISTORAGE")  hasRomFS = true;
                if (Path.GetFileName(s).ToUpper()     == "MAIN.NPDM") hasNpdm = true;
            }

            return (hasRomFS && hasNpdm);
        }

        public static GameListNACP ParseControlNacp(string Path)
        {
            GameListNACP res = new GameListNACP();
            byte[] NacpData = File.ReadAllBytes(Path);

            string Name = "";
            string Publisher = "";

            int i = 0;
            foreach (byte b in NacpData)
            {
                if (b != 0x00 && i < 0x200) Name += (char)b; // Get the Title Name

                if (b != 0x00 && i >= 0x200 && i < 0x300) Publisher += (char)b; // Get the Publisher Name
                if (i >= 0x300) break;

                ++i;
            }

            res.TitleName = Name;
            res.Publisher = Publisher;

            return res;
        }

        public static GameListMetaData ParseGameFiles(string FolderPath, string ControlNacpPath = null)
        {
            uint ACIoOff = 0;
            string TitleID = "";

            string NpdmPath = FolderPath + "\\main.npdm";
            byte[] NpdmData = File.ReadAllBytes(NpdmPath);

            ACIoOff = BitConverter.ToUInt32(NpdmData, 0x70);

            ulong RawTitleID = BitConverter.ToUInt64(NpdmData, (int)ACIoOff + 0x10);

            TitleID = String.Format("0{0:x2}", RawTitleID);

            GameListNACP ControlNacp = new GameListNACP();

            if (ControlNacpPath != null)
            {
                ControlNacp = ParseControlNacp(ControlNacpPath);
            }

            return new GameListMetaData
            {
                npdm = new GameListNPDM
                {
                    ACIoOff = ACIoOff,
                    TitleID = TitleID
                },
                nacp = ControlNacp
            };
        }

        public static GameListEntry GetGameListEntry(string TitleID)
        {
            if (GameListData.Sections.GetSectionData(TitleID) != null)
            {
                return new GameListEntry
                {
                    AppName   = GameListData.Sections.GetSectionData(TitleID).Keys.GetKeyData("AppName")  .Value,
                    TitleID   = GameListData.Sections.GetSectionData(TitleID).Keys.GetKeyData("TitleID")  .Value,
                    GamePath  = GameListData.Sections.GetSectionData(TitleID).Keys.GetKeyData("GamePath") .Value,
                    Publisher = GameListData.Sections.GetSectionData(TitleID).Keys.GetKeyData("Publisher").Value,
                };
            }

            return new GameListEntry
            {
                AppName   = null,
                TitleID   = null,
                GamePath  = null,
                Publisher = null
            };
        }

        public static void RemoveGameListEntry(string TitleID)
        {
            if (GameListData.Sections.GetSectionData(TitleID) != null)
            {
                GameListData.Sections.RemoveSection(TitleID);

                Parser.WriteFile("./Gamelist.ini", GameListData);

                Games = GetAllEntrysFromINI();
            }
        }

        public static void AddGameListEntry(GameListEntry entry)
        {
            SectionData GameData = new SectionData(entry.TitleID);

            if (entry.AppName != null)
            {
                KeyData AppName = new KeyData("AppName")
                {
                    Value = entry.AppName
                };
                GameData.Keys.SetKeyData(AppName);
            }

            if (entry.Publisher != null)
            {
                KeyData Publisher = new KeyData("Publisher")
                {
                    Value = entry.Publisher
                };
                GameData.Keys.SetKeyData(Publisher);
            }

            if (entry.TitleID != null)
            {
                KeyData TitleID = new KeyData("TitleID")
                {
                    Value = entry.TitleID
                };
                GameData.Keys.SetKeyData(TitleID);
            }

            if (entry.GamePath != null)
            {
                KeyData GamePath = new KeyData("GamePath")
                {
                    Value = entry.GamePath
                };
                GameData.Keys.SetKeyData(GamePath);
            }

            GameListData.Sections.Add(GameData);
            Parser.WriteFile("./Gamelist.ini", GameListData);

            Games = GetAllEntrysFromINI();
        }
    }
}
