using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YTapi;
using NYoutubeDL;
using System.IO;
using System.Media;
using System.Xml.Linq;

namespace AssistantSidorovich
{
    public partial class Form1 : Form
    {
        SoundPlayer sp = new SoundPlayer();
        private List<string> jokesPath = new List<string>();
        private List<string> anouncerVoicLinePath = new List<string>();
        public string path { get; set; }
        public string address { get; set; }

        YTapi.Search yt = new YTapi.Search();

        string SettingsPath;
        XDocument xd;
        XElement root;

        public bool announcer;

        
        public Form1()
        {
            InitializeComponent();

            notifyIcon1.Visible = false;
            this.notifyIcon1.MouseDoubleClick += new MouseEventHandler(notifyIcon1_MouseDoubleClick);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            SettingsPath = @"..\..\Data\settings.xml";
            xd = XDocument.Load(SettingsPath);
            root = xd.Element("root");
            if(root.Element("settings").Attribute("isOnAnnouncer").Value == "Checked")
            {
                announcer = true;
            }
            else
            {
                announcer = false;
            }
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {


            loadVoiceLines();
            if (announcer == true)
            {
                playVoiceLine(1);
            }

            axWindowsMediaPlayer1.Visible = false;
            for(int i = 0; i <4; i++)
            {
                jokesPath.Add($@"..\..\Jokes\st{i}.wav"); 
            }
        }
        public void loadVoiceLines()
        {
            SettingManagerForm smf = new SettingManagerForm();
            smf.announcerName = root.Element("settings").Attribute("name").Value;

            for (int i = 0; i < 4; i++)
            {
                anouncerVoicLinePath.Add($@"..\..\Announcers\{smf.announcerName}\st{i}.wav");
            }
           
        }
        public void playVoiceLine(int index)
        {
            sp.Stop();
            string mpath = anouncerVoicLinePath[index].ToString();
            sp.SoundLocation = mpath;
            sp.Play();
        }

        private void GoogleSearchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
               
                MessageBox.Show("Поисковая строка пустая!", "У меня проблема:(", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (announcer == true)
                {
                    playVoiceLine(3);
                }
                address = $"https://google.com/search?q={textBox1.Text}";
                System.Diagnostics.Process.Start(address);
            }
        }

        private void IconFinderSearchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
               
                MessageBox.Show("Поисковая строка пустая!", "У меня проблема:(", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (announcer == true)
                {
                    playVoiceLine(3);
                }
                address = $"https://www.iconfinder.com/search?q={textBox1.Text}&price=free";
                System.Diagnostics.Process.Start(address);
            }
        }

        private async void MusicSearchButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Поисковая строка пустая!");
            }
            else
            {
                try
                {
                    if (announcer == true)
                    {
                        playVoiceLine(3);
                    }
                    await Task.Run(async () => yt.Start(textBox1.Text));
                    if (String.IsNullOrWhiteSpace(yt.videoKey))
                    {
                        MessageBox.Show("Nothing found!");
                    }
                    else
                    {
                        axWindowsMediaPlayer1.Visible = false;
                        axWindowsMediaPlayer1.close();
                        textBox1.Text = yt.videoTitile;
                        path = yt.videoTitile + "-" + yt.videoKey + ".mp4";
                        {
                            path = path.Replace("&amp;", "&");
                            path = path.Replace("|", "_");
                            path = path.Replace("*", "_");
                            path = path.Replace("/", "_");
                            path = path.Replace(@"\", "_");
                            path = path.Replace(":", "_");
                            path = path.Replace("?", "_");
                            path = path.Replace("&quot;", "'");
                        } // Fixing problems with path, cause video can contains symbols like /, or ?, which not exits in file names in Windows OC
                        


                        var youtubeDl = new YoutubeDL();

                        youtubeDl.YoutubeDlPath = @"..\..\Videos\youtube-dl.exe";
                        youtubeDl.Options.PostProcessingOptions.ExtractAudio = true;
                        youtubeDl.Options.VideoFormatOptions.Format = NYoutubeDL.Helpers.Enums.VideoFormat.worst;
                        MessageBox.Show(path);
                        await youtubeDl.DownloadAsync($"https://www.youtube.com/watch?v={yt.videoKey}");
                        new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read, 4096, FileOptions.DeleteOnClose);
                        axWindowsMediaPlayer1.Visible = true;
                        axWindowsMediaPlayer1.URL = path;
                        axWindowsMediaPlayer1.Ctlcontrols.play();
                        

                    }
                }
                catch
                {
                    MessageBox.Show("Ошибки случаются");
                }
            }
        }

        private void ClocksButton_Click(object sender, EventArgs e)
        {
            TimerForm tf = new TimerForm();
            tf.Show();
        }

        private void DownloadVideoButton_Click(object sender, EventArgs e)
        {
            VideoDownload vd = new VideoDownload();
            vd.Show();
        }

        private void JokesButton_Click(object sender, EventArgs e)
        {
            try
            {
                Random r = new Random();
                sp.Stop();
                int index = r.Next(0, 4);
                string mpath = jokesPath[index].ToString();
                sp.SoundLocation = mpath;
                sp.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибки случаются: " + ex.Message);
            }
            
            
        }

        private void TasksManagerButton_Click(object sender, EventArgs e)
        {
            TaskManagerForm tmf = new TaskManagerForm();
            tmf.Show();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            SettingManagerForm smf = new SettingManagerForm();
            smf.Show();
        }

        private void FastAppButton_Click(object sender, EventArgs e)
        {
            FastAppForm faf = new FastAppForm();
            faf.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
                notifyIcon1.Visible = true;
            }

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            notifyIcon1.Visible = false;
            this.ShowInTaskbar = true;
            WindowState = FormWindowState.Normal;
        }
    }
}
