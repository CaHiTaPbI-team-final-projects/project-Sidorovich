namespace AssistantSidorovich
{
    partial class VideoDownload
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
            this.downloadTextBox = new System.Windows.Forms.TextBox();
            this.downloadButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.selecetPathButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // downloadTextBox
            // 
            this.downloadTextBox.Location = new System.Drawing.Point(28, 38);
            this.downloadTextBox.Name = "downloadTextBox";
            this.downloadTextBox.Size = new System.Drawing.Size(246, 20);
            this.downloadTextBox.TabIndex = 0;
            this.downloadTextBox.Text = "Youtube URL";
            this.downloadTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.downloadTextBox.Click += new System.EventHandler(this.downloadTextBox_Click);
            // 
            // downloadButton
            // 
            this.downloadButton.BackColor = System.Drawing.SystemColors.Control;
            this.downloadButton.ForeColor = System.Drawing.Color.Red;
            this.downloadButton.Location = new System.Drawing.Point(28, 109);
            this.downloadButton.Margin = new System.Windows.Forms.Padding(4);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(111, 23);
            this.downloadButton.TabIndex = 1;
            this.downloadButton.Text = "Download";
            this.downloadButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.downloadButton.UseVisualStyleBackColor = false;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "best",
            "worst",
            ".mp4",
            ".ogg",
            ".mkv",
            ".flv",
            ".webm"});
            this.comboBox1.Location = new System.Drawing.Point(280, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(51, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // selecetPathButton
            // 
            this.selecetPathButton.Location = new System.Drawing.Point(211, 108);
            this.selecetPathButton.Name = "selecetPathButton";
            this.selecetPathButton.Size = new System.Drawing.Size(120, 23);
            this.selecetPathButton.TabIndex = 3;
            this.selecetPathButton.Text = "SelecPath";
            this.selecetPathButton.UseVisualStyleBackColor = true;
            this.selecetPathButton.Click += new System.EventHandler(this.selecetPathButton_Click);
            // 
            // VideoDownload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(346, 143);
            this.Controls.Add(this.selecetPathButton);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.downloadTextBox);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VideoDownload";
            this.Text = "MusicManagerForm";
            this.Load += new System.EventHandler(this.VideoDownload_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox downloadTextBox;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button selecetPathButton;
    }
}