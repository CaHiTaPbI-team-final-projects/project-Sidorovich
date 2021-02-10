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

namespace AssistantSidorovich
{
    public partial class TaskManagerForm : Form
    {
        public TaskManagerForm()
        {
            InitializeComponent();
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
