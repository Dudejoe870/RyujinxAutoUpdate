using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security.Permissions;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RyujinxAutoUpdate
{
    public partial class MainForm : Form
    {
        private string RyujinxDownloadPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Ryujinx";

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Icon = new Icon("Images/icon.ico");
            if (!Directory.Exists(RyujinxDownloadPath)) Directory.CreateDirectory(RyujinxDownloadPath);
        }

        private void DownloadUpdateRyujinxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to Install / Update Ryujinx?", "Are you sure?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) InstallOrUpdateRyujinx();
        }

        private void RunRyujinx(string args)
        {
            Process Ryujinx = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "dotnet",
                    Arguments = "run --project \"" + RyujinxDownloadPath + "\\Ryujinx\" -c Release -- \"" + args + "\"",
                    UseShellExecute = false
                }
            };

            // Run Ryujinx
            toolStrip1.Items[0].Text = "Running Ryujinx...";
            Ryujinx.Start();

            Ryujinx.WaitForExit();
            toolStrip1.Items[0].Text = "";
        }

        private void OpenGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog
            {
                Description = "Please select a RomFS / ExeFS Folder to Open."
            };

            DialogResult result = folderBrowser.ShowDialog();

            if (result == DialogResult.OK)
            {
                RunRyujinx(folderBrowser.SelectedPath);

                folderBrowser.Dispose();
            }
            else if (result == DialogResult.Cancel)
            {
                folderBrowser.Dispose();
                return;
            }
        }

        private void OpenHomebrewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog
            {
                Title = "Select a NRO to open"
            };

            fileDialog.Filter = "Homebrew Game (*.nro)|*.nro";

            DialogResult result = fileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                RunRyujinx(fileDialog.FileName);

                fileDialog.Dispose();
            }
            else if (result == DialogResult.Cancel)
            {
                fileDialog.Dispose();
                return;
            }
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.Show();
        }

        private void InstallOpenALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to install OpenAL?", "Are you sure?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (InstallOpenAL(true) == 0)
                {
                    DialogResult RestartApp = MessageBox.Show("Do you want to Restart the Application now?\n" +
                    "This is required to finish the setup, you can click Cancel to restart the Application later.", "Restart?", MessageBoxButtons.OKCancel);
                    if (RestartApp == DialogResult.OK)
                    {
                        Application.Restart();
                    }
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void InstallGitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to install Git?\n" +
                "(Note: Make sure to check \"Use git from the windows command prompt\"!)", "Are you sure?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (InstallGit(true) == 0)
                {
                    DialogResult RestartApp = MessageBox.Show("Do you want to Restart the Application now?\n" +
                    "This is required to finish the setup, you can click Cancel to restart the Application later.", "Restart?", MessageBoxButtons.OKCancel);
                    if (RestartApp == DialogResult.OK)
                    {
                        Application.Restart();
                    }
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void InstallNetSDKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to install the .Net SDK?", "Are you sure?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (InstallDotNet(true) == 0)
                {
                    DialogResult RestartApp = MessageBox.Show("Do you want to Restart the Application now?\n" +
                    "This is required to finish the setup, you can click Cancel to restart the Application later.", "Restart?", MessageBoxButtons.OKCancel);
                    if (RestartApp == DialogResult.OK)
                    {
                        Application.Restart();
                    }
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void InstallAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to install all of the Dependencies?\n" +
                "(OpenAL, Git, .Net)\n" +
                "(Note: Make sure when installing Git to check \"Use git from the windows command prompt\"!)", "Are you sure?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                toolStrip1.Items[0].Text = "Installing all Dependencies...";
                if (InstallOpenAL(false) != 0) return;
                //InstallOpenAL(false);
                if (InstallGit   (false) != 0) return;
                //InstallGit(false);
                if (InstallDotNet(false) != 0) return;
                //InstallDotNet(false);
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
            toolStrip1.Items[0].Text = "";
        }

        private void BuildRyujinx(Process proc)
        {
            proc.StartInfo.FileName = "dotnet";
            proc.StartInfo.Arguments = "build -c Release \"" + RyujinxDownloadPath + "\\Ryujinx\"";

            // Build Ryujinx
            toolStrip1.Items[0].Text = "Building Ryujinx...";

            try
            {
                proc.Start();
            }
            catch (FileNotFoundException) // Make sure they have the .Net SDK Installed!
            {
                DialogResult dialogResult = MessageBox.Show("You need the .Net SDK installed to use this function!", "Error", MessageBoxButtons.OK);
                if (DialogResult == DialogResult.OK)
                {
                    toolStrip1.Items[0].Text = "";
                    return;
                }
            }

            proc.WaitForExit();

            if (proc.ExitCode != 0) // Make sure nothing went wrong!
            {
                toolStrip1.Items[0].Text = "Something went wrong!  Dotnet Exit Code: " + proc.ExitCode;
                proc.Dispose();
                return;
            }

            toolStrip1.Items[0].Text = "";
        }

        private void InstallOrUpdateRyujinx()
        {
            Process CurrentProc = new Process();

            CurrentProc.StartInfo.WindowStyle = ProcessWindowStyle.Normal;

            if (IsDirectoryEmpty(RyujinxDownloadPath))
            {
                CurrentProc.StartInfo.FileName = "git";
                CurrentProc.StartInfo.Arguments = "-C \"" + RyujinxDownloadPath + "\" clone https://github.com/gdkchan/Ryujinx.git ./";

                // Clone the repository
                toolStrip1.Items[0].Text = "Cloning the Git Repository...";

                try
                {
                    CurrentProc.Start();
                }
                catch (FileNotFoundException) // Make sure they have Git Installed!
                {
                    DialogResult dialogResult = MessageBox.Show("You need Git installed to use this function!\n" +
                        "(Did you check \"Use git from the windows command prompt\"?)", "Error", MessageBoxButtons.OK);
                    if (DialogResult == DialogResult.OK)
                    {
                        toolStrip1.Items[0].Text = "";
                        return;
                    }
                }

                CurrentProc.WaitForExit();

                if (CurrentProc.ExitCode != 0) // Make sure nothing went wrong!
                {
                    toolStrip1.Items[0].Text = "Something went wrong!  Git Clone Exit Code: " + CurrentProc.ExitCode;
                    CurrentProc.Dispose();
                    return;
                }

                // Build Ryujinx
                BuildRyujinx(CurrentProc);

                CurrentProc.Dispose();

                toolStrip1.Items[0].Text = "";
            }
            else
            {
                CurrentProc.StartInfo.FileName = "git";
                CurrentProc.StartInfo.Arguments = "-C \"" + RyujinxDownloadPath + "\" pull origin master ";

                // Pull the repository
                toolStrip1.Items[0].Text = "Pulling the Git Repository...";

                try
                {
                    CurrentProc.Start();
                }
                catch (FileNotFoundException) // Make sure they have Git Installed!
                {
                    DialogResult dialogResult = MessageBox.Show("You need Git installed to use this function!\n" +
                        "(Did you check \"Use git from the windows command prompt\"?)", "Error", MessageBoxButtons.OK);
                    if (DialogResult == DialogResult.OK)
                    {
                        toolStrip1.Items[0].Text = "";
                        return;
                    }
                }

                CurrentProc.WaitForExit();

                if (CurrentProc.ExitCode != 0) // Make sure nothing went wrong!
                {
                    toolStrip1.Items[0].Text = "Something went wrong!  Git Exit Code: " + CurrentProc.ExitCode;
                    CurrentProc.Dispose();
                    return;
                }

                BuildRyujinx(CurrentProc);

                CurrentProc.Dispose();

                toolStrip1.Items[0].Text = "";
            }
        }

        private int InstallGit(bool ChangeInfoToolStrip)
        {
            string ExeDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\GitSetup";
            string ExeFile = ExeDir + "\\GitSetup.exe";

            // Create the correct Files and Directorys.
            Directory.CreateDirectory(ExeDir);
            File.Create(ExeFile).Dispose();

            string Url = "https://github.com/git-for-windows/git/releases/download/v2.18.0.windows.1/Git-2.18.0-64-bit.exe";
            WebClient webClient = new WebClient();

            // Download the File
            if (ChangeInfoToolStrip) toolStrip1.Items[0].Text = "Downloading Git Setup...";
            webClient.DownloadFile(Url, ExeFile);

            webClient.Dispose();

            // Run the EXE
            if (ChangeInfoToolStrip) toolStrip1.Items[0].Text = "Running the Executable...";
            Process proc = Process.Start(ExeFile);

            proc.WaitForExit();

            if (ChangeInfoToolStrip) toolStrip1.Items[0].Text = "";

            return proc.ExitCode;
        }

        private int InstallOpenAL(bool ChangeInfoToolStrip)
        {
            string ZipDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\OpenALSetup";
            string ZipFile = ZipDir + "\\OpenAL11CoreSDK.zip";

            // Create the correct Files and Directorys.
            Directory.CreateDirectory(ZipDir);
            File.Create(ZipFile).Dispose();

            string Url = "https://openal.org/downloads/OpenAL11CoreSDK.zip";
            WebClient webClient = new WebClient();

            // Download the File
            if (ChangeInfoToolStrip) toolStrip1.Items[0].Text = "Downloading the OpenAL Setup...";
            webClient.DownloadFile(Url, ZipFile);

            webClient.Dispose();

            // Extract the Zip
            if (ChangeInfoToolStrip) toolStrip1.Items[0].Text = "Extracting the Zip...";
            Extract(ZipFile, ZipDir);

            string ExeFile = ZipDir + "\\OpenAL11CoreSDK.exe";

            // Run the EXE
            if (ChangeInfoToolStrip) toolStrip1.Items[0].Text = "Running the Executable...";
            Process proc = Process.Start(ExeFile);

            proc.WaitForExit();

            if (ChangeInfoToolStrip) toolStrip1.Items[0].Text = "";

            return proc.ExitCode;
        }

        private int InstallDotNet(bool ChangeInfoToolStrip)
        {
            string ExeDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\.NetSetup";
            string ExeFile = ExeDir + "\\DotnetSetup.exe";

            // Create the correct Files and Directorys.
            Directory.CreateDirectory(ExeDir);
            File.Create(ExeFile).Dispose();

            string Url = "https://download.microsoft.com/download/D/0/4/D04C5489-278D-4C11-9BD3-6128472A7626/dotnet-sdk-2.1.301-win-x64.exe";
            WebClient webClient = new WebClient();

            // Download the File
            if (ChangeInfoToolStrip) toolStrip1.Items[0].Text = "Downloading the .Net Setup...";
            webClient.DownloadFile(Url, ExeFile);

            webClient.Dispose();

            // Run the EXE
            if (ChangeInfoToolStrip) toolStrip1.Items[0].Text = "Running the Executable...";
            Process proc = Process.Start(ExeFile);

            proc.WaitForExit();

            if (ChangeInfoToolStrip) toolStrip1.Items[0].Text = "";

            return proc.ExitCode;
        }

        private bool IsDirectoryEmpty(string path)
        {
            return !Directory.EnumerateFileSystemEntries(path).Any();
        }

        private void Extract(string zipToUnpack, string unpackDirectory)
        {
            using (ZipFile zip = ZipFile.Read(zipToUnpack))
            {
                foreach (ZipEntry entry in zip)
                {
                    entry.Extract(unpackDirectory, ExtractExistingFileAction.OverwriteSilently);
                }
            }
        }
    }
}
