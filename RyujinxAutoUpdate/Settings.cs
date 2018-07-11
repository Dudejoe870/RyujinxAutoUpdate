using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IniParser;
using IniParser.Model;
using IniParser.Model.Configuration;

namespace RyujinxAutoUpdate
{
    class Settings
    {
        private static FileIniDataParser      Parser;
        private static IniData                SettingsData;

        public static bool   SHOULD_OPEN_DEFAULT_HOMEBREW;
        public static string DEFAULT_HOMEBREW_APP;

        public static void Init()
        {
            Parser = new FileIniDataParser();
            SettingsData = Parser.ReadFile("./Settings.ini");
            UpdateValues();
        }

        public static void UpdateValues()
        {
            SHOULD_OPEN_DEFAULT_HOMEBREW =  bool.Parse(SettingsData.Global.GetKeyData("ShouldOpenDefaultHomebrew").Value);
            DEFAULT_HOMEBREW_APP         =             SettingsData.Global.GetKeyData("DefaultHomebrewPath").Value;
        }

        public static void UpdateINI()
        {
            IniData PrevData = SettingsData;
            SettingsData.Global.SetKeyData(new KeyData("ShouldOpenDefaultHomebrew")
            {
                Value = SHOULD_OPEN_DEFAULT_HOMEBREW.ToString()
            });

            SettingsData.Global.SetKeyData(new KeyData("DefaultHomebrewPath")
            {
                Value = DEFAULT_HOMEBREW_APP
            });

            Parser.WriteFile("./Settings.ini", SettingsData);
        }
    }
}
