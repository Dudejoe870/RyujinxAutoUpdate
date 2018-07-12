namespace RyujinxAutoUpdate
{
    partial class SettingsForm
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
            this.Cancel = new System.Windows.Forms.Button();
            this.Apply = new System.Windows.Forms.Button();
            this.ShouldOpenDefaultHomebrewCheck = new System.Windows.Forms.CheckBox();
            this.DefaultApp = new System.Windows.Forms.Button();
            this.ShowRyujinxConsoleCheck = new System.Windows.Forms.CheckBox();
            this.DefaultAppPath = new System.Windows.Forms.TextBox();
            this.ShowBuildConsoleCheck = new System.Windows.Forms.CheckBox();
            this.WriteBuildLogCheck = new System.Windows.Forms.CheckBox();
            this.WriteRyujinxLogCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cancel.Location = new System.Drawing.Point(950, 514);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 0;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Apply
            // 
            this.Apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Apply.Location = new System.Drawing.Point(869, 514);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(75, 23);
            this.Apply.TabIndex = 1;
            this.Apply.Text = "Apply";
            this.Apply.UseVisualStyleBackColor = true;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // ShouldOpenDefaultHomebrewCheck
            // 
            this.ShouldOpenDefaultHomebrewCheck.AutoSize = true;
            this.ShouldOpenDefaultHomebrewCheck.Location = new System.Drawing.Point(12, 12);
            this.ShouldOpenDefaultHomebrewCheck.Name = "ShouldOpenDefaultHomebrewCheck";
            this.ShouldOpenDefaultHomebrewCheck.Size = new System.Drawing.Size(165, 17);
            this.ShouldOpenDefaultHomebrewCheck.TabIndex = 2;
            this.ShouldOpenDefaultHomebrewCheck.Text = "Open Default Homebrew App";
            this.ShouldOpenDefaultHomebrewCheck.UseVisualStyleBackColor = true;
            this.ShouldOpenDefaultHomebrewCheck.CheckedChanged += new System.EventHandler(this.ShouldOpenDefaultHomebrewCheck_CheckedChanged);
            // 
            // DefaultApp
            // 
            this.DefaultApp.Enabled = false;
            this.DefaultApp.Location = new System.Drawing.Point(12, 35);
            this.DefaultApp.Name = "DefaultApp";
            this.DefaultApp.Size = new System.Drawing.Size(165, 23);
            this.DefaultApp.TabIndex = 3;
            this.DefaultApp.Text = "Select Default App";
            this.DefaultApp.UseVisualStyleBackColor = true;
            this.DefaultApp.Click += new System.EventHandler(this.DefaultApp_Click);
            // 
            // ShowRyujinxConsoleCheck
            // 
            this.ShowRyujinxConsoleCheck.AutoSize = true;
            this.ShowRyujinxConsoleCheck.Location = new System.Drawing.Point(183, 12);
            this.ShowRyujinxConsoleCheck.Name = "ShowRyujinxConsoleCheck";
            this.ShowRyujinxConsoleCheck.Size = new System.Drawing.Size(131, 17);
            this.ShowRyujinxConsoleCheck.TabIndex = 4;
            this.ShowRyujinxConsoleCheck.Text = "Show Ryujinx Console";
            this.ShowRyujinxConsoleCheck.UseVisualStyleBackColor = true;
            this.ShowRyujinxConsoleCheck.CheckedChanged += new System.EventHandler(this.ShowRyujinxConsoleCheck_CheckedChanged);
            // 
            // DefaultAppPath
            // 
            this.DefaultAppPath.Enabled = false;
            this.DefaultAppPath.Location = new System.Drawing.Point(12, 64);
            this.DefaultAppPath.Name = "DefaultAppPath";
            this.DefaultAppPath.ReadOnly = true;
            this.DefaultAppPath.Size = new System.Drawing.Size(302, 20);
            this.DefaultAppPath.TabIndex = 5;
            // 
            // ShowBuildConsoleCheck
            // 
            this.ShowBuildConsoleCheck.AutoSize = true;
            this.ShowBuildConsoleCheck.Location = new System.Drawing.Point(451, 12);
            this.ShowBuildConsoleCheck.Name = "ShowBuildConsoleCheck";
            this.ShowBuildConsoleCheck.Size = new System.Drawing.Size(120, 17);
            this.ShowBuildConsoleCheck.TabIndex = 6;
            this.ShowBuildConsoleCheck.Text = "Show Build Console";
            this.ShowBuildConsoleCheck.UseVisualStyleBackColor = true;
            this.ShowBuildConsoleCheck.CheckedChanged += new System.EventHandler(this.ShowBuildConsoleCheck_CheckedChanged);
            // 
            // WriteBuildLogCheck
            // 
            this.WriteBuildLogCheck.AutoSize = true;
            this.WriteBuildLogCheck.Location = new System.Drawing.Point(577, 12);
            this.WriteBuildLogCheck.Name = "WriteBuildLogCheck";
            this.WriteBuildLogCheck.Size = new System.Drawing.Size(114, 17);
            this.WriteBuildLogCheck.TabIndex = 7;
            this.WriteBuildLogCheck.Text = "Write To Build Log";
            this.WriteBuildLogCheck.UseVisualStyleBackColor = true;
            this.WriteBuildLogCheck.CheckedChanged += new System.EventHandler(this.WriteBuildLogCheck_CheckedChanged);
            // 
            // WriteRyujinxLogCheck
            // 
            this.WriteRyujinxLogCheck.AutoSize = true;
            this.WriteRyujinxLogCheck.Location = new System.Drawing.Point(320, 12);
            this.WriteRyujinxLogCheck.Name = "WriteRyujinxLogCheck";
            this.WriteRyujinxLogCheck.Size = new System.Drawing.Size(125, 17);
            this.WriteRyujinxLogCheck.TabIndex = 8;
            this.WriteRyujinxLogCheck.Text = "Write To Ryujinx Log";
            this.WriteRyujinxLogCheck.UseVisualStyleBackColor = true;
            this.WriteRyujinxLogCheck.CheckedChanged += new System.EventHandler(this.WriteRyujinxLogCheck_CheckedChanged);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 549);
            this.Controls.Add(this.WriteRyujinxLogCheck);
            this.Controls.Add(this.WriteBuildLogCheck);
            this.Controls.Add(this.ShowBuildConsoleCheck);
            this.Controls.Add(this.DefaultAppPath);
            this.Controls.Add(this.ShowRyujinxConsoleCheck);
            this.Controls.Add(this.DefaultApp);
            this.Controls.Add(this.ShouldOpenDefaultHomebrewCheck);
            this.Controls.Add(this.Apply);
            this.Controls.Add(this.Cancel);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Apply;
        private System.Windows.Forms.CheckBox ShouldOpenDefaultHomebrewCheck;
        private System.Windows.Forms.Button DefaultApp;
        private System.Windows.Forms.CheckBox ShowRyujinxConsoleCheck;
        private System.Windows.Forms.TextBox DefaultAppPath;
        private System.Windows.Forms.CheckBox ShowBuildConsoleCheck;
        private System.Windows.Forms.CheckBox WriteBuildLogCheck;
        private System.Windows.Forms.CheckBox WriteRyujinxLogCheck;
    }
}