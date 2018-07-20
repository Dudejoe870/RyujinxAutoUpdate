namespace RyujinxAutoUpdate
{
    partial class AddGameListEntry
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
            this.PathText = new System.Windows.Forms.TextBox();
            this.SelectGamePath = new System.Windows.Forms.Button();
            this.GameName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PublisherName = new System.Windows.Forms.TextBox();
            this.SelectNacpPath = new System.Windows.Forms.Button();
            this.ContentNacpPath = new System.Windows.Forms.TextBox();
            this.SelectThumbnail = new System.Windows.Forms.Button();
            this.ThumbnailPath = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Thumbnail = new System.Windows.Forms.PictureBox();
            this.GetMetadataCDN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Thumbnail)).BeginInit();
            this.SuspendLayout();
            // 
            // PathText
            // 
            this.PathText.Location = new System.Drawing.Point(12, 51);
            this.PathText.Name = "PathText";
            this.PathText.ReadOnly = true;
            this.PathText.Size = new System.Drawing.Size(400, 20);
            this.PathText.TabIndex = 0;
            // 
            // SelectGamePath
            // 
            this.SelectGamePath.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectGamePath.Location = new System.Drawing.Point(12, 12);
            this.SelectGamePath.Name = "SelectGamePath";
            this.SelectGamePath.Size = new System.Drawing.Size(138, 33);
            this.SelectGamePath.TabIndex = 1;
            this.SelectGamePath.Text = "Select Game Path";
            this.SelectGamePath.UseVisualStyleBackColor = true;
            this.SelectGamePath.Click += new System.EventHandler(this.SelectGamePath_Click);
            // 
            // GameName
            // 
            this.GameName.Location = new System.Drawing.Point(12, 215);
            this.GameName.Name = "GameName";
            this.GameName.Size = new System.Drawing.Size(217, 20);
            this.GameName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Game Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Publisher Name:";
            // 
            // PublisherName
            // 
            this.PublisherName.Location = new System.Drawing.Point(12, 261);
            this.PublisherName.Name = "PublisherName";
            this.PublisherName.Size = new System.Drawing.Size(217, 20);
            this.PublisherName.TabIndex = 4;
            // 
            // SelectNacpPath
            // 
            this.SelectNacpPath.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectNacpPath.Location = new System.Drawing.Point(12, 97);
            this.SelectNacpPath.Name = "SelectNacpPath";
            this.SelectNacpPath.Size = new System.Drawing.Size(191, 53);
            this.SelectNacpPath.TabIndex = 7;
            this.SelectNacpPath.Text = "Select Control.nacp Path (Optional)";
            this.SelectNacpPath.UseVisualStyleBackColor = true;
            this.SelectNacpPath.Click += new System.EventHandler(this.SelectNacpPath_Click);
            // 
            // ContentNacpPath
            // 
            this.ContentNacpPath.Location = new System.Drawing.Point(12, 156);
            this.ContentNacpPath.Name = "ContentNacpPath";
            this.ContentNacpPath.ReadOnly = true;
            this.ContentNacpPath.Size = new System.Drawing.Size(400, 20);
            this.ContentNacpPath.TabIndex = 8;
            // 
            // SelectThumbnail
            // 
            this.SelectThumbnail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectThumbnail.Location = new System.Drawing.Point(12, 287);
            this.SelectThumbnail.Name = "SelectThumbnail";
            this.SelectThumbnail.Size = new System.Drawing.Size(191, 53);
            this.SelectThumbnail.TabIndex = 9;
            this.SelectThumbnail.Text = "Select Thumbnail Image (Optional)";
            this.SelectThumbnail.UseVisualStyleBackColor = true;
            this.SelectThumbnail.Click += new System.EventHandler(this.SelectThumbnail_Click);
            // 
            // ThumbnailPath
            // 
            this.ThumbnailPath.Location = new System.Drawing.Point(12, 346);
            this.ThumbnailPath.Name = "ThumbnailPath";
            this.ThumbnailPath.ReadOnly = true;
            this.ThumbnailPath.Size = new System.Drawing.Size(400, 20);
            this.ThumbnailPath.TabIndex = 10;
            // 
            // Add
            // 
            this.Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Add.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(1072, 610);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 11;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Thumbnail
            // 
            this.Thumbnail.Location = new System.Drawing.Point(12, 372);
            this.Thumbnail.Name = "Thumbnail";
            this.Thumbnail.Size = new System.Drawing.Size(256, 256);
            this.Thumbnail.TabIndex = 12;
            this.Thumbnail.TabStop = false;
            // 
            // GetMetadataCDN
            // 
            this.GetMetadataCDN.Enabled = false;
            this.GetMetadataCDN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetMetadataCDN.Location = new System.Drawing.Point(209, 108);
            this.GetMetadataCDN.Name = "GetMetadataCDN";
            this.GetMetadataCDN.Size = new System.Drawing.Size(156, 33);
            this.GetMetadataCDN.TabIndex = 13;
            this.GetMetadataCDN.Text = "Get Metadata from CDN";
            this.GetMetadataCDN.UseVisualStyleBackColor = true;
            this.GetMetadataCDN.Visible = false;
            this.GetMetadataCDN.Click += new System.EventHandler(this.GetMetadataCDN_Click);
            // 
            // AddGameListEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 645);
            this.Controls.Add(this.GetMetadataCDN);
            this.Controls.Add(this.Thumbnail);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.ThumbnailPath);
            this.Controls.Add(this.SelectThumbnail);
            this.Controls.Add(this.ContentNacpPath);
            this.Controls.Add(this.SelectNacpPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PublisherName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GameName);
            this.Controls.Add(this.SelectGamePath);
            this.Controls.Add(this.PathText);
            this.Name = "AddGameListEntry";
            this.Text = "Add Game Entry";
            this.Load += new System.EventHandler(this.AddGameListEntry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Thumbnail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PathText;
        private System.Windows.Forms.Button SelectGamePath;
        private System.Windows.Forms.TextBox GameName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PublisherName;
        private System.Windows.Forms.Button SelectNacpPath;
        private System.Windows.Forms.TextBox ContentNacpPath;
        private System.Windows.Forms.Button SelectThumbnail;
        private System.Windows.Forms.TextBox ThumbnailPath;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.PictureBox Thumbnail;
        private System.Windows.Forms.Button GetMetadataCDN;
    }
}