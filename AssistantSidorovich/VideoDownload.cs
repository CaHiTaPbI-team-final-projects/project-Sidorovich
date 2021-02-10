using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NYoutubeDL;

namespace AssistantSidorovich
{
    public partial class VideoDownload : Form
    {
        YoutubeDL youtubeDl = new YoutubeDL();
        public VideoDownload()
        {
            InitializeComponent();
            
            youtubeDl.YoutubeDlPath = @"..\..\Videos\youtube-dl.exe";
            youtubeDl.Options.FilesystemOptions.Output = @"..\..\Videos\%(title)s.%(ext)s";
            youtubeDl.Options.FilesystemOptions.RestrictFilenames = true;
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(String.IsNullOrWhiteSpace(downloadTextBox.Text) != true && downloadTextBox.Text.IndexOf("youtube.com/watch?") != -1)
                {
                    MessageBox.Show("Wait, we are downloading");

                    youtubeDl.DownloadAsync(downloadTextBox.Text);
                    MessageBox.Show($"Downloaded succsesfully at 'Videos folder', near the programm");
                }
                else
                {
                    MessageBox.Show("Err, empty or incorrect url!");
                   
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void VideoDownload_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 2;
        }

        private void downloadTextBox_Click(object sender, EventArgs e)
        {
            downloadTextBox.Clear();
            downloadTextBox.Focus();
            
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBox1.SelectedIndex)
            {
                case 0:
                    youtubeDl.Options.VideoFormatOptions.Format = NYoutubeDL.Helpers.Enums.VideoFormat.best;
                    break;
                case 1:
                    youtubeDl.Options.VideoFormatOptions.Format = NYoutubeDL.Helpers.Enums.VideoFormat.worst;
                    break;
                case 2:
                    youtubeDl.Options.VideoFormatOptions.Format = NYoutubeDL.Helpers.Enums.VideoFormat.mp4;
                    break;
                case 3:
                    youtubeDl.Options.VideoFormatOptions.Format = NYoutubeDL.Helpers.Enums.VideoFormat.ogg;
                    break;
                case 4:
                    youtubeDl.Options.VideoFormatOptions.Format = NYoutubeDL.Helpers.Enums.VideoFormat.mkv;
                    break;
                case 5:
                    youtubeDl.Options.VideoFormatOptions.Format = NYoutubeDL.Helpers.Enums.VideoFormat.flv;
                    break;
                case 6:
                    youtubeDl.Options.VideoFormatOptions.Format = NYoutubeDL.Helpers.Enums.VideoFormat.webm;
                    break;
                default:
                    break;
            }
        }
    }
}
