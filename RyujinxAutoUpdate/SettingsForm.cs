using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RyujinxAutoUpdate
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            this.Icon = new Icon("Images/icon.ico");
            Settings.UpdateValues();
            ShouldOpenDefaultHomebrewCheck.Checked = Settings.SHOULD_OPEN_DEFAULT_HOMEBREW;
            ShowRyujinxConsoleCheck.Checked        = Settings.SHOW_RYUJINX_CONSOLE;
            WriteRyujinxLogCheck.Checked           = Settings.WRITE_RYUJINX_LOG;
            ShowBuildConsoleCheck.Checked          = Settings.SHOW_BUILD_CONSOLE;
            WriteBuildLogCheck.Checked             = Settings.WRITE_BUILD_LOG;
            DefaultAppPath.Text                    = Settings.DEFAULT_HOMEBREW_APP;
        }

        private void Apply_Click(object sender, EventArgs e)
        {
            Settings.UpdateINI();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ShouldOpenDefaultHomebrewCheck_CheckedChanged(object sender, EventArgs e)
        {
            DefaultApp.Enabled                    = ShouldOpenDefaultHomebrewCheck.Checked;
            DefaultAppPath.Enabled                = ShouldOpenDefaultHomebrewCheck.Checked;
            Settings.SHOULD_OPEN_DEFAULT_HOMEBREW = ShouldOpenDefaultHomebrewCheck.Checked;
        }

        private void ShowRyujinxConsoleCheck_CheckedChanged(object sender, EventArgs e)
        {
            Settings.SHOW_RYUJINX_CONSOLE =  ShowRyujinxConsoleCheck.Checked;
            WriteRyujinxLogCheck.Enabled  = !ShowRyujinxConsoleCheck.Checked;
        }

        private void WriteRyujinxLogCheck_CheckedChanged(object sender, EventArgs e)
        {
            Settings.WRITE_RYUJINX_LOG      =  WriteRyujinxLogCheck.Checked;
            ShowRyujinxConsoleCheck.Enabled = !WriteRyujinxLogCheck.Checked;
        }

        private void ShowBuildConsoleCheck_CheckedChanged(object sender, EventArgs e)
        {
            Settings.SHOW_BUILD_CONSOLE = ShowBuildConsoleCheck.Checked;
            WriteBuildLogCheck.Enabled  = !ShowBuildConsoleCheck.Checked;
        }

        private void WriteBuildLogCheck_CheckedChanged(object sender, EventArgs e)
        {
            Settings.WRITE_BUILD_LOG      = WriteBuildLogCheck.Checked;
            ShowBuildConsoleCheck.Enabled = !WriteBuildLogCheck.Checked;
        }

        private void DefaultApp_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog
            {
                Title = "Select a Default NRO"
            };

            fileDialog.Filter = "Homebrew Game (*.nro)|*.nro";

            DialogResult result = fileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                Settings.DEFAULT_HOMEBREW_APP = fileDialog.FileName;
                DefaultAppPath.Text           = fileDialog.FileName;
                fileDialog.Dispose();
            }
            else if (result == DialogResult.Cancel)
            {
                fileDialog.Dispose();
                return;
            }
        }
    }
}
