namespace DB_Manager
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.dtGridView = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripLblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._drDataLoad = new System.Windows.Forms.ToolStripMenuItem();
            this._drDataSave = new System.Windows.Forms.ToolStripMenuItem();
            this._drDataSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this._drDataPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToExcel = new System.Windows.Forms.ToolStripMenuItem();
            this._drPrintPrv = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this._drAppExit = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._drDataClear = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this._drDataSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._drCustomize = new System.Windows.Forms.ToolStripMenuItem();
            this.إعداداتمتقدمةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._drHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this._drAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBar = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolPrPrv = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDataLoad = new System.Windows.Forms.ToolStripButton();
            this.btnSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.timeTimer = new System.Windows.Forms.Timer(this.components);
            this.progressTimer = new System.Windows.Forms.Timer(this.components);
            this.printDG = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.timerWidthLoad = new System.Windows.Forms.Timer(this.components);
            this.excelExportDG = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtGridView
            // 
            this.dtGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGridView.Location = new System.Drawing.Point(0, 49);
            this.dtGridView.Name = "dtGridView";
            this.dtGridView.Size = new System.Drawing.Size(561, 180);
            this.dtGridView.TabIndex = 0;
            this.dtGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dtGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dtGridView.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridView1_ColumnWidthChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLblTime,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 229);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(561, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripLblTime
            // 
            this.toolStripLblTime.Name = "toolStripLblTime";
            this.toolStripLblTime.Size = new System.Drawing.Size(546, 17);
            this.toolStripLblTime.Spring = true;
            this.toolStripLblTime.Text = "Date/Time";
            this.toolStripLblTime.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.toolStripProgressBar1.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(561, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._drDataLoad,
            this._drDataSave,
            this._drDataSearch,
            this.toolStripSeparator3,
            this._drDataPrint,
            this.exportToExcel,
            this._drPrintPrv,
            this.toolStripSeparator4,
            this._drAppExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.fileToolStripMenuItem.Text = "&ملف";
            // 
            // _drDataLoad
            // 
            this._drDataLoad.Image = global::DB_Manager.Properties.Resources.load_download;
            this._drDataLoad.Name = "_drDataLoad";
            this._drDataLoad.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this._drDataLoad.Size = new System.Drawing.Size(243, 22);
            this._drDataLoad.Text = "&تحميل البيانات";
            this._drDataLoad.Click += new System.EventHandler(this.loadData);
            // 
            // _drDataSave
            // 
            this._drDataSave.Enabled = false;
            this._drDataSave.Image = ((System.Drawing.Image)(resources.GetObject("_drDataSave.Image")));
            this._drDataSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._drDataSave.Name = "_drDataSave";
            this._drDataSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this._drDataSave.Size = new System.Drawing.Size(243, 22);
            this._drDataSave.Text = "&حفظ البيانات";
            // 
            // _drDataSearch
            // 
            this._drDataSearch.Enabled = false;
            this._drDataSearch.Image = global::DB_Manager.Properties.Resources._13;
            this._drDataSearch.Name = "_drDataSearch";
            this._drDataSearch.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this._drDataSearch.Size = new System.Drawing.Size(243, 22);
            this._drDataSearch.Text = "الإ&ستعلام عن بيانات محددة";
            this._drDataSearch.Click += new System.EventHandler(this.btnSearchClick);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(240, 6);
            // 
            // _drDataPrint
            // 
            this._drDataPrint.Enabled = false;
            this._drDataPrint.Image = ((System.Drawing.Image)(resources.GetObject("_drDataPrint.Image")));
            this._drDataPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._drDataPrint.Name = "_drDataPrint";
            this._drDataPrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this._drDataPrint.Size = new System.Drawing.Size(243, 22);
            this._drDataPrint.Text = "&طباعة البيانات";
            this._drDataPrint.Click += new System.EventHandler(this.printDocument);
            // 
            // exportToExcel
            // 
            this.exportToExcel.Enabled = false;
            this.exportToExcel.Image = global::DB_Manager.Properties.Resources.download;
            this.exportToExcel.Name = "exportToExcel";
            this.exportToExcel.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.E)));
            this.exportToExcel.Size = new System.Drawing.Size(243, 22);
            this.exportToExcel.Text = "ت&صدير إلى ملف Excel";
            this.exportToExcel.Click += new System.EventHandler(this.excelExport_Click);
            // 
            // _drPrintPrv
            // 
            this._drPrintPrv.Enabled = false;
            this._drPrintPrv.Image = ((System.Drawing.Image)(resources.GetObject("_drPrintPrv.Image")));
            this._drPrintPrv.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._drPrintPrv.Name = "_drPrintPrv";
            this._drPrintPrv.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this._drPrintPrv.Size = new System.Drawing.Size(243, 22);
            this._drPrintPrv.Text = "&رؤية الطباعة";
            this._drPrintPrv.Click += new System.EventHandler(this.printPreview);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(240, 6);
            // 
            // _drAppExit
            // 
            this._drAppExit.Name = "_drAppExit";
            this._drAppExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this._drAppExit.Size = new System.Drawing.Size(243, 22);
            this._drAppExit.Text = "&إغلاق البرنامج";
            this._drAppExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._drDataClear,
            this.toolStripSeparator5,
            this._drDataSelect});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.editToolStripMenuItem.Text = "&تعديل";
            // 
            // _drDataClear
            // 
            this._drDataClear.Enabled = false;
            this._drDataClear.Name = "_drDataClear";
            this._drDataClear.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete)));
            this._drDataClear.Size = new System.Drawing.Size(217, 22);
            this._drDataClear.Text = "&مسح قاعدة البيانات";
            this._drDataClear.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(214, 6);
            // 
            // _drDataSelect
            // 
            this._drDataSelect.Enabled = false;
            this._drDataSelect.Name = "_drDataSelect";
            this._drDataSelect.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this._drDataSelect.Size = new System.Drawing.Size(217, 22);
            this._drDataSelect.Text = "تح&ديد الكل";
            this._drDataSelect.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._drCustomize,
            this.إعداداتمتقدمةToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.toolsToolStripMenuItem.Text = "&أدوات";
            // 
            // _drCustomize
            // 
            this._drCustomize.Name = "_drCustomize";
            this._drCustomize.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this._drCustomize.Size = new System.Drawing.Size(151, 22);
            this._drCustomize.Text = "&الإعدادات";
            this._drCustomize.Click += new System.EventHandler(this.customizeToolStripMenuItem_Click);
            // 
            // إعداداتمتقدمةToolStripMenuItem
            // 
            this.إعداداتمتقدمةToolStripMenuItem.Name = "إعداداتمتقدمةToolStripMenuItem";
            this.إعداداتمتقدمةToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.إعداداتمتقدمةToolStripMenuItem.Text = "إعدادات مت&قدمة";
            this.إعداداتمتقدمةToolStripMenuItem.Click += new System.EventHandler(this.إعداداتمتقدمةToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._drHelp,
            this.toolStripSeparator7,
            this._drAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.helpToolStripMenuItem.Text = "&مساعدة";
            // 
            // _drHelp
            // 
            this._drHelp.Name = "_drHelp";
            this._drHelp.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this._drHelp.Size = new System.Drawing.Size(128, 22);
            this._drHelp.Text = "&مساعدة";
            this._drHelp.Click += new System.EventHandler(this.showHelp);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(125, 6);
            // 
            // _drAbout
            // 
            this._drAbout.Name = "_drAbout";
            this._drAbout.Size = new System.Drawing.Size(128, 22);
            this._drAbout.Text = "&عن المبرمج";
            this._drAbout.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolBar
            // 
            this.toolBar.Enabled = false;
            this.toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton,
            this.printToolStripButton,
            this.toolPrPrv,
            this.toolStripSeparator8,
            this.toolStripButton1,
            this.toolStripSeparator6,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.btnDataLoad,
            this.btnSearch,
            this.toolStripSeparator2,
            this.helpToolStripButton});
            this.toolBar.Location = new System.Drawing.Point(0, 24);
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new System.Drawing.Size(561, 25);
            this.toolBar.TabIndex = 3;
            this.toolBar.Text = "toolStrip1";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.ToolTipText = "تحديث قاعدة البيانات";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.printToolStripButton.Text = "&Print";
            this.printToolStripButton.ToolTipText = "طباعة البيانات";
            this.printToolStripButton.Click += new System.EventHandler(this.printDocument);
            // 
            // toolPrPrv
            // 
            this.toolPrPrv.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolPrPrv.Image = global::DB_Manager.Properties.Resources.Print_preview;
            this.toolPrPrv.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolPrPrv.Name = "toolPrPrv";
            this.toolPrPrv.Size = new System.Drawing.Size(23, 22);
            this.toolPrPrv.Text = "print Preview";
            this.toolPrPrv.ToolTipText = "رؤية الملف قبل الطباعة";
            this.toolPrPrv.Click += new System.EventHandler(this.printPreview);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::DB_Manager.Properties.Resources.download;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.excelExport_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::DB_Manager.Properties.Resources.Sign_Select_icon;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "تحديد ال&كل";
            this.toolStripButton2.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnDataLoad
            // 
            this.btnDataLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDataLoad.Image = global::DB_Manager.Properties.Resources.load_download;
            this.btnDataLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDataLoad.Name = "btnDataLoad";
            this.btnDataLoad.Size = new System.Drawing.Size(23, 22);
            this.btnDataLoad.Text = "إعا&دة تحميل البيانات من آخر حفظ";
            this.btnDataLoad.Click += new System.EventHandler(this.loadData);
            // 
            // btnSearch
            // 
            this.btnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSearch.Image = global::DB_Manager.Properties.Resources._13;
            this.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(23, 22);
            this.btnSearch.Text = "الإستعلام عن بيانات معينة";
            this.btnSearch.ToolTipText = "الإستعلام عن بيانات معينة\r\n";
            this.btnSearch.Click += new System.EventHandler(this.btnSearchClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "He&lp";
            this.helpToolStripButton.ToolTipText = "مساعدة";
            this.helpToolStripButton.Click += new System.EventHandler(this.showHelp);
            // 
            // timeTimer
            // 
            this.timeTimer.Enabled = true;
            this.timeTimer.Tick += new System.EventHandler(this.timeTimer_Tick);
            // 
            // progressTimer
            // 
            this.progressTimer.Tick += new System.EventHandler(this.progressTimer_Tick);
            // 
            // printDG
            // 
            this.printDG.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // timerWidthLoad
            // 
            this.timerWidthLoad.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // excelExportDG
            // 
            this.excelExportDG.DefaultExt = "xlsx";
            this.excelExportDG.FileName = "قاعدة بيانات";
            this.excelExportDG.Filter = "Excel File|*.xls";
            this.excelExportDG.InitialDirectory = "Desktop";
            this.excelExportDG.Title = "تصدير الى ملف Excel";
            this.excelExportDG.FileOk += new System.ComponentModel.CancelEventHandler(this.excelExportDG_FileOk_1);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 251);
            this.Controls.Add(this.dtGridView);
            this.Controls.Add(this.toolBar);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "إدارة قاعدة البيانات";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainForm_FormClosed);
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridView;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripLblTime;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _drDataSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem _drDataPrint;
        private System.Windows.Forms.ToolStripMenuItem _drPrintPrv;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem _drAppExit;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _drDataClear;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem _drDataSelect;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _drCustomize;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _drHelp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem _drAbout;
        private System.Windows.Forms.ToolStrip toolBar;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.Timer timeTimer;
        private System.Windows.Forms.ToolStripButton btnDataLoad;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem _drDataLoad;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton btnSearch;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.Timer progressTimer;
        private System.Windows.Forms.ToolStripMenuItem _drDataSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.PrintDialog printDG;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ToolStripButton toolPrPrv;
        private System.Windows.Forms.Timer timerWidthLoad;
        private System.Windows.Forms.ToolStripMenuItem exportToExcel;
        private System.Windows.Forms.SaveFileDialog excelExportDG;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem إعداداتمتقدمةToolStripMenuItem;
    }
}

