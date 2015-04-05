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
    public partial class queryBuilder : Form
    {
        private bool isShown = false;

        public queryBuilder()
        {
            InitializeComponent();
        }
        
        void sendClose(object sender, FormClosedEventArgs e)
        {
            isShown = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = DateTime.Now.ToString();
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (isShown == false)
            {
                queryName qName = new queryName();
                qName.MdiParent = this;
                qName.Show();
                qName.FormClosed += new FormClosedEventHandler(sendClose);
                isShown = true;
                qName.WindowState = FormWindowState.Maximized;
            }
            else
            {
                MessageBox.Show("من فضلك أغلق نافذة الإستعلام الحالية لكي تبدا بإستعلام جديد...", "تحذير");
            }
        }
        private void stripAge_Click(object sender, EventArgs e)
        {
            if (isShown == false)
            {
                queryAge qAge = new queryAge();
                qAge.MdiParent = this;
                qAge.Show();
                qAge.FormClosed += new FormClosedEventHandler(sendClose);
                qAge.WindowState = FormWindowState.Maximized;
                isShown = true;
            }
            else
            {
                MessageBox.Show("من فضلك أغلق نافذة الإستعلام الحالية لكي تبدا بإستعلام جديد...", "تحذير");
            }
        }
        private void stripWeight_Click(object sender, EventArgs e)
        {
            if (isShown == false)
            {
                queryWeight qWeight = new queryWeight();
                qWeight.MdiParent = this;
                qWeight.Show();
                qWeight.FormClosed += new FormClosedEventHandler(sendClose);
                qWeight.WindowState = FormWindowState.Maximized;
                isShown = true;
            }
            else
            {
                MessageBox.Show("من فضلك أغلق نافذة الإستعلام الحالية لكي تبدا بإستعلام جديد...", "تحذير");
            }
        }
        private void stripWA_Click(object sender, EventArgs e)
        {
            if (isShown == false)
            {
                queryWeightAge qWeightAge = new queryWeightAge();
                qWeightAge.MdiParent = this;
                qWeightAge.Show();
                qWeightAge.FormClosed += new FormClosedEventHandler(sendClose);
                qWeightAge.WindowState = FormWindowState.Maximized;
                isShown = true;
            }
            else
            {
                MessageBox.Show("من فضلك أغلق نافذة الإستعلام الحالية لكي تبدا بإستعلام جديد...", "تحذير");
 
            }
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            if (isShown == false)
            {
                queryID qID = new queryID();
                qID.MdiParent = this;
                qID.Show();
                qID.FormClosed += new FormClosedEventHandler(sendClose);
                qID.WindowState = FormWindowState.Maximized;
                isShown = true;
            }
            else
            {
                MessageBox.Show("من فضلك أغلق نافذة الإستعلام الحالية لكي تبدا بإستعلام جديد...", "تحذير");

            }
        }
    }
}
