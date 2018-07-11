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
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 549);
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
    }
}