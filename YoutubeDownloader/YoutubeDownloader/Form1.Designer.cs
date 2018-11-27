namespace YoutubeDownloader
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.UrlBox = new System.Windows.Forms.TextBox();
            this.DownloadButton = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Link";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // UrlBox
            // 
            this.UrlBox.Location = new System.Drawing.Point(90, 45);
            this.UrlBox.Name = "UrlBox";
            this.UrlBox.Size = new System.Drawing.Size(643, 26);
            this.UrlBox.TabIndex = 1;
            this.UrlBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // DownloadButton
            // 
            this.DownloadButton.Location = new System.Drawing.Point(241, 134);
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.Size = new System.Drawing.Size(294, 83);
            this.DownloadButton.TabIndex = 2;
            this.DownloadButton.Text = "Download";
            this.DownloadButton.UseVisualStyleBackColor = true;
            this.DownloadButton.Click += new System.EventHandler(this.DownloadButton_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(237, 279);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(64, 20);
            this.StatusLabel.TabIndex = 3;
            this.StatusLabel.Text = "Status :";
            this.StatusLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.DownloadButton);
            this.Controls.Add(this.UrlBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Youtube Downloader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UrlBox;
        private System.Windows.Forms.Button DownloadButton;
        private System.Windows.Forms.Label StatusLabel;
    }
}

