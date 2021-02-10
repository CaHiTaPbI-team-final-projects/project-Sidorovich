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
using System.Xml;
using System.Xml.Linq;

namespace AssistantSidorovich
{
    public partial class TaskManagerForm : Form
    {
        string path;
        XDocument xd;
        XElement root;
        
        public TaskManagerForm()
        {
            InitializeComponent();

            path = @"..\..\Data\tasks.xml";
            xd = XDocument.Load(path);
            root = xd.Element("root");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Taskk newTask = new Taskk()
                {
                    Title = textTitle.Text,
                    Description = textDesription.Text,
                    Deadline = dateTimeDeadline.Value
                };

                listBoxTasks.Items.Add(newTask);
                listBoxTasks.DisplayMember = newTask.ToString() ;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

            // Edit here
            xd.Element("root").Add(new XElement("employee", new XAttribute("name", emp.Name), new XAttribute("specialization", emp.Specialization), new XAttribute("weapon", emp.Weapon), new XAttribute("nickname", emp.Nickname),
                new XAttribute("birth", emp.Birth), new XAttribute("dep_name", emp.Dep_name)));
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnFinish_Click(object sender, EventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

            private void textDesription_Click(object sender, EventArgs e)
        {
            textDesription.Clear();
        }

        private void textTitle_Click(object sender, EventArgs e)
        {
            textTitle.Clear();
        }
    }
}
