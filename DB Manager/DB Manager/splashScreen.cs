using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace DB_Manager
{
    public partial class splashScreen : Form
    {
        public splashScreen()
        {
            InitializeComponent();
        }
        
        double i;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
             
           
        }

        private void splashScreen_Load(object sender, EventArgs e)
        {
          
        
         
        }
        private void loadForm()
        {

                }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
        
           
            
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
               }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
          //  Thread.Sleep(3000);
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
         //   loadForm();
        }
        /*
         Need to maeke the splash screen
         * Decrease Opacity as time goes
         * If Opacity is zero
         *  OPen the mainForum and close this forum
         *  
         * Possible Idea:
         *      Intiate this forum from main forum thread without showing main forum but show it after this thread ends
         */
        private void timer1_Tick(object sender, EventArgs e)
        {
        
        }

        private void splashScreen_Shown(object sender, EventArgs e)
        {
            //timer1.Interval = 3000;
            //timer1.Start();
            //timer1.Tick +=;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splashScreen_Load_1(object sender, EventArgs e)
        {
            this.Opacity = 0;
            timerFadeIn.Enabled = true;//Enable the timerFadeIn to start Fade In Effect
            timerFadeOut.Enabled = false;
            timerFadeIn.Tick += timerFadeIn_Tick;
            timerFadeOut.Tick += timerFadeOut_Tick;
        }

        private void timerFadeOut_Tick(object sender, EventArgs e)
        {//Fade out effect
            i -= 0.05;
            if (i <= 0.01)
            {//if form is invisible, we execute the Fade In Effect again
                this.Opacity = 0.0;
                //timerFadeIn.Enabled = true;//start the Fade In Effect
                timerFadeOut.Enabled = false;//stop the Fade Out Effect
                mainForm frmi = new mainForm();
                frmi.Show();
                this.Hide();
                return;
            }
            this.Opacity = i;
        }
        private void timerFadeIn_Tick(object sender, EventArgs e)
        {//Fade in effect
            
            i += 0.15;
            if (i >= 1)
            {//if form is fully visible, we execute the Fade Out Effect
                this.Opacity = 1;
                timerFadeIn.Enabled = false;//stop the Fade In Effect
                timerFadeOut.Enabled = true;//start the Fade Out Effect
                return;
            }
            this.Opacity = i;
        }
        
    }
}
