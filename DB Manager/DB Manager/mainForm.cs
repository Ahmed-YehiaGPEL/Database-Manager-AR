using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Threading;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Win32;

namespace DB_Manager
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        #region Printing Declarations
        StringFormat strFormat; //Used to format the grid rows.
        ArrayList arrColumnLefts = new ArrayList();//Used to save left coordinates of columns
        ArrayList arrColumnWidths = new ArrayList();//Used to save column widths
        int iCellHeight = 0; //Used to get/set the datagridview cell height
        int iTotalWidth = 0; //
        int iRow = 0;//Used as counter
        bool bFirstPage = false; //Used to check whether we are printing first page
        bool bNewPage = false;// Used to check whether we are printing a new page
        int iHeaderHeight = 0; //Used for the header height
        #endregion
        #region Work Area Declarataions
        static SQLiteDataAdapter dA;
        static DataSet ds;
        static SQLiteCommand cmd;
        static SQLiteConnection sCon;
        private DataTable dt;
        //Data load
        public static bool updateRecently;
        public static bool loadOnStart;
        public static bool isNew;
        public bool isLoaded = false;
        private static bool selected = false;
        public volatile bool isReady = false;
        public Thread loadThread;//Thread of loading
        private string selectCount = "SELECT COUNT(*) FROM \"pltg\"";
        private SQLiteCommand countCm;
        private int rowsCount;
        private bool loadThreadLoadedOnce = false;
        int[] iColWidths = { }; // columns widths for post loading of dtGridView
        #endregion
        #region Exporting Declrations
        private string excelFilePath = "";  
        #endregion
        #region Registry 
        
        
        #endregion
        private void applyClosing()
        {
        
            try
            {
                askSave();
                sCon.Close();
                
            }
            catch
            {

                return;
            }
         
            
        }
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            //Java 4K , December Contest... Make a game in 4K
            DialogResult dr = MessageBox.Show("هل انت متأكد من أنك تريد الاستمرار؟ \nسيقوم هذا الإجراء بحذف قاعدة البيانات كاملة...", "تحذير", MessageBoxButtons.YesNo,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button2,MessageBoxOptions.RtlReading); // need complement
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                string deletCommand = "DELETE FROM pltg";
                SQLiteCommand cm = new SQLiteCommand(deletCommand, sCon);
                cm.ExecuteNonQuery();
                loadTable();    
            }
            //dataGridView1.RefreshEdit();
            //dataGridView1.Refresh();
        }
        private void askSave()
        {
            if (isNew == true)
            {
                DialogResult dg = MessageBox.Show("حفظ التغييرات؟", "حفظ..؟", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);

                if (dg == System.Windows.Forms.DialogResult.Yes)
                {
                    saveData();
                }
            }
            try   { sCon.Close(); }
            catch { return; }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        #region Data Loading / Handling
        private void loadTable()
        {

            string conS = "Data Source=" + Application.StartupPath + "\\app_Data\\" + "plDB.db;VERSION=3;";
            sCon = new SQLiteConnection(conS);
            sCon.Open();
            string Sql = "SELECT * FROM 'pltg' ORDER BY 'الرقم التعريفي' DESC";
            cmd = new SQLiteCommand(Sql, sCon);
            dA = new SQLiteDataAdapter(cmd);
            ds = new DataSet();
            dA.Fill(ds);   
            dt = ds.Tables[0];
            setDataSource(dt);
            loadThreadLoadedOnce = true;


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
                dtGridView.DataSource = table;
                dtGridView.Columns[0].Visible = false;
                dtGridView.Refresh();
                ApplySettings();
                toolStripProgressBar1.Visible = false;

            }
        }
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            isNew = true;
        }
        /// <summary>
        /// Handles \ forum Data Loading of the Button
        /// </summary>
        private void loadData(object sender,EventArgs e)
        {
            //enable progress bar to load
            toolStripProgressBar1.Visible = true; // load the thread
            loadThread = new Thread(loadTable);
            loadThread.Start();
            //Apply Settings
            ApplySettings();
            timerWidthLoad.Enabled = true;
            #region Enabling Controls & Settings
            //Menu1
            _drDataSave.Enabled = true;
            _drDataSearch.Enabled = true;
            _drDataPrint.Enabled = true;
            _drPrintPrv.Enabled = true;
            //Menu2
            _drDataSelect.Enabled = true;
            _drDataClear.Enabled = true;
            //SubMenu1
            toolBar.Enabled = true;
            exportToExcel.Enabled = true;
            #endregion
        

        }
        private void loadDBData()
        {
            DateTime dt1 = DateTime.Now;
            string conS = "Data Source=" + Application.StartupPath + "\\app_Data\\" + "plDB.db;VERSION=3;";
            sCon = new SQLiteConnection(conS);
            sCon.Open();
            string Sql = "SELECT * FROM 'pltg' ORDER BY 'الرقم التعريفي' DESC";
            cmd = new SQLiteCommand(Sql, sCon);
            dA = new SQLiteDataAdapter(cmd);
            ds = new DataSet();
            dA.Fill(ds);
            DataTable dt = ds.Tables[0];
            dtGridView.DataSource = dt;
            dtGridView.Columns[0].Visible = false;
            dtGridView.Refresh();
            ApplySettings();
            DateTime dt2 = DateTime.Now;
            Thread.Sleep(dt2 - dt1);
            isReady = true;

        }
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            saveData();
        }
        #endregion
        #region Work Area Handling
        private void saveData()
        {
        startOver:
            isNew = false;
            SQLiteCommandBuilder cm = new SQLiteCommandBuilder(dA);
            dA.DeleteCommand = cm.GetDeleteCommand();
            dA.UpdateCommand = cm.GetUpdateCommand();
            dA.DeleteCommand = cm.GetDeleteCommand();
            try
            {
                dA.Update(ds.Tables[0]);
            }
            catch (DBConcurrencyException exc)
            {
                MessageBox.Show(exc.ToString());
                DialogResult dr = MessageBox.Show("محاولة من جديد ؟ ", "??", MessageBoxButtons.YesNo);
                if (dr == System.Windows.Forms.DialogResult.Yes)
                {
                    goto startOver;
                }
            }
        }
        private void progressTimer_Tick(object sender, EventArgs e)
        {
            if (this.dt != null)
            {
                toolStripProgressBar1.Value = dt.Rows.Count;
            }
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutBox abt = new aboutBox();
            showForm(abt, this, setClose);

        }
        private void showHelp(object sender, EventArgs e)
        {
            helpForm help = new helpForm();
            showForm(help, this, setClose);

        }
        private void showForm(Form frm, Form owner, FormClosedEventHandler closeHandle)
        {
            frm.Owner = owner;
            frm.Show();
            frm.Activate();
            owner.Enabled = false;
            frm.FormClosed += new FormClosedEventHandler(closeHandle);
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void timeTimer_Tick(object sender, EventArgs e)
        {
            toolStripLblTime.Text = DateTime.Now.ToString();
            try
            {
                if (updateRecently == true && loadThread.IsAlive == false && loadThreadLoadedOnce == true)
                {
                    saveData();
                }
            }
            catch { return; }
      

            
            
        }
        private void btnSearchClick(object sender, EventArgs e)
        {
            showForm(new queryBuilder(), this, setClose);
        }
        private void dataGridView1_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            Properties.Settings.Default.colWidthString = "";

            for (int i = 0; i < dtGridView.Columns.Count; i++)
            {
                if (i != 0)
                {
                    Properties.Settings.Default.colWidthString += ',' + dtGridView.Columns[i].Width.ToString();
                }
                else
                {
                    Properties.Settings.Default.colWidthString += dtGridView.Columns[i].Width.ToString();
                }

            }
            Properties.Settings.Default.Save();
            
        }
        private void customizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settingsForum setForm = new settingsForum();
            showForm(setForm, this, setClose);
        }
        public void setClose(object sender, FormClosedEventArgs e)
        {
            makeActive();
            ApplySettings();
        }
        public void makeActive()
        {
            this.Enabled = true;

        }
        public void mainForm_Load(object sender, EventArgs e)
        {
            ApplySettings();
            if (loadOnStart == true)
            {
                loadThread = new Thread(loadTable);
                loadThread.Start();
               timerWidthLoad.Enabled = true;
                #region Enabling Controls & Settings
                //Menu1
                _drDataSave.Enabled = true;
                _drDataSearch.Enabled = true;
                _drDataPrint.Enabled = true;
                _drPrintPrv.Enabled = true;
                //Menu2
                _drDataSelect.Enabled = true;
                _drDataClear.Enabled = true;
                //SubMenu1
                toolBar.Enabled = true;
                exportToExcel.Enabled = true;
                #endregion

            }
            
           

        }
        /// <summary>
        /// Apply the settings stored wihtin
        /// </summary>
        private void ApplySettings()
        {
            
            loadOnStart = Properties.Settings.Default.autoLoadDB;
            updateRecently = Properties.Settings.Default.updateDataRecent;

            DataGridViewCellStyle cStyle = new DataGridViewCellStyle();
            cStyle.Font = Properties.Settings.Default.dataFont;
            foreach (DataGridViewRow row in dtGridView.Rows)
            {

                foreach (DataGridViewCell cell in row.Cells)
                    cell.Style.ApplyStyle(cStyle);
            }
            if (Properties.Settings.Default.hideToolBar == true)
            {
                toolBar.Visible = false;
            }
            else
            {
                toolBar.Visible = true;
            }
         }
        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selected == false)
            {
                dtGridView.SelectAll();
                selected = true;
            }
            else
            {
                dtGridView.ClearSelection();
                selected = false;
            }

        }

        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            GC.Collect();
            applyClosing();
            Application.Exit();

        }
        #endregion
        #region Print Handling
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                //Set the left margin
                int iLeftMargin = e.MarginBounds.Left;
                //Set the top margin
                int iTopMargin = e.MarginBounds.Top;
                //Whether more pages have to print or not
                bool bMorePagesToPrint = false;
                int iTmpWidth = 0;

                //For the first page to print set the cell width and header height
                if (bFirstPage)
                {
                    foreach (DataGridViewColumn GridCol in dtGridView.Columns)
                    {
                        iTmpWidth = (int)(Math.Floor((double)((double)GridCol.Width /
                                       (double)iTotalWidth * (double)iTotalWidth *
                                       ((double)e.MarginBounds.Width / (double)iTotalWidth))));

                        iHeaderHeight = (int)(e.Graphics.MeasureString(GridCol.HeaderText,
                                    GridCol.InheritedStyle.Font, iTmpWidth).Height) + 11;

                        // Save width and height of headres
                        arrColumnLefts.Add(iLeftMargin);
                       
                        arrColumnWidths.Add(iTmpWidth);
                        iLeftMargin += iTmpWidth;
                    }
  
                    arrColumnLefts.Reverse();//reverse For RTL
                    
                    arrColumnWidths.Reverse();
                }
                

                //Loop till all the grid rows not get printed
                while (iRow <= dtGridView.Rows.Count - 1)
                {

                    DataGridViewRow GridRow = dtGridView.Rows[iRow];
                    //Set the cell height
                    iCellHeight = GridRow.Height + 5;
                    int iCount = 0;
                    //Check whether the current page settings allo more rows to print
                    if (iTopMargin + iCellHeight >= e.MarginBounds.Height + e.MarginBounds.Top)
                    {
                        bNewPage = true;
                        bFirstPage = false;
                        bMorePagesToPrint = true;
                        break;
                    }
                    else
                    {
                        if (bNewPage)
                        {
                            String strDate = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();
                            //Draw Date
                            e.Graphics.DrawString(strDate, new Font(dtGridView.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top -
                                    e.Graphics.MeasureString("محصلة بيانات اللاعبين المستعلم عنهم", new Font(new Font(dtGridView.Font,
                                    FontStyle.Bold), FontStyle.Underline), e.MarginBounds.Width).Height - 13);

                            //Draw Header
                            e.Graphics.DrawString("محصلة بيانات اللاعبين المستعلم عنهم", new Font(dtGridView.Font, FontStyle.Bold),
                                    /*here changed e,margin.left to .right*/Brushes.Black, e.MarginBounds.Right - 100, e.MarginBounds.Top -
                                    e.Graphics.MeasureString("محصلة بيانات اللاعبين المستعلم عنهم", new Font(dtGridView.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Height - 13);


                            
                            //Draw Columns                 
                            iTopMargin = e.MarginBounds.Top;
                            foreach (DataGridViewColumn GridCol in dtGridView.Columns)
                            {
                                if (GridCol.Index == 0) // exclude first column
                                    continue;
                                e.Graphics.FillRectangle(new SolidBrush(Color.LightGray),
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawRectangle(Pens.Black,
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawString(GridCol.HeaderText, GridCol.InheritedStyle.Font,
                                    new SolidBrush(GridCol.InheritedStyle.ForeColor),
                                    new RectangleF((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight), strFormat);
                                iCount++;
                            }
                            bNewPage = false;
                            iTopMargin += iHeaderHeight;
                        }
                        iCount = 0;
                        //Draw Columns Contents                
                        foreach (DataGridViewCell Cel in GridRow.Cells)
                        {
                            if (Cel.OwningColumn.Index == 0) // exclude first row 
                                continue;
                            if (Cel.Value != null)
                            {
                                e.Graphics.DrawString(Cel.Value.ToString(), Cel.InheritedStyle.Font,
                                            new SolidBrush(Cel.InheritedStyle.ForeColor),
                                            new RectangleF((int)arrColumnLefts[iCount], (float)iTopMargin,
                                            (int)arrColumnWidths[iCount], (float)iCellHeight), strFormat);
                            }
                            //Drawing Cells Borders 
                            e.Graphics.DrawRectangle(Pens.Black, new Rectangle((int)arrColumnLefts[iCount],
                                    iTopMargin, (int)arrColumnWidths[iCount], iCellHeight));

                            iCount++;
                        }
                    }
                    iRow++;
                    iTopMargin += iCellHeight;
                }

                //If more lines exist, print another page.
                if (bMorePagesToPrint)
                    e.HasMorePages = true;
                else
                    e.HasMorePages = false;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                strFormat = new StringFormat();
                strFormat.Alignment = StringAlignment.Center;
                strFormat.LineAlignment = StringAlignment.Center;
                strFormat.Trimming = StringTrimming.EllipsisCharacter;

                arrColumnLefts.Clear();
                arrColumnWidths.Clear();
                iCellHeight = 0;
                iRow = 0;
                bFirstPage = true;
                bNewPage = true;

                // Calculating Total Widths
                iTotalWidth = 0;
                foreach (DataGridViewColumn dgvGridCol in dtGridView.Columns)
                {
                    iTotalWidth += dgvGridCol.Width;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void printPreview(object sender, EventArgs e)
        {
            //Open the print preview dialog

            DialogResult dr = MessageBox.Show("متابعة هذا الإجراء سيقوم بتحميل الملف الى الطابعة إذا ضغطت على زر الطباعة دون اظهار نافذة الطباعة، هل تود الإستمرار ؟ \n في حالة رغبتك بالدخول الى إعدادات الطباعة ، قم باختيار الإختيار الثاني و ليس إختيار مشاهدة الملف", "تنبيه!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                printPreviewDialog1.ShowDialog(this);
            }

        }
        private void printDocument(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;
            //printDialog.UseEXDialog = true;
            //Get the document
            if (DialogResult.OK == printDialog.ShowDialog())
            {
                printDocument1.DocumentName = "Test Page Print";
                printDocument1.Print();
            }
        }
        #endregion
        #region Debugging
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
       
        }
        #endregion
        private void timerCheck_Tick(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isLoaded != true && loadThread.IsAlive == false)
            {
                //load width
                for (int i = 0; i < dtGridView.Columns.Count; i++)
                {
                    dtGridView.Columns[i].Width = Convert.ToInt32(Properties.Settings.Default.colWidthString.Split(',')[i]);
                }
                isLoaded = true;
                timerWidthLoad.Enabled = false;
            }
        }
        #region Excel Exporting
        private void excelExport_Click(object sender, EventArgs e)
        {
            excelExportDG.ShowDialog();
            excelExportDG.FileOk += excelExportDG_FileOk;
             
        }

      private  void excelExportDG_FileOk(object sender, CancelEventArgs e)
        {
            excelFilePath = excelExportDG.FileName;
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            int i = 0;
            int j = 0;

            for (i = 0; i <= dtGridView.RowCount - 1; i++)
            {
                for (j = 0; j <= dtGridView.ColumnCount - 1; j++)
                {
                    DataGridViewCell cell = dtGridView[j, i];
                    xlWorkSheet.Cells[i + 1, j + 1] = cell.Value;
                }
            }

            xlWorkBook.SaveAs(excelFilePath, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue,Excel.XlTextVisualLayoutType.xlTextVisualRTL, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);


            MessageBox.Show("تم تصدير الملف بنجاح ، يمكنك إيجاد الملف في :"+ excelFilePath);
        }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
        #endregion

        private void excelExportDG_FileOk_1(object sender, CancelEventArgs e)
        {

        }

        private void إعداداتمتقدمةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showForm(new advancedSettings(),this,setClose);
        }
    }
}
