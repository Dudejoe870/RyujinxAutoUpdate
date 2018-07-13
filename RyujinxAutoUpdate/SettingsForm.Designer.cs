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
            this.listView1.ItemActivate += new System.EventHandler(this.listView1_ItemActivate);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
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
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1037, 549);
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
    }
}