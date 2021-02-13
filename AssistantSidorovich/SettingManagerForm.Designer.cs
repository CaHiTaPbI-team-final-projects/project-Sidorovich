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
            this.commentatorDropDownList = new System.Windows.Forms.ComboBox();
            this.voiceCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // commentatorDropDownList
            // 
            this.commentatorDropDownList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.commentatorDropDownList.FormattingEnabled = true;
            this.commentatorDropDownList.Items.AddRange(new object[] {
            "Сидорович"});
            this.commentatorDropDownList.Location = new System.Drawing.Point(235, 37);
            this.commentatorDropDownList.Name = "commentatorDropDownList";
            this.commentatorDropDownList.Size = new System.Drawing.Size(121, 21);
            this.commentatorDropDownList.TabIndex = 0;
            // 
            // voiceCheckBox
            // 
            this.voiceCheckBox.AutoSize = true;
            this.voiceCheckBox.Location = new System.Drawing.Point(238, 14);
            this.voiceCheckBox.Name = "voiceCheckBox";
            this.voiceCheckBox.Size = new System.Drawing.Size(118, 17);
            this.voiceCheckBox.TabIndex = 1;
            this.voiceCheckBox.Text = "Озвучка действий";
            this.voiceCheckBox.UseVisualStyleBackColor = true;
            this.voiceCheckBox.CheckedChanged += new System.EventHandler(this.voiceCheckBox_CheckedChanged);
            // 
            // SettingManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 238);
            this.Controls.Add(this.voiceCheckBox);
            this.Controls.Add(this.commentatorDropDownList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingManagerForm";
            this.Text = "SettingsManagerForm";
            this.Load += new System.EventHandler(this.SettingManagerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox commentatorDropDownList;
        private System.Windows.Forms.CheckBox voiceCheckBox;
    }
}