using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Manager
{
    public partial class settingsForum : Form
    {
        public settingsForum()
        {
            InitializeComponent();
        }
        private void glassButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = fontDialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                Font font = fontDialog.Font;
                Properties.Settings.Default.dataFont = font;
                glassButton1.Font = font;
            }
           
        }

        private void fontDialog_Apply(object sender, EventArgs e)
        {

            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.autoLoadDB = checkAutoLoad.Checked;

        }

        private void checkHideBar_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.hideToolBar = checkHideBar.Checked;
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkAutoUpdate_CheckedChanged(object sender, EventArgs e)
        {

            Properties.Settings.Default.updateDataRecent = checkAutoUpdate.Checked;
        }

        private void seetingsForm_Load(object sender, EventArgs e)
        {
            fontDialog.Font = Properties.Settings.Default.dataFont;
            checkAutoUpdate.Checked = Properties.Settings.Default.updateDataRecent;
            checkHideBar.Checked = Properties.Settings.Default.hideToolBar;
            checkAutoLoad.Checked = Properties.Settings.Default.autoLoadDB;
            
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();

        }

        private void seetingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void checkAutoLoad_MouseHover(object sender, EventArgs e)
        {
            if (checkAutoLoad.Checked != true)
            {
                toolTip1.SetToolTip(checkAutoLoad, "هذا الإختيار قد يكون غير ملائماً لبعض الأجهزة ذات الإمكانيات الضعيفة");
            }
            else
            {
                toolTip1.RemoveAll();
            }
        }

        private void checkAutoUpdate_MouseHover(object sender, EventArgs e)
        {
            if (checkAutoUpdate.Checked != true)
            {
                toolTip1.SetToolTip(checkAutoUpdate, "هذا الإختيار قد يكون غير ملائماً لبعض الأجهزة ذات الإمكانيات الضعيفة");
            }
            else
            {
                toolTip1.RemoveAll();
            }
        }
    }
}
