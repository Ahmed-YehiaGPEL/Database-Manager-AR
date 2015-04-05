using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
namespace DB_Manager
{
    public partial class queryWeightAge : Form
    {
        public queryWeightAge()
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
                queryString = "SELECT * FROM pltg WHERE \"العمر\" " + cmbAge1.SelectedItem.ToString() + " " + numAge1.Value.ToString() + " AND \"الوزن\" " + cmbWe1.SelectedItem.ToString() + " " + numWe1.Value.ToString();
                System.Threading.Thread loadThread = new System.Threading.Thread(loadTable);
                loadThread.Start();
            }
            else
            {
                queryString = "SELECT * FROM pltg WHERE \"العمر\" " + cmbAge1.SelectedItem.ToString() + " " + numAge1.Value.ToString() + " AND \"العمر\" " + cmbAge2.SelectedItem + " " + numAge2.Value.ToString() + " AND \"الوزن\" " + cmbWe1.SelectedItem.ToString() + " " + numWe1.Value.ToString() + " AND \"الوزن\" " + cmbWe2.SelectedItem.ToString() + " " + numWe2.Value.ToString();
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
        private void queryAge_Load(object sender, EventArgs e)
        {
            /*cmbAge1.SelectedIndex = 0; //intiate with zero always
            cmbAge2.SelectedIndex = 0;
            cmbWe1.SelectedIndex = 0;
            cmbWe2.SelectedIndex = 0;*/
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            /*numAge2.Enabled = checkBox1.Checked;
            cmbAge2.Enabled = checkBox1.Checked;
            numWe2.Enabled = checkBox1.Checked;
            cmbWe2.Enabled = checkBox1.Checked;
            isMulti = checkBox1.Checked;*/
        }

        private void queryWeightAge_Load(object sender, EventArgs e)
        {
            cmbAge1.SelectedIndex = 0;
            cmbAge2.SelectedIndex = 0;
            cmbWe1.SelectedIndex = 0;
            cmbWe2.SelectedIndex = 0;

            dataGridView1.DefaultCellStyle.Font = Properties.Settings.Default.dataFont;
        }

        private void cmbAge1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(cmbAge1.SelectedItem.ToString());
        }

        private void cmbWe1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
