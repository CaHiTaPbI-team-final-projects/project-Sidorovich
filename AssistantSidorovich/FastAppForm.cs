using System;
using Microsoft.Win32;
using System.Reflection;
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
using WK.Libraries.HotkeyListenerNS;
using System.Windows.Input;
using System.Threading;
using System.Diagnostics;
using System.Xml;
using System.Xml.Linq;
namespace AssistantSidorovich
{
    public partial class FastAppForm : Form
    {
        List<Bind> binds;
        string fullName;
        string name;
        string path;
        XDocument xd;
        XElement root;
        HotkeyListener hkl = new HotkeyListener();

        public FastAppForm()
        {
            InitializeComponent();
            binds = new List<Bind>();
            path = @"..\..\Data\HotKeys.xml";
            xd = XDocument.Load(path);
            root = xd.Element("root");
        }


        private void ChooseButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog ofd = new System.Windows.Forms.OpenFileDialog();
            ofd.Filter = "All Files (*.*)|*.*";
            if (ofd.FileName != null && ofd.ShowDialog() == DialogResult.OK)
            {
                AddressBox.Text = Path.GetFileName(ofd.FileName);
                fullName = ofd.FileName;
                name = Path.GetFileName(ofd.FileName);
            }
            else
            {
                MessageBox.Show("Не выбран путь");
            }

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            AddressBox.Clear();

        }

        private void FastAppForm_Load(object sender, EventArgs e)
        {
            LoadBindList();
            AutoLoadFunc();
            hkl.HotkeyPressed += Hkl_HotkeyPressed;
            BindButton1CB.Items.Add(Keys.Control);
            BindButton2CB.Items.Add(Keys.Control);
            BindButton1CB.Items.Add(Keys.Alt);
            BindButton2CB.Items.Add(Keys.Alt);
            BindButton1CB.Items.Add(Keys.Shift);
            BindButton2CB.Items.Add(Keys.Shift);

            for (int i = 8; i <= 10; i++)
            {
                BindButton3CB.Items.Add((Keys)i);
            }
            BindButton3CB.Items.Add((Keys)13);
            BindButton3CB.Items.Add((Keys)19);
            BindButton3CB.Items.Add((Keys)20);
            BindButton3CB.Items.Add((Keys)27);
            for (int i = 32; i <= 57; i++)
            {
                if (i != 41 && i != 42 && i != 43 && i != 47)
                {
                    BindButton3CB.Items.Add((Keys)i);
                }
            }
            for (int i = 65; i <= 135; i++)
            {
                if (i != 91 && i != 92 && i != 93 && i != 94 && i != 95)
                {
                    BindButton3CB.Items.Add((Keys)i);
                }
            }
            BindButton3CB.Items.Add((Keys)144);
            BindButton3CB.Items.Add((Keys)145);
            //8-10, 13, 19-20, 27, 32-40, 44-46, 48-57, 65-90, 96-135, 144, 145

            BindButton1CB.SelectedIndex = 0;
            BindButton3CB.SelectedIndex = 29;
            AutoLoadCB.Items.Add("Автозапуск при запуске Windows");
            AutoLoadCB.Items.Add("Автозапуск при запуске проиложения");
            AutoLoadCB.Items.Add("Без автозапуска");
            AutoLoadCB.SelectedIndex = 2;
        }

        private void TwoBindsRB_CheckedChanged(object sender, EventArgs e)
        {
            BindButton2CB.Enabled = false;
            BindButton2CB.SelectedIndex = -1;

        }

        private void ThreeBindsRB_CheckedChanged(object sender, EventArgs e)
        {
            BindButton2CB.Enabled = true;
            BindButton2CB.SelectedIndex = 1;
        }

