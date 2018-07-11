namespace RyujinxAutoUpdate
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolStripInfo = new System.Windows.Forms.ToolStripLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenHomebrewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DownloadInstallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DownloadUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InstallOpenALToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InstallGitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InstallNetSDKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InstallAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripInfo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 656);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1264, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ToolStripInfo
            // 
            this.ToolStripInfo.Name = "ToolStripInfo";
            this.ToolStripInfo.Size = new System.Drawing.Size(0, 22);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.DownloadInstallToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenGameToolStripMenuItem,
            this.OpenHomebrewToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // OpenGameToolStripMenuItem
            // 
            this.OpenGameToolStripMenuItem.Name = "OpenGameToolStripMenuItem";
            this.OpenGameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.OpenGameToolStripMenuItem.Text = "Open Game";
            this.OpenGameToolStripMenuItem.Click += new System.EventHandler(this.OpenGameToolStripMenuItem_Click);
            // 
            // OpenHomebrewToolStripMenuItem
            // 
            this.OpenHomebrewToolStripMenuItem.Name = "OpenHomebrewToolStripMenuItem";
            this.OpenHomebrewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.OpenHomebrewToolStripMenuItem.Text = "Open Homebrew";
            this.OpenHomebrewToolStripMenuItem.Click += new System.EventHandler(this.OpenHomebrewToolStripMenuItem_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingsToolStripMenuItem});
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.EditToolStripMenuItem.Text = "Edit";
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SettingsToolStripMenuItem.Text = "Settings";
            this.SettingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItem_Click);
            // 
            // DownloadInstallToolStripMenuItem
            // 
            this.DownloadInstallToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DownloadUpdateToolStripMenuItem,
            this.InstallOpenALToolStripMenuItem,
            this.InstallGitToolStripMenuItem,
            this.InstallNetSDKToolStripMenuItem,
            this.InstallAllToolStripMenuItem});
            this.DownloadInstallToolStripMenuItem.Name = "DownloadInstallToolStripMenuItem";
            this.DownloadInstallToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.DownloadInstallToolStripMenuItem.Text = "Download / Install";
            // 
            // DownloadUpdateToolStripMenuItem
            // 
            this.DownloadUpdateToolStripMenuItem.Name = "DownloadUpdateToolStripMenuItem";
            this.DownloadUpdateToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.DownloadUpdateToolStripMenuItem.Text = "Download / Update Ryujinx";
            this.DownloadUpdateToolStripMenuItem.Click += new System.EventHandler(this.DownloadUpdateRyujinxToolStripMenuItem_Click);
            // 
            // InstallOpenALToolStripMenuItem
            // 
            this.InstallOpenALToolStripMenuItem.Name = "InstallOpenALToolStripMenuItem";
            this.InstallOpenALToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.InstallOpenALToolStripMenuItem.Text = "Install OpenAL";
            this.InstallOpenALToolStripMenuItem.Click += new System.EventHandler(this.InstallOpenALToolStripMenuItem_Click);
            // 
            // InstallGitToolStripMenuItem
            // 
            this.InstallGitToolStripMenuItem.Name = "InstallGitToolStripMenuItem";
            this.InstallGitToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.InstallGitToolStripMenuItem.Text = "Install Git";
            this.InstallGitToolStripMenuItem.Click += new System.EventHandler(this.InstallGitToolStripMenuItem_Click);
            // 
            // InstallNetSDKToolStripMenuItem
            // 
            this.InstallNetSDKToolStripMenuItem.Name = "InstallNetSDKToolStripMenuItem";
            this.InstallNetSDKToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.InstallNetSDKToolStripMenuItem.Text = "Install .Net SDK";
            this.InstallNetSDKToolStripMenuItem.Click += new System.EventHandler(this.InstallNetSDKToolStripMenuItem_Click);
            // 
            // InstallAllToolStripMenuItem
            // 
            this.InstallAllToolStripMenuItem.Name = "InstallAllToolStripMenuItem";
            this.InstallAllToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.InstallAllToolStripMenuItem.Text = "Install All";
            this.InstallAllToolStripMenuItem.Click += new System.EventHandler(this.InstallAllToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.HelpToolStripMenuItem.Text = "Help";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AboutToolStripMenuItem.Text = "About";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Ryujinx Auto Launcher and Updater";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenHomebrewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DownloadInstallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DownloadUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InstallOpenALToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InstallGitToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel ToolStripInfo;
        private System.Windows.Forms.ToolStripMenuItem InstallNetSDKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InstallAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
    }
}

