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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openHomebrewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.installOpenALToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.installGitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.installNetSDKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.installAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openGameToolStripMenuItem,
            this.openHomebrewToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openGameToolStripMenuItem
            // 
            this.openGameToolStripMenuItem.Name = "openGameToolStripMenuItem";
            this.openGameToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.openGameToolStripMenuItem.Text = "Open Game";
            this.openGameToolStripMenuItem.Click += new System.EventHandler(this.OpenGameToolStripMenuItem_Click);
            // 
            // openHomebrewToolStripMenuItem
            // 
            this.openHomebrewToolStripMenuItem.Name = "openHomebrewToolStripMenuItem";
            this.openHomebrewToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.openHomebrewToolStripMenuItem.Text = "Open Homebrew";
            this.openHomebrewToolStripMenuItem.Click += new System.EventHandler(this.OpenHomebrewToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.downloadUpdateToolStripMenuItem,
            this.installOpenALToolStripMenuItem,
            this.installGitToolStripMenuItem,
            this.installNetSDKToolStripMenuItem,
            this.installAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // downloadUpdateToolStripMenuItem
            // 
            this.downloadUpdateToolStripMenuItem.Name = "downloadUpdateToolStripMenuItem";
            this.downloadUpdateToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.downloadUpdateToolStripMenuItem.Text = "Download / Update Ryujinx";
            this.downloadUpdateToolStripMenuItem.Click += new System.EventHandler(this.DownloadUpdateRyujinxToolStripMenuItem_Click);
            // 
            // installOpenALToolStripMenuItem
            // 
            this.installOpenALToolStripMenuItem.Name = "installOpenALToolStripMenuItem";
            this.installOpenALToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.installOpenALToolStripMenuItem.Text = "Install OpenAL";
            this.installOpenALToolStripMenuItem.Click += new System.EventHandler(this.InstallOpenALToolStripMenuItem_Click);
            // 
            // installGitToolStripMenuItem
            // 
            this.installGitToolStripMenuItem.Name = "installGitToolStripMenuItem";
            this.installGitToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.installGitToolStripMenuItem.Text = "Install Git";
            this.installGitToolStripMenuItem.Click += new System.EventHandler(this.InstallGitToolStripMenuItem_Click);
            // 
            // installNetSDKToolStripMenuItem
            // 
            this.installNetSDKToolStripMenuItem.Name = "installNetSDKToolStripMenuItem";
            this.installNetSDKToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.installNetSDKToolStripMenuItem.Text = "Install .Net SDK";
            this.installNetSDKToolStripMenuItem.Click += new System.EventHandler(this.InstallNetSDKToolStripMenuItem_Click);
            // 
            // installAllToolStripMenuItem
            // 
            this.installAllToolStripMenuItem.Name = "installAllToolStripMenuItem";
            this.installAllToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.installAllToolStripMenuItem.Text = "Install All";
            this.installAllToolStripMenuItem.Click += new System.EventHandler(this.InstallAllToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
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
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openHomebrewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem installOpenALToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem installGitToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel ToolStripInfo;
        private System.Windows.Forms.ToolStripMenuItem installNetSDKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem installAllToolStripMenuItem;
    }
}

