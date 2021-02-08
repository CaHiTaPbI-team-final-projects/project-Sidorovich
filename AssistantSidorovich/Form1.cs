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

namespace AssistantSidorovich
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string path { get; set; }
        public string address { get; set; }

        YTapi.Search yt = new YTapi.Search();
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void GoogleSearchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Searck line is empty!", "Troubles:(", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                address = $"https://google.com/search?q={textBox1.Text}";
                System.Diagnostics.Process.Start(address);
            }
        }

        private void IconFinderSearchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Searck line is empty!", "Troubles:(", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                address = $"https://www.iconfinder.com/search?q={textBox1.Text}&price=free";
                System.Diagnostics.Process.Start(address);
            }
        }

        private async void MusicSearchButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Search textBox is empty!");
            }
            else
            {
                try
                {
                    await Task.Run(async () => yt.Start(textBox1.Text));
                    if (String.IsNullOrWhiteSpace(yt.videoKey))
                    {
                        MessageBox.Show("Nothing found!");
                    }
                    else
                    {
                        textBox1.Text = yt.videoKey;
                        path = yt.videoTitile + "-" + yt.videoKey + ".mp4";
                        path = path.Replace("&amp;", "&");

                        var youtubeDl = new YoutubeDL();

                        youtubeDl.YoutubeDlPath = @"..\..\Videos\youtube-dl.exe";
                        youtubeDl.Options.PostProcessingOptions.ExtractAudio = true;
                        youtubeDl.Options.VideoFormatOptions.Format = NYoutubeDL.Helpers.Enums.VideoFormat.worst;
                        MessageBox.Show(path);
                        MessageBox.Show("Wait, we are dowbloading");
                        await youtubeDl.DownloadAsync($"https://www.youtube.com/watch?v={yt.videoKey}");
                    }
                }
                catch
                {
                    MessageBox.Show("Err");
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
    }
}
