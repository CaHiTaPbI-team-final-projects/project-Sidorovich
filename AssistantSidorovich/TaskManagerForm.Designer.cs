namespace AssistantSidorovich
{
    partial class TaskManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskManagerForm));
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.dateTimeDeadline = new System.Windows.Forms.DateTimePicker();
            this.textDesription = new System.Windows.Forms.TextBox();
            this.textTitle = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxTasks = new System.Windows.Forms.ListBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightGray;
            this.btnAdd.Location = new System.Drawing.Point(9, 305);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(162, 45);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.dateTimeDeadline);
            this.groupBox1.Controls.Add(this.textDesription);
            this.groupBox1.Controls.Add(this.textTitle);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 476);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.LightGray;
            this.btnDel.Location = new System.Drawing.Point(8, 417);
            this.btnDel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(162, 45);
            this.btnDel.TabIndex = 23;
            this.btnDel.Text = "Удалить";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.LightGray;
            this.btnEdit.Location = new System.Drawing.Point(8, 361);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(162, 45);
            this.btnEdit.TabIndex = 21;
            this.btnEdit.Text = "Изменить";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // dateTimeDeadline
            // 
            this.dateTimeDeadline.CalendarMonthBackground = System.Drawing.Color.LightGray;
            this.dateTimeDeadline.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeDeadline.Location = new System.Drawing.Point(9, 253);
            this.dateTimeDeadline.Name = "dateTimeDeadline";
            this.dateTimeDeadline.Size = new System.Drawing.Size(165, 26);
            this.dateTimeDeadline.TabIndex = 20;
            // 
            // textDesription
            // 
            this.textDesription.BackColor = System.Drawing.Color.LightGray;
            this.textDesription.Location = new System.Drawing.Point(9, 57);
            this.textDesription.Multiline = true;
            this.textDesription.Name = "textDesription";
            this.textDesription.Size = new System.Drawing.Size(162, 190);
            this.textDesription.TabIndex = 19;
            this.textDesription.Text = "Описание";
            this.textDesription.Click += new System.EventHandler(this.textDesription_Click);
            // 
            // textTitle
            // 
            this.textTitle.BackColor = System.Drawing.Color.LightGray;
            this.textTitle.Location = new System.Drawing.Point(9, 22);
            this.textTitle.Name = "textTitle";
            this.textTitle.Size = new System.Drawing.Size(162, 26);
            this.textTitle.TabIndex = 18;
            this.textTitle.Text = "Заголовок";
            this.textTitle.Click += new System.EventHandler(this.textTitle_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.listBoxTasks);
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(174, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 476);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // listBoxTasks
            // 
            this.listBoxTasks.BackColor = System.Drawing.Color.LightGray;
            this.listBoxTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxTasks.FormattingEnabled = true;
            this.listBoxTasks.ItemHeight = 20;
            this.listBoxTasks.Location = new System.Drawing.Point(3, 253);
            this.listBoxTasks.Name = "listBoxTasks";
            this.listBoxTasks.Size = new System.Drawing.Size(274, 220);
            this.listBoxTasks.TabIndex = 1;
            this.listBoxTasks.SelectedIndexChanged += new System.EventHandler(this.listBoxTasks_SelectedIndexChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.LightGray;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox1.Location = new System.Drawing.Point(3, 22);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(274, 231);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "Описание";
            // 
            // TaskManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 476);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TaskManagerForm";
            this.Text = "Планировщик задач";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DateTimePicker dateTimeDeadline;
        private System.Windows.Forms.TextBox textDesription;
        private System.Windows.Forms.TextBox textTitle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBoxTasks;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}