using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssistantSidorovich
{
    public partial class TimerForm : Form
    {
        // For alarm cock
        int H;
        int M;
        int S;
        int h;
        int m;
        int s;
        DateTime current;

        // For timer
        int Ht;
        int Mt;
        int St;

        int time = -1;

        //For stopwatch
        int mm;
        int ss;
        int ms;

        public TimerForm()
        {
            InitializeComponent();
        }

        //Main controls 
        private void btnAlarm_Click(object sender, EventArgs e)
        {
            groupBoxStopwatch.Visible = false;
            groupBoxTimer.Visible = false;
            groupBoxAlarm.Visible = true;
            DisplayTime();
        }

        private void btnTimer_Click(object sender, EventArgs e)
        {
            groupBoxStopwatch.Visible = false;
            groupBoxAlarm.Visible = false;
            groupBoxTimer.Visible = true;
        }

        private void btnStopwatch_Click(object sender, EventArgs e)
        {
            //timer1.Enabled = false;

            groupBoxAlarm.Visible = false;
            groupBoxTimer.Visible = false;
            groupBoxStopwatch.Visible = true;
        }


        //Alarm cock
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (groupBoxAlarm.Visible == true)
            {
                timer1.Interval = 1000;
                DisplayTime();
                current = DateTime.Now;
                h = current.Hour;
                m = current.Minute;

                s = current.Second;
                if (h == H && m == M && s == S)
                {
                    notifyIcon1.Icon = SystemIcons.Exclamation;
                    notifyIcon1.BalloonTipTitle = "Внимание";
                    notifyIcon1.BalloonTipText = "Сработал будильник";
                    notifyIcon1.BalloonTipIcon = ToolTipIcon.Warning;

                    notifyIcon1.Visible = true;
                    notifyIcon1.ShowBalloonTip(5000);
                }
            }

            else if(groupBoxStopwatch.Visible ==true)
            {
                DateTime timmer = new DateTime(0, 0);
                timer1.Interval = 1;
                ms += 1;
                timmer = timmer.AddMilliseconds(ms);
                label2.Text = timmer.Millisecond.ToString();

                if (timmer.Millisecond == 60)
                {
                    ms = 0;
                    ss += 1;

                    timmer = timmer.AddSeconds(ss);
                    label4.Text = timmer.Second.ToString();
                    if (timmer.Second == 60)
                    {
                        mm += 1;
                        ss = 0;
                        timmer = timmer.AddMinutes(mm);
                        label3.Text = timmer.Minute.ToString();
                    }
                }
            }
            else if (groupBoxTimer.Visible == true)
            {
                if(time ==0)
                {
                    notifyIcon1.Icon = SystemIcons.Exclamation;
                    notifyIcon1.BalloonTipTitle = "Внимание";
                    notifyIcon1.BalloonTipText = "Сработал таймер";
                    notifyIcon1.BalloonTipIcon = ToolTipIcon.Warning;

                    notifyIcon1.Visible = true;
                    notifyIcon1.ShowBalloonTip(5000);

                    time = -1;
                }
                else
                {
                    time = time - 1;
                }
            }
        }

        private void SetAlarm_Click(object sender, EventArgs e)
        {
            H = (int)Hours.Value;
            M = (int)Minutes.Value;
            S = (int)Seconds.Value;
            SetAlarm.Enabled = false;
            AlarmOff.Enabled = true;
            timer1.Enabled = true;
        }

        private void AlarmOff_Click(object sender, EventArgs e)
        {
            Hours.Value = 0;
            Minutes.Value = 0;
            Seconds.Value = 0;
            SetAlarm.Enabled = true;
            AlarmOff.Enabled = false;
        }

        private void DisplayTime()
        {
            label1.Text = DateTime.Now.ToLongTimeString();
        }


        //Stopwatch
        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

            btnStart.Enabled = false;
            btnStop.Enabled = true;
            btnReset.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            btnStart.Enabled = true;
            btnStop.Enabled = false;
            btnReset.Enabled = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            label4.Text = "00";
            label3.Text = "00";
            label2.Text = "00";
            ms = 0;
            ss = 0;
            mm = 0;

            btnReset.Enabled = false;
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }



        private void btnSetTimer_Click(object sender, EventArgs e)
        {
            Ht = (int)HoursTimer.Value;
            Mt = (int)MinutesTimer.Value;
            St = (int)SecondsTimer.Value;
            btnSetTimer.Enabled = false;
            btnTurnOffTimer.Enabled = true;
            timer1.Enabled = true;

            time = (Ht * 3600) + (Mt * 60) + St;
        }

        private void btnTurnOffTimer_Click(object sender, EventArgs e)
        {
            btnSetTimer.Enabled = true;
            btnTurnOffTimer.Enabled = false;
            timer1.Enabled = false;
            time = -1;


            HoursTimer.Value = 0;
            MinutesTimer.Value = 0;
            SecondsTimer.Value = 0;
        }

        private void btnStart_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = true;

            btnStart.Enabled = false;
            btnStop.Enabled = true;
            btnReset.Enabled = true;
        }

        private void btnStop_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            btnStart.Enabled = true;
            btnStop.Enabled = false;
            btnReset.Enabled = true;
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            label4.Text = "00";
            label3.Text = "00";
            label2.Text = "00";
            ms = 0;
            ss = 0;
            mm = 0;

            btnReset.Enabled = false;
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }
    }
}
