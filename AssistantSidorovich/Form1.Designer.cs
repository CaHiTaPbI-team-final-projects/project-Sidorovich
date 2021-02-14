namespace AssistantSidorovich
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ClocksButton = new System.Windows.Forms.Button();
            this.TasksManagerButton = new System.Windows.Forms.Button();
            this.FastAppButton = new System.Windows.Forms.Button();
            this.JokesButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.MusicSearchButton = new System.Windows.Forms.Button();
            this.IconFinderSearchButton = new System.Windows.Forms.Button();
            this.GoogleSearchButton = new System.Windows.Forms.Button();
            this.DownloadVideoButton = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 43);
            this.panel1.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(456, 35);
            this.textBox1.TabIndex = 9;
            // 
            // ClocksButton
            // 
            this.ClocksButton.BackColor = System.Drawing.Color.LightGray;
            this.ClocksButton.Location = new System.Drawing.Point(18, 152);
            this.ClocksButton.Margin = new System.Windows.Forms.Padding(4);
            this.ClocksButton.Name = "ClocksButton";
            this.ClocksButton.Size = new System.Drawing.Size(134, 109);
            this.ClocksButton.TabIndex = 4;
            this.ClocksButton.Text = "Часы";
            this.ClocksButton.UseVisualStyleBackColor = false;
            this.ClocksButton.Click += new System.EventHandler(this.ClocksButton_Click);
            // 
            // TasksManagerButton
            // 
            this.TasksManagerButton.BackColor = System.Drawing.Color.LightGray;
            this.TasksManagerButton.Location = new System.Drawing.Point(18, 269);
            this.TasksManagerButton.Margin = new System.Windows.Forms.Padding(4);
            this.TasksManagerButton.Name = "TasksManagerButton";
            this.TasksManagerButton.Size = new System.Drawing.Size(134, 109);
            this.TasksManagerButton.TabIndex = 6;
            this.TasksManagerButton.Text = "Планировщик";
            this.TasksManagerButton.UseVisualStyleBackColor = false;
            this.TasksManagerButton.Click += new System.EventHandler(this.TasksManagerButton_Click);
            // 
            // FastAppButton
            // 
            this.FastAppButton.BackColor = System.Drawing.Color.LightGray;
            this.FastAppButton.Location = new System.Drawing.Point(303, 269);
            this.FastAppButton.Margin = new System.Windows.Forms.Padding(4);
            this.FastAppButton.Name = "FastAppButton";
            this.FastAppButton.Size = new System.Drawing.Size(134, 109);
            this.FastAppButton.TabIndex = 5;
            this.FastAppButton.Text = "Быстрый доступ";
            this.FastAppButton.UseVisualStyleBackColor = false;
            this.FastAppButton.Click += new System.EventHandler(this.FastAppButton_Click);
            // 
            // JokesButton
            // 
            this.JokesButton.BackColor = System.Drawing.Color.LightGray;
            this.JokesButton.Location = new System.Drawing.Point(303, 152);
            this.JokesButton.Margin = new System.Windows.Forms.Padding(4);
            this.JokesButton.Name = "JokesButton";
            this.JokesButton.Size = new System.Drawing.Size(136, 109);
            this.JokesButton.TabIndex = 3;
            this.JokesButton.Text = "Анекдоты";
            this.JokesButton.UseVisualStyleBackColor = false;
            this.JokesButton.Click += new System.EventHandler(this.JokesButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackColor = System.Drawing.Color.LightGray;
            this.SettingsButton.Location = new System.Drawing.Point(160, 269);
            this.SettingsButton.Margin = new System.Windows.Forms.Padding(4);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(134, 109);
            this.SettingsButton.TabIndex = 8;
            this.SettingsButton.Text = "Настройки";
            this.SettingsButton.UseVisualStyleBackColor = false;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.LightGray;
            this.ExitButton.Location = new System.Drawing.Point(160, 389);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(134, 109);
            this.ExitButton.TabIndex = 9;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MusicSearchButton
            // 
            this.MusicSearchButton.BackColor = System.Drawing.Color.LightGray;
            this.MusicSearchButton.Location = new System.Drawing.Point(303, 52);
            this.MusicSearchButton.Margin = new System.Windows.Forms.Padding(4);
            this.MusicSearchButton.Name = "MusicSearchButton";
            this.MusicSearchButton.Size = new System.Drawing.Size(134, 44);
            this.MusicSearchButton.TabIndex = 13;
            this.MusicSearchButton.Text = "Music";
            this.MusicSearchButton.UseVisualStyleBackColor = false;
            this.MusicSearchButton.Click += new System.EventHandler(this.MusicSearchButton_Click);
            // 
            // IconFinderSearchButton
            // 
            this.IconFinderSearchButton.BackColor = System.Drawing.Color.LightGray;
            this.IconFinderSearchButton.Location = new System.Drawing.Point(160, 52);
            this.IconFinderSearchButton.Margin = new System.Windows.Forms.Padding(4);
            this.IconFinderSearchButton.Name = "IconFinderSearchButton";
            this.IconFinderSearchButton.Size = new System.Drawing.Size(134, 44);
            this.IconFinderSearchButton.TabIndex = 14;
            this.IconFinderSearchButton.Text = "IconFinder";
            this.IconFinderSearchButton.UseVisualStyleBackColor = false;
            this.IconFinderSearchButton.Click += new System.EventHandler(this.IconFinderSearchButton_Click);
            // 
            // GoogleSearchButton
            // 
            this.GoogleSearchButton.BackColor = System.Drawing.Color.LightGray;
            this.GoogleSearchButton.Location = new System.Drawing.Point(18, 52);
            this.GoogleSearchButton.Margin = new System.Windows.Forms.Padding(4);
            this.GoogleSearchButton.Name = "GoogleSearchButton";
            this.GoogleSearchButton.Size = new System.Drawing.Size(134, 44);
            this.GoogleSearchButton.TabIndex = 15;
            this.GoogleSearchButton.Text = "  Google";
            this.GoogleSearchButton.UseVisualStyleBackColor = false;
            this.GoogleSearchButton.Click += new System.EventHandler(this.GoogleSearchButton_Click);
            // 
            // DownloadVideoButton
            // 
            this.DownloadVideoButton.BackColor = System.Drawing.Color.LightGray;
            this.DownloadVideoButton.Location = new System.Drawing.Point(160, 152);
            this.DownloadVideoButton.Margin = new System.Windows.Forms.Padding(4);
            this.DownloadVideoButton.Name = "DownloadVideoButton";
            this.DownloadVideoButton.Size = new System.Drawing.Size(134, 109);
            this.DownloadVideoButton.TabIndex = 11;
            this.DownloadVideoButton.Text = "Скачивание видео";
            this.DownloadVideoButton.UseVisualStyleBackColor = false;
            this.DownloadVideoButton.Click += new System.EventHandler(this.DownloadVideoButton_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 341);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(4);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(304, 44);
            this.axWindowsMediaPlayer1.TabIndex = 19;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "AssistantSidorovich";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(456, 594);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.GoogleSearchButton);
            this.Controls.Add(this.IconFinderSearchButton);
            this.Controls.Add(this.MusicSearchButton);
            this.Controls.Add(this.DownloadVideoButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.JokesButton);
            this.Controls.Add(this.ClocksButton);
            this.Controls.Add(this.FastAppButton);
            this.Controls.Add(this.TasksManagerButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "AssistantSidorovich";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ClocksButton;
        private System.Windows.Forms.Button TasksManagerButton;
        private System.Windows.Forms.Button FastAppButton;
        private System.Windows.Forms.Button JokesButton;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button MusicSearchButton;
        private System.Windows.Forms.Button IconFinderSearchButton;
        private System.Windows.Forms.Button GoogleSearchButton;
        private System.Windows.Forms.Button DownloadVideoButton;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

