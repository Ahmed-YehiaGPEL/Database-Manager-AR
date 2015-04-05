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
    public partial class queryName : Form
    {
        public queryName()
        {
            InitializeComponent();
        }
        string queryString;
        DataSet ds;
        SQLiteCommand cmd;
        SQLiteConnection sCon;
        DataTable dt;
        SQLiteDataAdapter dA;
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            queryString = "SELECT * from pltg WHERE \"الاسم\" ==\""+ maskedTextBox1.Text + "\"";
            System.Threading.Thread loadThread = new System.Threading.Thread(loadTable);
            loadThread.Start();
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

        private void queryName_Load(object sender, EventArgs e)
        {
            dataGridView1.DefaultCellStyle.Font = Properties.Settings.Default.dataFont;
        }
    }
}