        private void AutoLoadCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            //if(string.IsNullOrWhiteSpace())
            int first = (int)(Keys)BindButton1CB.SelectedItem;
            int third = (int)(Keys)BindButton3CB.SelectedItem;
            if (BindButton2CB.Enabled == true)
            {
                int second = (int)(Keys)BindButton2CB.SelectedItem;
                if (BindButton1CB.SelectedIndex != BindButton2CB.SelectedIndex && !string.IsNullOrWhiteSpace(AddressBox.Text))
                {

                    Bind b = new Bind()
                    {
                        FullName = fullName,
                        Name = name,
                        AutoLoad = AutoLoadCB.SelectedIndex,
                        FirstBind = first,
                        SecondBind = second,
                        ThirdBind = third
                    };
                    binds.Add(b);
                    hkl.Add(new Hotkey((Keys)first | (Keys)second, (Keys)third));
                    LoadList();
                    xd.Element("root").Add(new XElement("HotKey", new XAttribute("FullName", b.FullName), new XAttribute("Name",
                    b.Name), new XAttribute("AutoLoad", b.AutoLoad), new XAttribute("first", b.FirstBind), new XAttribute("second", b.SecondBind), new XAttribute("third", b.ThirdBind)));
                    xd.Save(path);

                    AutoLoadFunc();

                    Form1 fm = new Form1();
                    fm.loadVoiceLines();
                    fm.playVoiceLine(2);

                }
                else
                {
                    MessageBox.Show("Вы добавили одинаковые горячие кнопки!");
                }
            }
            else
            {

                if (BindButton1CB.SelectedIndex != BindButton2CB.SelectedIndex && !string.IsNullOrWhiteSpace(AddressBox.Text))
                {
                    Bind b = new Bind()
                    {
                        FullName = fullName,
                        Name = name,
                        AutoLoad = AutoLoadCB.SelectedIndex,
                        FirstBind = first,
                        ThirdBind = third
                    };
                    binds.Add(b);
                    hkl.Add(new Hotkey((Keys)first, (Keys)third));
                    LoadList();
                    xd.Element("root").Add(new XElement("HotKey", new XAttribute("FullName", b.FullName), new XAttribute("Name",
                    b.Name), new XAttribute("AutoLoad", b.AutoLoad), new XAttribute("first", b.FirstBind), new XAttribute("second", 0), new XAttribute("third", b.ThirdBind)));
                    xd.Save(path);

                    Form1 fm = new Form1();
                    fm.loadVoiceLines();
                    fm.playVoiceLine(2);

                    AutoLoadFunc();
                }
                else
                {
                    MessageBox.Show("Вы добавили одинаковые горячие кнопки!");
                }
            }

        }

        private void LoadList()
        {
            BindsList.Items.Clear();
            foreach (var b in binds)
                BindsList.Items.Add(b.ToString());
        }

        private void LoadBindList()
        {
            var Binds = root.Elements("HotKey").ToList();
            Bind b;
            foreach (var bind in Binds)
            {
                b = new Bind()
                {
                    FullName = bind.Attribute("FullName").Value,
                    Name = bind.Attribute("Name").Value,
                    AutoLoad = Convert.ToInt32(bind.Attribute("AutoLoad").Value),
                    FirstBind = Convert.ToInt32(bind.Attribute("first").Value),
                    SecondBind = Convert.ToInt32(bind.Attribute("second").Value),
                    ThirdBind = Convert.ToInt32(bind.Attribute("third").Value),
                };
                binds.Add(b);
            }
            LoadList();
        }

        private void FastAppForm_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Hkl_HotkeyPressed(object sender, HotkeyEventArgs e)
        {
            foreach (var b in binds)
            {
                if (e.Hotkey == new Hotkey((Keys)b.FirstBind, (Keys)b.ThirdBind))
                {
                    Process.Start($"{b.FullName}");
                }
            }
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            if (BindsList.SelectedIndex != -1)
            {
                int index = BindsList.SelectedIndex;
                xd.Elements("root").Elements("HotKey").Where(t => t.Attribute("FullName").Value == binds[index].FullName).Remove();
                RegistryKey registry;
                registry = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\");
                if (registry.GetValue(binds[index].Name) != null)
                {
                    registry.DeleteValue(binds[index].Name);
                }
                binds.RemoveAt(index);
                xd.Save(path);
                LoadList();
                registry.Flush();
                registry.Close();
            }
            else
            {
                MessageBox.Show("Выберите горячую клавишу для удаления!");
            }
        }

        private void AutoLoadFunc()
        {
            RegistryKey registry;
            registry = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\");
            foreach (var b in binds)
            {
                
                try
                {
                    if (b.AutoLoad == 2 || b.AutoLoad == 1)
                    {
                        if(registry.GetValue(b.Name) != null)
                        {
                            registry.DeleteValue(b.Name);
                        }                        
                    }
                    else if (b.AutoLoad == 0)
                    {
                        registry.SetValue(b.Name, b.FullName);
                    }                    
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
                registry.Flush();
            }
            registry.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            AutoLoadFunc();
        }
    }
}

