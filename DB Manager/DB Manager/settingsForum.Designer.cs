namespace DB_Manager
{
    partial class settingsForum
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
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.glassButton2 = new Glass.GlassButton();
            this.checkAutoUpdate = new System.Windows.Forms.CheckBox();
            this.checkHideBar = new System.Windows.Forms.CheckBox();
            this.checkAutoLoad = new System.Windows.Forms.CheckBox();
            this.glassButton1 = new Glass.GlassButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fontDialog
            // 
            this.fontDialog.Color = System.Drawing.SystemColors.ControlText;
            this.fontDialog.Apply += new System.EventHandler(this.fontDialog_Apply);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.glassButton2);
            this.groupBox1.Controls.Add(this.checkAutoUpdate);
            this.groupBox1.Controls.Add(this.checkHideBar);
            this.groupBox1.Controls.Add(this.checkAutoLoad);
            this.groupBox1.Controls.Add(this.glassButton1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 141);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تغيير الاعدادات";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // glassButton2
            // 
            this.glassButton2.GlowColor = System.Drawing.Color.Lime;
            this.glassButton2.Location = new System.Drawing.Point(13, 106);
            this.glassButton2.Name = "glassButton2";
            this.glassButton2.Size = new System.Drawing.Size(75, 23);
            this.glassButton2.TabIndex = 6;
            this.glassButton2.Text = "حفظ ";
            this.glassButton2.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // checkAutoUpdate
            // 
            this.checkAutoUpdate.AutoSize = true;
            this.checkAutoUpdate.BackColor = System.Drawing.Color.Transparent;
            this.checkAutoUpdate.Location = new System.Drawing.Point(111, 118);
            this.checkAutoUpdate.Name = "checkAutoUpdate";
            this.checkAutoUpdate.Size = new System.Drawing.Size(156, 17);
            this.checkAutoUpdate.TabIndex = 5;
            this.checkAutoUpdate.Text = "التحديث الآلي لقاعدة البيانات";
            this.checkAutoUpdate.UseVisualStyleBackColor = false;
            this.checkAutoUpdate.CheckedChanged += new System.EventHandler(this.checkAutoUpdate_CheckedChanged);
            this.checkAutoUpdate.MouseHover += new System.EventHandler(this.checkAutoUpdate_MouseHover);
            // 
            // checkHideBar
            // 
            this.checkHideBar.AutoSize = true;
            this.checkHideBar.BackColor = System.Drawing.Color.Transparent;
            this.checkHideBar.Location = new System.Drawing.Point(144, 89);
            this.checkHideBar.Name = "checkHideBar";
            this.checkHideBar.Size = new System.Drawing.Size(123, 17);
            this.checkHideBar.TabIndex = 4;
            this.checkHideBar.Text = "إخفاء شريط الإعدادات";
            this.checkHideBar.UseVisualStyleBackColor = false;
            this.checkHideBar.CheckedChanged += new System.EventHandler(this.checkHideBar_CheckedChanged);
            // 
            // checkAutoLoad
            // 
            this.checkAutoLoad.AutoSize = true;
            this.checkAutoLoad.BackColor = System.Drawing.Color.Transparent;
            this.checkAutoLoad.Location = new System.Drawing.Point(52, 64);
            this.checkAutoLoad.Name = "checkAutoLoad";
            this.checkAutoLoad.Size = new System.Drawing.Size(215, 17);
            this.checkAutoLoad.TabIndex = 3;
            this.checkAutoLoad.Text = "تحميل قاعدة البيانات آليا عند بدء التشغيل";
            this.checkAutoLoad.UseVisualStyleBackColor = true;
            this.checkAutoLoad.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.checkAutoLoad.MouseHover += new System.EventHandler(this.checkAutoLoad_MouseHover);
            // 
            // glassButton1
            // 
            this.glassButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.glassButton1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glassButton1.Location = new System.Drawing.Point(3, 16);
            this.glassButton1.Name = "glassButton1";
            this.glassButton1.Size = new System.Drawing.Size(271, 39);
            this.glassButton1.TabIndex = 2;
            this.glassButton1.Text = "&تغيير نمط الخط";
            this.glassButton1.Click += new System.EventHandler(this.glassButton1_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 10;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            // 
            // settingsForum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 141);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "settingsForum";
            this.Opacity = 0.96D;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.Text = "نافذة الإعدادات";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.seetingsForm_FormClosed);
            this.Load += new System.EventHandler(this.seetingsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkHideBar;
        private System.Windows.Forms.CheckBox checkAutoLoad;
        private Glass.GlassButton glassButton1;
        private System.Windows.Forms.CheckBox checkAutoUpdate;
        private Glass.GlassButton glassButton2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}