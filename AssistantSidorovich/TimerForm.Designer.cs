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
            this.groupBoxAlarm = new System.Windows.Forms.GroupBox();
            this.AlarmOff = new System.Windows.Forms.Button();
            this.SetAlarm = new System.Windows.Forms.Button();
            this.Minutes = new System.Windows.Forms.NumericUpDown();
            this.Seconds = new System.Windows.Forms.NumericUpDown();
            this.Hours = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTimer = new System.Windows.Forms.Button();
            this.btnAlarm = new System.Windows.Forms.Button();
            this.btnStopwatch = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnStop = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxStopwatch = new System.Windows.Forms.GroupBox();
            this.groupBoxAlarm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Seconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hours)).BeginInit();
            this.groupBoxStopwatch.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAlarm
            // 
            this.groupBoxAlarm.Controls.Add(this.groupBoxStopwatch);
            this.groupBoxAlarm.Controls.Add(this.AlarmOff);
            this.groupBoxAlarm.Controls.Add(this.SetAlarm);
            this.groupBoxAlarm.Controls.Add(this.Minutes);
            this.groupBoxAlarm.Controls.Add(this.Seconds);
            this.groupBoxAlarm.Controls.Add(this.Hours);
            this.groupBoxAlarm.Controls.Add(this.label1);
            this.groupBoxAlarm.Location = new System.Drawing.Point(8, 8);
            this.groupBoxAlarm.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxAlarm.Name = "groupBoxAlarm";
            this.groupBoxAlarm.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxAlarm.Size = new System.Drawing.Size(289, 252);
            this.groupBoxAlarm.TabIndex = 8;
            this.groupBoxAlarm.TabStop = false;
            this.groupBoxAlarm.Visible = false;
            // 
            // AlarmOff
            // 
            this.AlarmOff.BackColor = System.Drawing.Color.Crimson;
            this.AlarmOff.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AlarmOff.Location = new System.Drawing.Point(159, 136);
            this.AlarmOff.Margin = new System.Windows.Forms.Padding(2);
            this.AlarmOff.Name = "AlarmOff";
            this.AlarmOff.Size = new System.Drawing.Size(83, 32);
            this.AlarmOff.TabIndex = 13;
            this.AlarmOff.Text = "Turn off";
            this.AlarmOff.UseVisualStyleBackColor = false;
            this.AlarmOff.Click += new System.EventHandler(this.AlarmOff_Click);
            // 
            // SetAlarm
            // 
            this.SetAlarm.BackColor = System.Drawing.Color.Crimson;
            this.SetAlarm.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SetAlarm.Location = new System.Drawing.Point(53, 136);
            this.SetAlarm.Margin = new System.Windows.Forms.Padding(2);
            this.SetAlarm.Name = "SetAlarm";
            this.SetAlarm.Size = new System.Drawing.Size(83, 32);
            this.SetAlarm.TabIndex = 12;
            this.SetAlarm.Text = "Turn on";
            this.SetAlarm.UseVisualStyleBackColor = false;
            this.SetAlarm.Click += new System.EventHandler(this.SetAlarm_Click);
            // 
            // Minutes
            // 
            this.Minutes.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Minutes.ForeColor = System.Drawing.Color.Crimson;
            this.Minutes.Location = new System.Drawing.Point(115, 91);
            this.Minutes.Margin = new System.Windows.Forms.Padding(2);
            this.Minutes.Name = "Minutes";
            this.Minutes.Size = new System.Drawing.Size(62, 35);
            this.Minutes.TabIndex = 11;
            this.Minutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Seconds
            // 
            this.Seconds.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Seconds.ForeColor = System.Drawing.Color.Crimson;
            this.Seconds.Location = new System.Drawing.Point(193, 91);
            this.Seconds.Margin = new System.Windows.Forms.Padding(2);
            this.Seconds.Name = "Seconds";
            this.Seconds.Size = new System.Drawing.Size(62, 35);
            this.Seconds.TabIndex = 10;
            this.Seconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Hours
            // 
            this.Hours.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Hours.ForeColor = System.Drawing.Color.Crimson;
            this.Hours.Location = new System.Drawing.Point(31, 91);
            this.Hours.Margin = new System.Windows.Forms.Padding(2);
            this.Hours.Name = "Hours";
            this.Hours.Size = new System.Drawing.Size(62, 35);
            this.Hours.TabIndex = 9;
            this.Hours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(42, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 61);
            this.label1.TabIndex = 7;
            this.label1.Text = "00:00:00";
            // 
            // btnTimer
            // 
            this.btnTimer.Location = new System.Drawing.Point(10, 271);
            this.btnTimer.Name = "btnTimer";
            this.btnTimer.Size = new System.Drawing.Size(82, 27);
            this.btnTimer.TabIndex = 9;
            this.btnTimer.Text = "Timer";
            this.btnTimer.UseVisualStyleBackColor = true;
            this.btnTimer.Click += new System.EventHandler(this.btnTimer_Click);
            // 
            // btnAlarm
            // 
            this.btnAlarm.Location = new System.Drawing.Point(113, 271);
            this.btnAlarm.Name = "btnAlarm";
            this.btnAlarm.Size = new System.Drawing.Size(82, 27);
            this.btnAlarm.TabIndex = 10;
            this.btnAlarm.Text = "Alram clock";
            this.btnAlarm.UseVisualStyleBackColor = true;
            this.btnAlarm.Click += new System.EventHandler(this.btnAlarm_Click);
            // 
            // btnStopwatch
            // 
            this.btnStopwatch.Location = new System.Drawing.Point(216, 271);
            this.btnStopwatch.Name = "btnStopwatch";
            this.btnStopwatch.Size = new System.Drawing.Size(82, 27);
            this.btnStopwatch.TabIndex = 11;
            this.btnStopwatch.Text = "Stopwatch";
            this.btnStopwatch.UseVisualStyleBackColor = true;
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
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Crimson;
            this.btnStop.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStop.Location = new System.Drawing.Point(186, 101);
            this.btnStop.Margin = new System.Windows.Forms.Padding(2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(83, 32);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Crimson;
            this.btnReset.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReset.Location = new System.Drawing.Point(110, 146);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(83, 32);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Crimson;
            this.btnStart.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.Location = new System.Drawing.Point(36, 101);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(83, 32);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(109, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 61);
            this.label4.TabIndex = 8;
            this.label4.Text = "00";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(178, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 61);
            this.label2.TabIndex = 0;
            this.label2.Text = "00";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(42, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 61);
            this.label3.TabIndex = 9;
            this.label3.Text = "00";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxStopwatch
            // 
            this.groupBoxStopwatch.Controls.Add(this.label3);
            this.groupBoxStopwatch.Controls.Add(this.label2);
            this.groupBoxStopwatch.Controls.Add(this.label4);
            this.groupBoxStopwatch.Controls.Add(this.btnStart);
            this.groupBoxStopwatch.Controls.Add(this.btnReset);
            this.groupBoxStopwatch.Controls.Add(this.btnStop);
            this.groupBoxStopwatch.Location = new System.Drawing.Point(0, 0);
            this.groupBoxStopwatch.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxStopwatch.Name = "groupBoxStopwatch";
            this.groupBoxStopwatch.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxStopwatch.Size = new System.Drawing.Size(289, 252);
            this.groupBoxStopwatch.TabIndex = 14;
            this.groupBoxStopwatch.TabStop = false;
            this.groupBoxStopwatch.Visible = false;
            // 
            // TimerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 307);
            this.Controls.Add(this.btnStopwatch);
            this.Controls.Add(this.btnAlarm);
            this.Controls.Add(this.btnTimer);
            this.Controls.Add(this.groupBoxAlarm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TimerForm";
            this.Text = "TimerForm";
            this.groupBoxAlarm.ResumeLayout(false);
            this.groupBoxAlarm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Seconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hours)).EndInit();
            this.groupBoxStopwatch.ResumeLayout(false);
            this.groupBoxStopwatch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAlarm;
        private System.Windows.Forms.Button AlarmOff;
        private System.Windows.Forms.Button SetAlarm;
        private System.Windows.Forms.NumericUpDown Minutes;
        private System.Windows.Forms.NumericUpDown Seconds;
        private System.Windows.Forms.NumericUpDown Hours;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTimer;
        private System.Windows.Forms.Button btnAlarm;
        private System.Windows.Forms.Button btnStopwatch;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.GroupBox groupBoxStopwatch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnStop;
    }
}