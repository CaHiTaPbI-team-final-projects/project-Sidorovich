namespace AssistantSidorovich
{
    partial class TimerForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimerForm));
            this.btnTimer = new System.Windows.Forms.Button();
            this.btnAlarm = new System.Windows.Forms.Button();
            this.btnStopwatch = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Hours = new System.Windows.Forms.NumericUpDown();
            this.Seconds = new System.Windows.Forms.NumericUpDown();
            this.Minutes = new System.Windows.Forms.NumericUpDown();
            this.SetAlarm = new System.Windows.Forms.Button();
            this.AlarmOff = new System.Windows.Forms.Button();
            this.groupBoxAlarm = new System.Windows.Forms.GroupBox();
            this.groupBoxStopwatch = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.HoursTimer = new System.Windows.Forms.NumericUpDown();
            this.SecondsTimer = new System.Windows.Forms.NumericUpDown();
            this.MinutesTimer = new System.Windows.Forms.NumericUpDown();
            this.btnSetTimer = new System.Windows.Forms.Button();
            this.btnTurnOffTimer = new System.Windows.Forms.Button();
            this.groupBoxTimer = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Hours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Seconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minutes)).BeginInit();
            this.groupBoxAlarm.SuspendLayout();
            this.groupBoxStopwatch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HoursTimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondsTimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinutesTimer)).BeginInit();
            this.groupBoxTimer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTimer
            // 
            this.btnTimer.BackColor = System.Drawing.Color.LightGray;
            this.btnTimer.Location = new System.Drawing.Point(15, 417);
            this.btnTimer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTimer.Name = "btnTimer";
            this.btnTimer.Size = new System.Drawing.Size(123, 42);
            this.btnTimer.TabIndex = 9;
            this.btnTimer.Text = "Таймер";
            this.btnTimer.UseVisualStyleBackColor = false;
            this.btnTimer.Click += new System.EventHandler(this.btnTimer_Click);
            // 
            // btnAlarm
            // 
            this.btnAlarm.BackColor = System.Drawing.Color.LightGray;
            this.btnAlarm.Location = new System.Drawing.Point(170, 417);
            this.btnAlarm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAlarm.Name = "btnAlarm";
            this.btnAlarm.Size = new System.Drawing.Size(123, 42);
            this.btnAlarm.TabIndex = 10;
            this.btnAlarm.Text = "Будильник";
            this.btnAlarm.UseVisualStyleBackColor = false;
            this.btnAlarm.Click += new System.EventHandler(this.btnAlarm_Click);
            // 
            // btnStopwatch
            // 
            this.btnStopwatch.BackColor = System.Drawing.Color.LightGray;
            this.btnStopwatch.Location = new System.Drawing.Point(324, 417);
            this.btnStopwatch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStopwatch.Name = "btnStopwatch";
            this.btnStopwatch.Size = new System.Drawing.Size(123, 42);
            this.btnStopwatch.TabIndex = 11;
            this.btnStopwatch.Text = "Секундомер";
            this.btnStopwatch.UseVisualStyleBackColor = false;
            this.btnStopwatch.Click += new System.EventHandler(this.btnStopwatch_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(63, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 90);
            this.label1.TabIndex = 7;
            this.label1.Text = "00:00:00";
            // 
            // Hours
            // 
            this.Hours.BackColor = System.Drawing.Color.LightGray;
            this.Hours.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Hours.ForeColor = System.Drawing.Color.DarkOrange;
            this.Hours.Location = new System.Drawing.Point(46, 140);
            this.Hours.Name = "Hours";
            this.Hours.Size = new System.Drawing.Size(93, 49);
            this.Hours.TabIndex = 9;
            this.Hours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Seconds
            // 
            this.Seconds.BackColor = System.Drawing.Color.LightGray;
            this.Seconds.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Seconds.ForeColor = System.Drawing.Color.DarkOrange;
            this.Seconds.Location = new System.Drawing.Point(290, 140);
            this.Seconds.Name = "Seconds";
            this.Seconds.Size = new System.Drawing.Size(93, 49);
            this.Seconds.TabIndex = 10;
            this.Seconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Minutes
            // 
            this.Minutes.BackColor = System.Drawing.Color.LightGray;
            this.Minutes.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Minutes.ForeColor = System.Drawing.Color.DarkOrange;
            this.Minutes.Location = new System.Drawing.Point(172, 140);
            this.Minutes.Name = "Minutes";
            this.Minutes.Size = new System.Drawing.Size(93, 49);
            this.Minutes.TabIndex = 11;
            this.Minutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SetAlarm
            // 
            this.SetAlarm.BackColor = System.Drawing.Color.LightGray;
            this.SetAlarm.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SetAlarm.Location = new System.Drawing.Point(80, 209);
            this.SetAlarm.Name = "SetAlarm";
            this.SetAlarm.Size = new System.Drawing.Size(124, 49);
            this.SetAlarm.TabIndex = 12;
            this.SetAlarm.Text = "Включить";
            this.SetAlarm.UseVisualStyleBackColor = false;
            this.SetAlarm.Click += new System.EventHandler(this.SetAlarm_Click);
            // 
            // AlarmOff
            // 
            this.AlarmOff.BackColor = System.Drawing.Color.LightGray;
            this.AlarmOff.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AlarmOff.Location = new System.Drawing.Point(238, 209);
            this.AlarmOff.Name = "AlarmOff";
            this.AlarmOff.Size = new System.Drawing.Size(124, 49);
            this.AlarmOff.TabIndex = 13;
            this.AlarmOff.Text = "Выключить";
            this.AlarmOff.UseVisualStyleBackColor = false;
            this.AlarmOff.Click += new System.EventHandler(this.AlarmOff_Click);
            // 
            // groupBoxAlarm
            // 
            this.groupBoxAlarm.Controls.Add(this.AlarmOff);
            this.groupBoxAlarm.Controls.Add(this.SetAlarm);
            this.groupBoxAlarm.Controls.Add(this.Minutes);
            this.groupBoxAlarm.Controls.Add(this.Seconds);
            this.groupBoxAlarm.Controls.Add(this.Hours);
            this.groupBoxAlarm.Controls.Add(this.label1);
            this.groupBoxAlarm.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAlarm.Name = "groupBoxAlarm";
            this.groupBoxAlarm.Size = new System.Drawing.Size(434, 388);
            this.groupBoxAlarm.TabIndex = 8;
            this.groupBoxAlarm.TabStop = false;
            // 
            // groupBoxStopwatch
            // 
            this.groupBoxStopwatch.Controls.Add(this.label5);
            this.groupBoxStopwatch.Controls.Add(this.label6);
            this.groupBoxStopwatch.Controls.Add(this.label3);
            this.groupBoxStopwatch.Controls.Add(this.label2);
            this.groupBoxStopwatch.Controls.Add(this.label4);
            this.groupBoxStopwatch.Controls.Add(this.btnStart);
            this.groupBoxStopwatch.Controls.Add(this.btnReset);
            this.groupBoxStopwatch.Controls.Add(this.btnStop);
            this.groupBoxStopwatch.Location = new System.Drawing.Point(12, 1);
            this.groupBoxStopwatch.Name = "groupBoxStopwatch";
            this.groupBoxStopwatch.Size = new System.Drawing.Size(434, 388);
            this.groupBoxStopwatch.TabIndex = 15;
            this.groupBoxStopwatch.TabStop = false;
            this.groupBoxStopwatch.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(58, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 90);
            this.label3.TabIndex = 9;
            this.label3.Text = "00";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(274, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 90);
            this.label2.TabIndex = 0;
            this.label2.Text = "00";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(164, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 90);
            this.label4.TabIndex = 8;
            this.label4.Text = "00";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.LightGray;
            this.btnStart.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.Location = new System.Drawing.Point(54, 155);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(124, 49);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Старт";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click_1);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.LightGray;
            this.btnReset.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReset.Location = new System.Drawing.Point(165, 225);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(124, 49);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Сброс";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click_1);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.LightGray;
            this.btnStop.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStop.Location = new System.Drawing.Point(279, 155);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(124, 49);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "Стоп";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click_1);
            // 
            // HoursTimer
            // 
            this.HoursTimer.BackColor = System.Drawing.Color.LightGray;
            this.HoursTimer.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HoursTimer.ForeColor = System.Drawing.Color.DarkOrange;
            this.HoursTimer.Location = new System.Drawing.Point(46, 140);
            this.HoursTimer.Name = "HoursTimer";
            this.HoursTimer.Size = new System.Drawing.Size(93, 49);
            this.HoursTimer.TabIndex = 9;
            this.HoursTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SecondsTimer
            // 
            this.SecondsTimer.BackColor = System.Drawing.Color.LightGray;
            this.SecondsTimer.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondsTimer.ForeColor = System.Drawing.Color.DarkOrange;
            this.SecondsTimer.Location = new System.Drawing.Point(290, 140);
            this.SecondsTimer.Name = "SecondsTimer";
            this.SecondsTimer.Size = new System.Drawing.Size(93, 49);
            this.SecondsTimer.TabIndex = 10;
            this.SecondsTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MinutesTimer
            // 
            this.MinutesTimer.BackColor = System.Drawing.Color.LightGray;
            this.MinutesTimer.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinutesTimer.ForeColor = System.Drawing.Color.DarkOrange;
            this.MinutesTimer.Location = new System.Drawing.Point(172, 140);
            this.MinutesTimer.Name = "MinutesTimer";
            this.MinutesTimer.Size = new System.Drawing.Size(93, 49);
            this.MinutesTimer.TabIndex = 11;
            this.MinutesTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSetTimer
            // 
            this.btnSetTimer.BackColor = System.Drawing.Color.LightGray;
            this.btnSetTimer.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSetTimer.Location = new System.Drawing.Point(80, 209);
            this.btnSetTimer.Name = "btnSetTimer";
            this.btnSetTimer.Size = new System.Drawing.Size(124, 49);
            this.btnSetTimer.TabIndex = 12;
            this.btnSetTimer.Text = "Включить";
            this.btnSetTimer.UseVisualStyleBackColor = false;
            // 
            // btnTurnOffTimer
            // 
            this.btnTurnOffTimer.BackColor = System.Drawing.Color.LightGray;
            this.btnTurnOffTimer.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTurnOffTimer.Location = new System.Drawing.Point(238, 209);
            this.btnTurnOffTimer.Name = "btnTurnOffTimer";
            this.btnTurnOffTimer.Size = new System.Drawing.Size(124, 49);
            this.btnTurnOffTimer.TabIndex = 13;
            this.btnTurnOffTimer.Text = "Выключить";
            this.btnTurnOffTimer.UseVisualStyleBackColor = false;
            // 
            // groupBoxTimer
            // 
            this.groupBoxTimer.Controls.Add(this.btnTurnOffTimer);
            this.groupBoxTimer.Controls.Add(this.btnSetTimer);
            this.groupBoxTimer.Controls.Add(this.MinutesTimer);
            this.groupBoxTimer.Controls.Add(this.SecondsTimer);
            this.groupBoxTimer.Controls.Add(this.HoursTimer);
            this.groupBoxTimer.Location = new System.Drawing.Point(12, -6);
            this.groupBoxTimer.Name = "groupBoxTimer";
            this.groupBoxTimer.Size = new System.Drawing.Size(434, 388);
            this.groupBoxTimer.TabIndex = 16;
            this.groupBoxTimer.TabStop = false;
            this.groupBoxTimer.Visible = false;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Silver;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.DarkOrange;
            this.label6.Location = new System.Drawing.Point(258, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 61);
            this.label6.TabIndex = 11;
            this.label6.Text = ":";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.DarkOrange;
            this.label5.Location = new System.Drawing.Point(148, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 61);
            this.label5.TabIndex = 12;
            this.label5.Text = ":";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(450, 472);
            this.Controls.Add(this.groupBoxTimer);
            this.Controls.Add(this.groupBoxStopwatch);
            this.Controls.Add(this.btnStopwatch);
            this.Controls.Add(this.btnAlarm);
            this.Controls.Add(this.btnTimer);
            this.Controls.Add(this.groupBoxAlarm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TimerForm";
            this.Text = "Часы";
            ((System.ComponentModel.ISupportInitialize)(this.Hours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Seconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minutes)).EndInit();
            this.groupBoxAlarm.ResumeLayout(false);
            this.groupBoxAlarm.PerformLayout();
            this.groupBoxStopwatch.ResumeLayout(false);
            this.groupBoxStopwatch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HoursTimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondsTimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinutesTimer)).EndInit();
            this.groupBoxTimer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnTimer;
        private System.Windows.Forms.Button btnAlarm;
        private System.Windows.Forms.Button btnStopwatch;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Hours;
        private System.Windows.Forms.NumericUpDown Seconds;
        private System.Windows.Forms.NumericUpDown Minutes;
        private System.Windows.Forms.Button SetAlarm;
        private System.Windows.Forms.Button AlarmOff;
        private System.Windows.Forms.GroupBox groupBoxAlarm;
        private System.Windows.Forms.GroupBox groupBoxStopwatch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown HoursTimer;
        private System.Windows.Forms.NumericUpDown SecondsTimer;
        private System.Windows.Forms.NumericUpDown MinutesTimer;
        private System.Windows.Forms.Button btnSetTimer;
        private System.Windows.Forms.Button btnTurnOffTimer;
        private System.Windows.Forms.GroupBox groupBoxTimer;
    }
}