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
        
        DateTime def = new DateTime(2000, 01, 1);
        public TaskManagerForm()
        {
            InitializeComponent();

            path = @"..\..\Data\tasks.xml";
            xd = XDocument.Load(path);
            root = xd.Element("root");

            dateTimeDeadline.Value = def;
            loadTaskList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textDesription.Text) && !string.IsNullOrWhiteSpace(textDesription.Text))
            {
                try
                {
                    var res = root.Elements("task").Where(t => t.Attribute("title").Value == textTitle.Text).FirstOrDefault();

                   // MessageBox.Show(res.Value);
                    if (res == null) 
                    {
                        Taskk newTask = new Taskk()
                        {
                            Title = textTitle.Text,
                            Description = textDesription.Text,
                            Deadline = dateTimeDeadline.Value.ToString()
                        };

                        xd.Element("root").Add(new XElement("task", new XAttribute("title", newTask.Title), new XAttribute("description",
                            newTask.Description), new XAttribute("deadline", newTask.Deadline)));

                        xd.Save(path);
                        loadTaskList();

                        Form1 fm = new Form1();
                        fm.loadVoiceLines();
                        fm.playVoiceLine(0);
                    }
                    else
                    {
                        MessageBox.Show("Такое задание уже существует");
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
            else
            {
                MessageBox.Show("Вы не ввели значения");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textDesription.Text) && !string.IsNullOrWhiteSpace(textDesription.Text))
            {
                if (listBoxTasks.SelectedIndex != -1)
                {
                    try
                    {
                        string oldTitle = (listBoxTasks.SelectedItem as Taskk).Title;

                        var res = root.Elements("task").Where(t => t.Attribute("title").Value == textTitle.Text).FirstOrDefault();

                        if(res == null)
                        {
                            if (!string.IsNullOrWhiteSpace(textTitle.Text))
                            {
                                if(textTitle.Text != "Заголовок")
                                    (listBoxTasks.SelectedItem as Taskk).Title = textTitle.Text;
                            }
                            if (!string.IsNullOrWhiteSpace(textDesription.Text))
                            {
                                if(textDesription.Text != "Описание")
                                    (listBoxTasks.SelectedItem as Taskk).Description = textDesription.Text;
                            }
                            if (dateTimeDeadline.Value != def)
                            {
                                (listBoxTasks.SelectedItem as Taskk).Deadline = dateTimeDeadline.Value.ToString();
                            }

                            xd.Element("root").Add(new XElement("task", new XAttribute("title", (listBoxTasks.SelectedItem as Taskk).Title), new XAttribute("description",
                                (listBoxTasks.SelectedItem as Taskk).Description), new XAttribute("deadline", (listBoxTasks.SelectedItem as Taskk).Deadline)));

                            xd.Elements("root").Elements("task").Where(t => t.Attribute("title").Value == oldTitle).Remove();
                            xd.Save(path);
                            loadTaskList();
                        }
                        else
                        {
                            MessageBox.Show("Такое задание уже существует");
                        }
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Не выбрано задачи для изменения");
                }
            }
            else
            {
                MessageBox.Show("Вы не ввели значения");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedIndex != -1)
            {
                try
                {
                    string oldTitle = (listBoxTasks.SelectedItem as Taskk).Title;
                    richTextBox1.Clear();
                    xd.Elements("root").Elements("task").Where(t => t.Attribute("title").Value == oldTitle).Remove();

                    xd.Save(path);

                    loadTaskList();

                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
            else
                MessageBox.Show("Не выбрано задачи для изменения");
        }

        private void textDesription_Click(object sender, EventArgs e)
        {
            textDesription.Clear();
        }

        private void textTitle_Click(object sender, EventArgs e)
        {
            textTitle.Clear();
        }

        private void loadTaskList()
        {
            listBoxTasks.Items.Clear();
            var tasks = root.Elements("task").ToList();

            if(tasks.Count!=0)
            {
                Taskk t = null;

                foreach (var task in tasks)
                {
                    t = new Taskk()
                    {
                        Title = task.Attribute("title").Value,
                        Description = task.Attribute("description").Value,
                        Deadline = task.Attribute("deadline").Value
                    };

                    listBoxTasks.Items.Add(t);
                }
                listBoxTasks.DisplayMember = t.ToString();
            }
        }

        private void listBoxTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxTasks.SelectedIndex != -1 && listBoxTasks.Items.Count !=0)
            {
                richTextBox1.Clear();
                richTextBox1.Text = (listBoxTasks.SelectedItem as Taskk).Description;
            }
        }
    }
}
