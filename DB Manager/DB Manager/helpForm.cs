using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
    
namespace DB_Manager
{
    public partial class helpForm : Form
    {
        public helpForm()
        {
            InitializeComponent();
        }
        int _index = 0;
        string helpFilePath = Application.StartupPath + "\\app_data\\@help_101.xml";
        private void showHelp(int index)
        {
            _index = 0;
            //loading
            XDocument xmlDocument = XDocument.Load(helpFilePath);
            var helpData = from helpFiles in xmlDocument.Descendants("helpSet") // linq reader
                select new
                {
                    Text = helpFiles.Element("text").Value,
                };
            foreach (var person in helpData) //iteration
            {
                if (_index == index)
                {
                    textBox1.Text = person.Text.ToString();
                    break;
                }
                else

                { _index++; }

                
            }
       }
        private void helpForm_Load(object sender, EventArgs e)
        {

        }

  
        private void button2_Click(object sender, EventArgs e)
        {
            showHelp(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            showHelp(1);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            showHelp(2);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            showHelp(3);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            showHelp(4);

        }
    }
}
