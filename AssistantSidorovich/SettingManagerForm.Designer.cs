namespace AssistantSidorovich
{
    partial class SettingManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingManagerForm));
            this.commentatorDropDownList = new System.Windows.Forms.ComboBox();
            this.voiceCheckBox = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // commentatorDropDownList
            // 
            this.commentatorDropDownList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.commentatorDropDownList.FormattingEnabled = true;
            this.commentatorDropDownList.Items.AddRange(new object[] {
            "Сидорович"});
            this.commentatorDropDownList.Location = new System.Drawing.Point(352, 57);
            this.commentatorDropDownList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.commentatorDropDownList.Name = "commentatorDropDownList";
            this.commentatorDropDownList.Size = new System.Drawing.Size(180, 28);
            this.commentatorDropDownList.TabIndex = 0;
            // 
            // voiceCheckBox
            // 
            this.voiceCheckBox.AutoSize = true;
            this.voiceCheckBox.Location = new System.Drawing.Point(357, 22);
            this.voiceCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.voiceCheckBox.Name = "voiceCheckBox";
            this.voiceCheckBox.Size = new System.Drawing.Size(174, 24);
            this.voiceCheckBox.TabIndex = 1;
            this.voiceCheckBox.Text = "Озвучка действий";
            this.voiceCheckBox.UseVisualStyleBackColor = true;
            this.voiceCheckBox.CheckedChanged += new System.EventHandler(this.voiceCheckBox_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::AssistantSidorovich.Properties.Resources._3331;
            this.pictureBox1.InitialImage = global::AssistantSidorovich.Properties.Resources._3331;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(345, 366);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // SettingManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(552, 366);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.voiceCheckBox);
            this.Controls.Add(this.commentatorDropDownList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingManagerForm";
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.SettingManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox commentatorDropDownList;
        private System.Windows.Forms.CheckBox voiceCheckBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}