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
        public string customPath { get; set; }
        public bool isCustomPathTriggered { get; set; }
        public VideoDownload()
        {
            InitializeComponent();
            
            youtubeDl.YoutubeDlPath = @"..\..\Videos\youtube-dl.exe";
            
            youtubeDl.Options.FilesystemOptions.RestrictFilenames = true;
            isCustomPathTriggered = false;
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            Form1 fm1 = new Form1();
            fm1.loadVoiceLines();
            fm1.playVoiceLine(2);
            try
            {
                if(String.IsNullOrWhiteSpace(downloadTextBox.Text) != true && downloadTextBox.Text.IndexOf("youtube.com/watch?") != -1)
                {
                    MessageBox.Show("Происходит загрузка");
                    if (isCustomPathTriggered == false)
                    {
                        youtubeDl.Options.FilesystemOptions.Output = @"..\..\Videos\%(title)s.%(ext)s";
                    }
                    else
                    {
                        youtubeDl.Options.FilesystemOptions.Output = customPath;
                    }
                    youtubeDl.DownloadAsync(downloadTextBox.Text);
                    if(isCustomPathTriggered == false)
                        MessageBox.Show($"Загружено в 'Videos folder', возле программы");
                    else
                        MessageBox.Show($"Успешно выгружено в: {customPath}");



                }
                else
                {
                    MessageBox.Show("Все ошибаются, но ты - особенно часто. Проверь ссылку");
                   
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

        private void selecetPathButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            if (fbd.SelectedPath != null && result == DialogResult.OK)
            {
                customPath = fbd.SelectedPath + @"\%(title)s.%(ext)s";
                isCustomPathTriggered = true;
                
            }
            else
            {
                MessageBox.Show("Путь не выбран");
            }
        }
    }
}
