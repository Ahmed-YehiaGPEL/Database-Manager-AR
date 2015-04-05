using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace DB_Manager
{
    public partial class queryWeight : Form
    {
        public queryWeight()
        {
            InitializeComponent();
        }

        string queryString;
        DataSet ds;
        SQLiteCommand cmd;
        SQLiteConnection sCon;
        DataTable dt;
        SQLiteDataAdapter dA;
        bool isMulti = false;
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (isMulti == false)
            {
                queryString = "SELECT * from pltg WHERE \"الوزن\"" + cmbAge1.SelectedItem.ToString() + " " + numAge1.Value.ToString();
                System.Threading.Thread loadThread = new System.Threading.Thread(loadTable);
                loadThread.Start();
            }
            else
            {
                queryString = "SELECT * from pltg WHERE \"الوزن\"" + cmbAge1.SelectedItem.ToString() + " " + numAge1.Value.ToString() + " AND \"الوزن\" " + cmbAge2.SelectedItem + " " + numAge2.Value.ToString();
                System.Threading.Thread loadThread = new System.Threading.Thread(loadTable);
                loadThread.Start();
            }
        }
        private void loadTable()
        {
            string conS = "Data Source=" + Application.StartupPath + "\\app_Data\\" + "plDB.db;VERSION=3;";
            sCon = new SQLiteConnection(conS);
            sCon.Open();
            cmd = new SQLiteCommand(queryString, sCon);
            dA = new SQLiteDataAdapter(cmd);
            ds = new DataSet();
            dA.Fill(ds);
            dt = ds.Tables[0];
            setDataSource(dt);
        }
        internal delegate void SetDataSourceDelegate(DataTable dT);
        private void setDataSource(DataTable table)
        {
            // Invoke method if required:
            if (this.InvokeRequired)
            {
                this.Invoke(new SetDataSourceDelegate(setDataSource), table);
            }
            else
            {
                dataGridView1.DataSource = table;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Refresh();
            }
        }

        private void checkMulti_CheckedChanged(object sender, EventArgs e)
        {
            numAge2.Enabled = checkMulti.Checked;
            cmbAge2.Enabled = checkMulti.Checked;
            isMulti = checkMulti.Checked;

        }

        private void queryWeight_Load(object sender, EventArgs e)
        {
            cmbAge1.SelectedIndex = 0;
            cmbAge2.SelectedIndex = 0;
            dataGridView1.DefaultCellStyle.Font = Properties.Settings.Default.dataFont;
        }
    }
}
