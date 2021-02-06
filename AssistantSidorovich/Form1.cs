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

namespace AssistantSidorovich
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        YTapi.Search yt = new YTapi.Search();
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                await Task.Run(async () => yt.Start("gachi вечериночка"));

                textBox1.Text = yt.videoKey;

            }
            catch
            {
                MessageBox.Show("Err");
            }
        }
    }
}
