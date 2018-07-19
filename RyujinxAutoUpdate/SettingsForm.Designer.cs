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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.CurrentBranchLabel = new System.Windows.Forms.Label();
            this.GitLoginUsername = new System.Windows.Forms.TextBox();
            this.GitLoginEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.GitLoginButton = new System.Windows.Forms.Button();
            this.IconSize = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
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
            this.ShouldOpenDefaultHomebrewCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShouldOpenDefaultHomebrewCheck.Location = new System.Drawing.Point(12, 25);
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
            this.DefaultApp.Location = new System.Drawing.Point(12, 47);
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
            this.ShowRyujinxConsoleCheck.Location = new System.Drawing.Point(12, 100);
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
            this.DefaultAppPath.Location = new System.Drawing.Point(183, 47);
            this.DefaultAppPath.Name = "DefaultAppPath";
            this.DefaultAppPath.ReadOnly = true;
            this.DefaultAppPath.Size = new System.Drawing.Size(289, 20);
            this.DefaultAppPath.TabIndex = 5;
            // 
            // ShowBuildConsoleCheck
            // 
            this.ShowBuildConsoleCheck.AutoSize = true;
            this.ShowBuildConsoleCheck.Location = new System.Drawing.Point(12, 143);
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
            this.WriteBuildLogCheck.Location = new System.Drawing.Point(149, 143);
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
            this.WriteRyujinxLogCheck.Location = new System.Drawing.Point(149, 100);
            this.WriteRyujinxLogCheck.Name = "WriteRyujinxLogCheck";
            this.WriteRyujinxLogCheck.Size = new System.Drawing.Size(125, 17);
            this.WriteRyujinxLogCheck.TabIndex = 8;
            this.WriteRyujinxLogCheck.Text = "Write To Ryujinx Log";
            this.WriteRyujinxLogCheck.UseVisualStyleBackColor = true;
            this.WriteRyujinxLogCheck.CheckedChanged += new System.EventHandler(this.WriteRyujinxLogCheck_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Build Settings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ryujinx Settings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Homebrew Settings";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Git Settings";
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.Location = new System.Drawing.Point(12, 207);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(262, 330);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.ItemActivate += new System.EventHandler(this.ListView1_ItemActivate);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(237, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Double click branch to attempt auto-merge";
            // 
            // CurrentBranchLabel
            // 
            this.CurrentBranchLabel.AutoSize = true;
            this.CurrentBranchLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentBranchLabel.Location = new System.Drawing.Point(253, 189);
            this.CurrentBranchLabel.Name = "CurrentBranchLabel";
            this.CurrentBranchLabel.Size = new System.Drawing.Size(97, 17);
            this.CurrentBranchLabel.TabIndex = 15;
            this.CurrentBranchLabel.Text = "Current Branch:";
            // 
            // GitLoginUsername
            // 
            this.GitLoginUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GitLoginUsername.Location = new System.Drawing.Point(719, 25);
            this.GitLoginUsername.Name = "GitLoginUsername";
            this.GitLoginUsername.Size = new System.Drawing.Size(211, 20);
            this.GitLoginUsername.TabIndex = 16;
            // 
            // GitLoginEmail
            // 
            this.GitLoginEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GitLoginEmail.Location = new System.Drawing.Point(719, 51);
            this.GitLoginEmail.Name = "GitLoginEmail";
            this.GitLoginEmail.Size = new System.Drawing.Size(211, 20);
            this.GitLoginEmail.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(623, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Git Username:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(651, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Git Email:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(716, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(316, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Note: This is required for Merging Branches to work.";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(622, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 21);
            this.label9.TabIndex = 21;
            this.label9.Text = "Git Login";
            // 
            // GitLoginButton
            // 
            this.GitLoginButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GitLoginButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GitLoginButton.Location = new System.Drawing.Point(719, 100);
            this.GitLoginButton.Name = "GitLoginButton";
            this.GitLoginButton.Size = new System.Drawing.Size(74, 26);
            this.GitLoginButton.TabIndex = 22;
            this.GitLoginButton.Text = "Login";
            this.GitLoginButton.UseVisualStyleBackColor = true;
            this.GitLoginButton.Click += new System.EventHandler(this.GitLoginButton_Click);
            // 
            // IconSize
            // 
            this.IconSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IconSize.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconSize.FormattingEnabled = true;
            this.IconSize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.IconSize.Items.AddRange(new object[] {
            "Large",
            "Medium",
            "Small"});
            this.IconSize.Location = new System.Drawing.Point(752, 159);
            this.IconSize.Name = "IconSize";
            this.IconSize.Size = new System.Drawing.Size(135, 25);
            this.IconSize.TabIndex = 23;
            this.IconSize.SelectedIndexChanged += new System.EventHandler(this.GameListIconSize_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(622, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 21);
            this.label10.TabIndex = 24;
            this.label10.Text = "Game List Settings";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(623, 162);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = "Game List Icon Size:";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1037, 549);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.IconSize);
            this.Controls.Add(this.GitLoginButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.GitLoginEmail);
            this.Controls.Add(this.GitLoginUsername);
            this.Controls.Add(this.CurrentBranchLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label CurrentBranchLabel;
        private System.Windows.Forms.TextBox GitLoginUsername;
        private System.Windows.Forms.TextBox GitLoginEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button GitLoginButton;
        private System.Windows.Forms.ComboBox IconSize;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}