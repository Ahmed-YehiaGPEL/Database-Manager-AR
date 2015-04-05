using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using ErrorHandlingLib;
namespace DB_Manager
{
    public partial class advancedSettings : Form
    {
        TextErrorHandling errorHandler = new TextErrorHandling();
        bool isFirst = true;
        #region ErrorHandling
        string errTxt1 = "لا يجب ان يكون هذا الحقل فارغاً";
        string errTxt2 = "يجب ان تكون بيانات هذا الحقل مثل الحقل بالأعلى";
        #endregion
        public advancedSettings()
        {
            InitializeComponent();
            if (Properties.Settings.Default.isFirstOpen == true)
            {
                RegistryKey rKey = Registry.CurrentUser.CreateSubKey(Properties.Settings.Default.registryKey);
                isFirst = true;
                performFirstOperationS();
            }
        }
        void performRegistrySet(string pwdKey)
        {
            RegistryKey rKey = Registry.CurrentUser.OpenSubKey(Properties.Settings.Default.registryKey,true);
            rKey.SetValue("PWD", pwdKey);
            rKey.Close();
        }
        void performFirstOperationS()
        {
            btnReset.Text = "ضبط تصريح الدخول";
            label1.Text = "*تصريح الدخول";
            label2.Text = "*أعد كتابة تصريح الدخول:";
            checkBox1.Checked = false;
            checkBox1.Enabled = false;
        }
        #region OLD CODE
        /*
        /// <summary>
        /// Represent the error cases needed while giving error
        ///<list type="Error Cases">
        ///1-Ahmed
        ///2-Mohamed</list>
        /// <value>ErrorCase 1 handles empty text box</value>
        /// <value>ErrorCase 2 Handles mismatch between two textBox Data</value>
        /// </summary>
        private enum ErrorCases
	    {
	        errorCase1,
            errorCase2
	    }
        void presentErrorMsg(Control controlToPresent,ErrorProvider eProvider,ErrorCases eCase)
        {
            Dictionary<int, string> errorHandlers = new Dictionary<int, string>(3);
            errorHandlers.Add(0, "");
           
        }
        void presentErrorMsg(Control controlToPresent, Control controlToCompareDataWith,ErrorProvider eProvider, ErrorCases eCase)
        { 
            
        }
         */
#endregion
        private void btnReset_Click(object sender, EventArgs e)
        {

            if (pwdTxt.Text!=null && rePwdText.Text != null)
            {
                if (pwdTxt.Text == rePwdText.Text)
                {
                    DialogResult dr = MessageBox.Show("هل أنت متاكد من تطبيق تلك الإعدادات ؟ ", "تنويه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                    if (dr == System.Windows.Forms.DialogResult.Yes)
                    {
                        performRegistrySet(pwdTxt.Text);
                    }
                    else
                        return;
                }
            }
        }
        private void timerTime_Tick(object sender, EventArgs e)
        {
            if (pwdTxt.Text != null && rePwdText.Text!=null)
            {
                if (pwdTxt.Text != rePwdText.Text)
                {
                    errorProvider1.SetError(pwdTxt, errTxt1);
                    errorProvider1.SetError(rePwdText, errTxt2);
                    btnReset.Enabled = false;
                }
                else
                {
                    errorProvider1.Clear();
                    btnReset.Enabled = true;
                }
            }
        }

        private void pwdTxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void advancedSettings_Load(object sender, EventArgs e)
        {
            

        }
    }
}
