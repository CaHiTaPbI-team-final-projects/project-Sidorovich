namespace AssistantSidorovich
{
    partial class FastAppForm
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
            this.BindsList = new System.Windows.Forms.ListBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.DelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.BindButton3CB = new System.Windows.Forms.ComboBox();
            this.BindButton2CB = new System.Windows.Forms.ComboBox();
            this.BindButton1CB = new System.Windows.Forms.ComboBox();
            this.ChooseButton = new System.Windows.Forms.Button();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.TwoBindsRB = new System.Windows.Forms.RadioButton();
            this.ThreeBindsRB = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.AutoLoadCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BindsList
            // 
            this.BindsList.FormattingEnabled = true;
            this.BindsList.Location = new System.Drawing.Point(291, 6);
            this.BindsList.Name = "BindsList";
            this.BindsList.ScrollAlwaysVisible = true;
            this.BindsList.Size = new System.Drawing.Size(218, 238);
            this.BindsList.TabIndex = 0;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(9, 221);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(88, 23);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DelButton
            // 
            this.DelButton.Location = new System.Drawing.Point(103, 221);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(88, 23);
            this.DelButton.TabIndex = 2;
            this.DelButton.Text = "Удалить";
            this.DelButton.UseVisualStyleBackColor = true;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(197, 221);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(88, 23);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Обновить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // BindButton3CB
            // 
            this.BindButton3CB.FormattingEnabled = true;
            this.BindButton3CB.Location = new System.Drawing.Point(197, 102);
            this.BindButton3CB.Name = "BindButton3CB";
            this.BindButton3CB.Size = new System.Drawing.Size(88, 21);
            this.BindButton3CB.TabIndex = 4;
            // 
            // BindButton2CB
            // 
            this.BindButton2CB.Enabled = false;
            this.BindButton2CB.FormattingEnabled = true;
            this.BindButton2CB.Location = new System.Drawing.Point(103, 102);
            this.BindButton2CB.Name = "BindButton2CB";
            this.BindButton2CB.Size = new System.Drawing.Size(88, 21);
            this.BindButton2CB.TabIndex = 5;
            // 
            // BindButton1CB
            // 
            this.BindButton1CB.FormattingEnabled = true;
            this.BindButton1CB.Location = new System.Drawing.Point(12, 102);
            this.BindButton1CB.Name = "BindButton1CB";
            this.BindButton1CB.Size = new System.Drawing.Size(88, 21);
            this.BindButton1CB.TabIndex = 6;
            // 
            // ChooseButton
            // 
            this.ChooseButton.Location = new System.Drawing.Point(65, 38);
            this.ChooseButton.Name = "ChooseButton";
            this.ChooseButton.Size = new System.Drawing.Size(75, 23);
            this.ChooseButton.TabIndex = 8;
            this.ChooseButton.Text = "Выбрать";
            this.ChooseButton.UseVisualStyleBackColor = true;
            this.ChooseButton.Click += new System.EventHandler(this.ChooseButton_Click);
            // 
            // AddressBox
            // 
            this.AddressBox.Location = new System.Drawing.Point(12, 12);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(276, 20);
            this.AddressBox.TabIndex = 9;
            // 
            // TwoBindsRB
            // 
            this.TwoBindsRB.AutoSize = true;
            this.TwoBindsRB.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TwoBindsRB.Checked = true;
            this.TwoBindsRB.Location = new System.Drawing.Point(245, 69);
            this.TwoBindsRB.Name = "TwoBindsRB";
            this.TwoBindsRB.Size = new System.Drawing.Size(17, 30);
            this.TwoBindsRB.TabIndex = 11;
            this.TwoBindsRB.TabStop = true;
            this.TwoBindsRB.Text = "2";
            this.TwoBindsRB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TwoBindsRB.UseVisualStyleBackColor = true;
            this.TwoBindsRB.CheckedChanged += new System.EventHandler(this.TwoBindsRB_CheckedChanged);
            // 
            // ThreeBindsRB
            // 
            this.ThreeBindsRB.AutoSize = true;
            this.ThreeBindsRB.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ThreeBindsRB.Location = new System.Drawing.Point(268, 69);
            this.ThreeBindsRB.Name = "ThreeBindsRB";
            this.ThreeBindsRB.Size = new System.Drawing.Size(17, 30);
            this.ThreeBindsRB.TabIndex = 12;
            this.ThreeBindsRB.Text = "3";
            this.ThreeBindsRB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ThreeBindsRB.UseVisualStyleBackColor = true;
            this.ThreeBindsRB.CheckedChanged += new System.EventHandler(this.ThreeBindsRB_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label1.Location = new System.Drawing.Point(9, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Количество клавиш для бинда:";
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(143, 38);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 14;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // AutoLoadCB
            // 
            this.AutoLoadCB.FormattingEnabled = true;
            this.AutoLoadCB.Location = new System.Drawing.Point(12, 149);
            this.AutoLoadCB.Name = "AutoLoadCB";
            this.AutoLoadCB.Size = new System.Drawing.Size(272, 21);
            this.AutoLoadCB.TabIndex = 18;
            this.AutoLoadCB.SelectedIndexChanged += new System.EventHandler(this.AutoLoadCB_SelectedIndexChanged);
            // 
            // FastAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 249);
            this.Controls.Add(this.AutoLoadCB);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ThreeBindsRB);
            this.Controls.Add(this.TwoBindsRB);
            this.Controls.Add(this.AddressBox);
            this.Controls.Add(this.ChooseButton);
            this.Controls.Add(this.BindButton1CB);
            this.Controls.Add(this.BindButton2CB);
            this.Controls.Add(this.BindButton3CB);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DelButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.BindsList);
            this.KeyPreview = true;
            this.Name = "FastAppForm";
            this.Text = "FastAppForm";
            this.Load += new System.EventHandler(this.FastAppForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FastAppForm_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox BindsList;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DelButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.ComboBox BindButton3CB;
        private System.Windows.Forms.ComboBox BindButton2CB;
        private System.Windows.Forms.ComboBox BindButton1CB;
        private System.Windows.Forms.Button ChooseButton;
        private System.Windows.Forms.TextBox AddressBox;
        private System.Windows.Forms.RadioButton TwoBindsRB;
        private System.Windows.Forms.RadioButton ThreeBindsRB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.ComboBox AutoLoadCB;
    }
}