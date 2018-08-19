using IniParser;
using IniParser.Model;

namespace RyujinxAutoUpdate
{
    class Settings
    {
        private static FileIniDataParser Parser;
        private static IniData           SettingsData;

        public static bool   SHOULD_OPEN_DEFAULT_HOMEBREW;
        public static bool   SHOW_RYUJINX_CONSOLE;
        public static bool   WRITE_RYUJINX_LOG;
        public static bool   SHOW_BUILD_CONSOLE;
        public static bool   WRITE_BUILD_LOG;
        public static bool   GET_METADATA_FROM_CDN;
        public static bool   USE_NUCLEUS;
        public static string DEFAULT_HOMEBREW_APP;
        public static string GAMELIST_ICON_SIZE;

        public static void Init()
        {
            Parser = new FileIniDataParser();
            SettingsData = Parser.ReadFile("./Settings.ini");
            UpdateValues();
        }

        public static void UpdateValues()
        {
            SHOULD_OPEN_DEFAULT_HOMEBREW = bool.Parse(SettingsData.Global.GetKeyData("ShouldOpenDefaultHomebrew").Value);
            SHOW_RYUJINX_CONSOLE         = bool.Parse(SettingsData.Global.GetKeyData("ShowRyujinxConsole")       .Value);
            WRITE_RYUJINX_LOG            = bool.Parse(SettingsData.Global.GetKeyData("WriteRyujinxLog")          .Value);
            SHOW_BUILD_CONSOLE           = bool.Parse(SettingsData.Global.GetKeyData("ShowBuildConsole")         .Value);
            WRITE_BUILD_LOG              = bool.Parse(SettingsData.Global.GetKeyData("WriteBuildLog")            .Value);
            GET_METADATA_FROM_CDN        = bool.Parse(SettingsData.Global.GetKeyData("GetMetadataCDN")           .Value);
            USE_NUCLEUS                  = bool.Parse(SettingsData.Global.GetKeyData("UseNucleusCDN")            .Value);
            DEFAULT_HOMEBREW_APP         =            SettingsData.Global.GetKeyData("DefaultHomebrewPath")      .Value;
            GAMELIST_ICON_SIZE           =            SettingsData.Global.GetKeyData("GameListIconSize")         .Value;
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

            SettingsData.Global.SetKeyData(new KeyData("GetMetadataCDN")
            {
                Value = GET_METADATA_FROM_CDN.ToString()
            });

            SettingsData.Global.SetKeyData(new KeyData("UseNucleusCDN")
            {
                Value = USE_NUCLEUS.ToString()
            });

            SettingsData.Global.SetKeyData(new KeyData("DefaultHomebrewPath")
            {
                Value = DEFAULT_HOMEBREW_APP
            });

            SettingsData.Global.SetKeyData(new KeyData("GameListIconSize")
            {
                Value = GAMELIST_ICON_SIZE
            });

            Parser.WriteFile("./Settings.ini", SettingsData);
        }
    }
}
