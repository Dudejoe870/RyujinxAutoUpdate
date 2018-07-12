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
        public static bool   SHOW_RYUJINX_CONSOLE;
        public static bool   WRITE_RYUJINX_LOG;
        public static bool   SHOW_BUILD_CONSOLE;
        public static bool   WRITE_BUILD_LOG;
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
            SHOW_RYUJINX_CONSOLE         =  bool.Parse(SettingsData.Global.GetKeyData("ShowRyujinxConsole").Value);
            WRITE_RYUJINX_LOG            =  bool.Parse(SettingsData.Global.GetKeyData("WriteRyujinxLog").Value);
            SHOW_BUILD_CONSOLE           =  bool.Parse(SettingsData.Global.GetKeyData("ShowBuildConsole").Value);
            WRITE_BUILD_LOG              =  bool.Parse(SettingsData.Global.GetKeyData("WriteBuildLog").Value);
            DEFAULT_HOMEBREW_APP         =             SettingsData.Global.GetKeyData("DefaultHomebrewPath").Value;
        }

        public static void UpdateINI()
        {
            SettingsData.Global.SetKeyData(new KeyData("ShouldOpenDefaultHomebrew")
            {
                Value = SHOULD_OPEN_DEFAULT_HOMEBREW.ToString()
            });

            SettingsData.Global.SetKeyData(new KeyData("ShowRyujinxConsole")
            {
                Value = SHOW_RYUJINX_CONSOLE.ToString()
            });

            SettingsData.Global.SetKeyData(new KeyData("ShowRyujinxConsole")
            {
                Value = SHOW_RYUJINX_CONSOLE.ToString()
            });

            SettingsData.Global.SetKeyData(new KeyData("WriteRyujinxLog")
            {
                Value = WRITE_RYUJINX_LOG.ToString()
            });

            SettingsData.Global.SetKeyData(new KeyData("WriteBuildLog")
            {
                Value = WRITE_BUILD_LOG.ToString()
            });

            SettingsData.Global.SetKeyData(new KeyData("DefaultHomebrewPath")
            {
                Value = DEFAULT_HOMEBREW_APP
            });

            Parser.WriteFile("./Settings.ini", SettingsData);
        }
    }
}
