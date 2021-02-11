using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AssistantSidorovich.Models;
using System.IO;

namespace AssistantSidorovich
{
    public partial class FastAppForm : Form
    {
        List<Bind> binds;
        string fullName;
        string name;
        public FastAppForm()
        {
            InitializeComponent();
            binds = new List<Bind>();
        }
        

        private void ChooseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All Files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                AddressBox.Text = Path.GetFileName( ofd.FileName);
                fullName = ofd.FileName;
                name = Path.GetFileName(ofd.FileName);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            AddressBox.Clear();
            
        }

        private void FastAppForm_Load(object sender, EventArgs e)
        {
            for (int i = 160; i <= 165; i++)
            {
                BindButton1CB.Items.Add((Keys)i);
            }
            BindButton1CB.Items.Add((Keys)91);
            BindButton1CB.Items.Add((Keys)92);
            
            for(int i = 8; i<=10;i++)
            {
                BindButton2CB.Items.Add((Keys)i);
                BindButton3CB.Items.Add((Keys)i);
            }
            BindButton2CB.Items.Add((Keys)13);
            BindButton3CB.Items.Add((Keys)13);
            BindButton2CB.Items.Add((Keys)19);
            BindButton3CB.Items.Add((Keys)19);
            BindButton2CB.Items.Add((Keys)20);
            BindButton3CB.Items.Add((Keys)20);            
            BindButton2CB.Items.Add((Keys)27);
            BindButton3CB.Items.Add((Keys)27);
            for (int i = 32; i <= 57; i++)
            {
                if (i != 41 && i != 42 && i != 43 && i != 47)
                {
                    BindButton2CB.Items.Add((Keys)i);
                    BindButton3CB.Items.Add((Keys)i);
                }
            }
            for (int i = 65; i <= 135; i++)
            {
                if (i != 91 && i != 92 && i != 93 && i != 94 && i != 95)
                {
                    BindButton2CB.Items.Add((Keys)i);
                    BindButton3CB.Items.Add((Keys)i);
                }
            }
            BindButton2CB.Items.Add((Keys)144);
            BindButton3CB.Items.Add((Keys)144);
            BindButton2CB.Items.Add((Keys)145);
            BindButton3CB.Items.Add((Keys)145);
            //8-10, 13, 19-20, 27, 32-40, 44-46, 48-57, 65-90, 96-135, 144, 145

            BindButton1CB.SelectedIndex = 0;
            BindButton2CB.SelectedIndex = 1;
            AutoLoadCB.Items.Add("Автозапуск при запуске Windows");
            AutoLoadCB.Items.Add("Автозапуск при запуске проиложения");
            AutoLoadCB.Items.Add("Без автозапуска");
            AutoLoadCB.SelectedIndex = 2;
            
        }

        private void TwoBindsRB_CheckedChanged(object sender, EventArgs e)
        {
            BindButton3CB.Enabled = false;
            BindButton3CB.SelectedIndex = -1;

        }

        private void ThreeBindsRB_CheckedChanged(object sender, EventArgs e)
        {
            BindButton3CB.Enabled = true;
            BindButton3CB.SelectedIndex = 0;
        }

        private void AutoLoadCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Bind b = new Bind()
            {
                FullName = fullName,
                Name = name,
                first = (Keys)BindButton1CB.SelectedItem,
                second = (Keys)BindButton2CB.SelectedItem,
                third = (Keys)BindButton3CB.SelectedItem
            };
           binds.Add(b);
           
           LoadList();
        }

        private void LoadList()
        {
            foreach (var a in binds)
                BindsList.Items.Add(a.ToString());
        }

        private void FastAppForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 'A')
            {
                MessageBox.Show("Fuck you!");
            }
        }
    }
}

