using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AssistantSidorovich
{
    public partial class SettingManagerForm : Form
    {
        string SettingsPath;
        XDocument xd;
        XElement root;
        public string announcerName { get; set; }
        public SettingManagerForm()
        {
            InitializeComponent();
            SettingsPath = @"..\..\Data\settings.xml";
            xd = XDocument.Load(SettingsPath);
            root = xd.Element("root");
            

           
        }

        private void checkState()
        {
            if (voiceCheckBox.CheckState == CheckState.Checked)
            {
                root.Element("settings").Attribute("isOnAnnouncer").Value = "Checked";
                commentatorDropDownList.Enabled = true;
                xd.Save(SettingsPath);
            }
            else
            {
                root.Element("settings").Attribute("isOnAnnouncer").Value = "Unchecked";
                commentatorDropDownList.Enabled = false;
                xd.Save(SettingsPath);
            }
        }

        private void voiceCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            
            checkState();
        }

        

        private void SettingManagerForm_Load(object sender, EventArgs e)
        {
            commentatorDropDownList.SelectedIndex = 0;
            if (root.Element("settings").Attribute("isOnAnnouncer").Value == "Checked")
            {
                voiceCheckBox.Checked = true;
            }
            else
            {
                voiceCheckBox.Checked = false;
            }
            checkState();
        }
    }
}
