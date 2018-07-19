namespace RyujinxAutoUpdate
{
    partial class RemoveGameListEntry
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
            this.RemoveGameList = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // RemoveGameList
            // 
            this.RemoveGameList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveGameList.BackColor = System.Drawing.Color.DarkGray;
            this.RemoveGameList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RemoveGameList.Location = new System.Drawing.Point(12, 12);
            this.RemoveGameList.Name = "RemoveGameList";
            this.RemoveGameList.Size = new System.Drawing.Size(940, 509);
            this.RemoveGameList.TabIndex = 0;
            this.RemoveGameList.UseCompatibleStateImageBehavior = false;
            this.RemoveGameList.ItemActivate += new System.EventHandler(this.RemoveGameList_ItemActivate);
            // 
            // RemoveGameListEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 533);
            this.Controls.Add(this.RemoveGameList);
            this.Name = "RemoveGameListEntry";
            this.Text = "Select A Game to Remove";
            this.Load += new System.EventHandler(this.RemoveGameListEntry_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView RemoveGameList;
    }
}