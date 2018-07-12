using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Windows.Forms;

namespace RyujinxAutoUpdate
{
    public partial class MainForm : Form
    {
        public static string RyujinxDownloadPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Ryujinx";
        public static string BuildLogFilePath    = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Build.log";
        public static string RyujinxLogFilePath  = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Ryujinx.log";

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Icon = new Icon("Images/icon.ico");
            if (!Directory.Exists(RyujinxDownloadPath)) Directory.CreateDirectory(RyujinxDownloadPath);
            Settings.Init();
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
                    FileName               = "dotnet",
                    Arguments              = "run --project \"" + RyujinxDownloadPath + "\\Ryujinx\" -c Release -- \"" + args + "\"",
                    UseShellExecute        = false,
                    CreateNoWindow         = !Settings.SHOW_RYUJINX_CONSOLE,
                    RedirectStandardError  =  Settings.WRITE_RYUJINX_LOG,
                    RedirectStandardOutput =  Settings.WRITE_RYUJINX_LOG
                }
            };

            string LOG = "";

            if (Settings.WRITE_RYUJINX_LOG)
            {
                Ryujinx.OutputDataReceived += (s, e) => LOG += e.Data + '\n';
                Ryujinx.ErrorDataReceived  += (s, e) => LOG += e.Data + '\n';
            }

            // Run Ryujinx
            toolStrip1.Items[0].Text = "Running Ryujinx...";
            Ryujinx.Start();
            if (Settings.WRITE_RYUJINX_LOG)
            {
                Ryujinx.BeginOutputReadLine();
                Ryujinx.BeginErrorReadLine();
            }

            Ryujinx.WaitForExit();

            if (Settings.WRITE_RYUJINX_LOG) using (StreamWriter sw = File.CreateText(RyujinxLogFilePath)) sw.Write(LOG);

            toolStrip1.Items[0].Text = "Ryujinx Exited.";
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
            if (Settings.SHOULD_OPEN_DEFAULT_HOMEBREW)
            {
                RunRyujinx(Settings.DEFAULT_HOMEBREW_APP);
            }
            else
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
        }

        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            string file = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
            RunRyujinx(file);
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.Show();
        }

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm settings = new SettingsForm();
            settings.Show();
            Console.WriteLine(Settings.DEFAULT_HOMEBREW_APP);
        }

        private void InstallOpenALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to install OpenAL?", "Are you sure?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (InstallOpenAL(true) == 0)
                {
                    DialogResult RestartApp = MessageBox.Show("Do you want to Quit (And Manually) Restart the Application now?\n" +
                    "This is required to finish the setup, you can click Cancel to restart the Application later.", "Restart?", MessageBoxButtons.OKCancel);
                    if (RestartApp == DialogResult.OK)
                    {
                        Application.Exit();
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
                    DialogResult RestartApp = MessageBox.Show("Do you want to Quit (And Manually) Restart the Application now?\n" +
                    "This is required to finish the setup, you can click Cancel to restart the Application later.", "Restart?", MessageBoxButtons.OKCancel);
                    if (RestartApp == DialogResult.OK)
                    {
                        Application.Exit();
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
                    DialogResult RestartApp = MessageBox.Show("Do you want to Quit (And Manually) Restart the Application now?\n" +
                    "This is required to finish the setup, you can click Cancel to restart the Application later.", "Restart?", MessageBoxButtons.OKCancel);
                    if (RestartApp == DialogResult.OK)
                    {
                        Application.Exit();
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
                DialogResult RestartApp = MessageBox.Show("Do you want to Quit (And Manually) Restart the Application now?\n" +
                    "This is required to finish the setup, you can click Cancel to restart the Application later.", "Restart?", MessageBoxButtons.OKCancel);
                if (RestartApp == DialogResult.OK)
                {
                    Application.Exit();
                }
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
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.CreateNoWindow = !Settings.SHOW_BUILD_CONSOLE;

            proc.StartInfo.RedirectStandardError  = Settings.WRITE_BUILD_LOG;
            proc.StartInfo.RedirectStandardOutput = Settings.WRITE_BUILD_LOG;

            string LOG = "";

            if (Settings.WRITE_BUILD_LOG)
            {
                proc.OutputDataReceived += (s, e) => LOG += e.Data + '\n';
                proc.ErrorDataReceived  += (s, e) => LOG += e.Data + '\n';
            }

            // Build Ryujinx
            toolStrip1.Items[0].Text = "Building Ryujinx...";
            Stopwatch TimeTook = new Stopwatch();

            try
            {
                proc.Start();
                TimeTook.Start();
                if (Settings.WRITE_BUILD_LOG)
                {
                    proc.BeginOutputReadLine();
                    proc.BeginErrorReadLine();
                }
            }
            catch (Exception) // Make sure they have the .Net SDK Installed!
            {
                DialogResult dialogResult = MessageBox.Show("You need the .Net SDK installed to use this function!", "Error", MessageBoxButtons.OK);
                if (DialogResult == DialogResult.OK)
                {
                    toolStrip1.Items[0].Text = "";
                    return;
                }
            }

            proc.WaitForExit();

            TimeTook.Stop();

            if (proc.ExitCode != 0) // Make sure nothing went wrong!
            {
                toolStrip1.Items[0].Text = "Something went wrong!  Dotnet Exit Code: " + proc.ExitCode;
                proc.Dispose();
                return;
            }

            if (Settings.WRITE_BUILD_LOG) using (StreamWriter sw = File.CreateText(BuildLogFilePath)) sw.Write(LOG);

            toolStrip1.Items[0].Text = "Ryujinx Build finished in " + ((double)(TimeTook.ElapsedMilliseconds) / 1000) + " Second(s).";
        }

        private void InstallOrUpdateRyujinx()
        {
            Process CurrentProc = new Process();

            CurrentProc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

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
                catch (Exception) // Make sure they have Git Installed!
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
                catch (Exception) // Make sure they have Git Installed!
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
                    toolStrip1.Items[0].Text = "Something went wrong!  Git Pull Exit Code: " + CurrentProc.ExitCode;
                    CurrentProc.Dispose();
                    return;
                }

                BuildRyujinx(CurrentProc);

                CurrentProc.Dispose();
            }

            return;
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
            System.IO.Compression.ZipFile.ExtractToDirectory(ZipFile, ZipDir);

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
    }
}
