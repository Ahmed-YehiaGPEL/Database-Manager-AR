namespace DB_Manager
{
    partial class advancedSettings
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
            this.sStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ctTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rePwdText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pwdTxt = new System.Windows.Forms.TextBox();
            this.btnReset = new Glass.GlassButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.sStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // sStrip
            // 
            this.sStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.sStrip.Location = new System.Drawing.Point(0, 202);
            this.sStrip.Name = "sStrip";
            this.sStrip.Size = new System.Drawing.Size(322, 22);
            this.sStrip.TabIndex = 0;
            this.sStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(307, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "Date Time";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rePwdText);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pwdTxt);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 180);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تغيير تصريحات الدخول";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "*أعد كتابة التصريح الجديد";
            // 
            // rePwdText
            // 
            this.rePwdText.Location = new System.Drawing.Point(111, 87);
            this.rePwdText.Name = "rePwdText";
            this.rePwdText.PasswordChar = '@';
            this.rePwdText.Size = new System.Drawing.Size(120, 20);
            this.rePwdText.TabIndex = 4;
            this.rePwdText.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = " *التصريح الجديد";
            // 
            // pwdTxt
            // 
            this.pwdTxt.Location = new System.Drawing.Point(111, 29);
            this.pwdTxt.Name = "pwdTxt";
            this.pwdTxt.PasswordChar = '@';
            this.pwdTxt.Size = new System.Drawing.Size(120, 20);
            this.pwdTxt.TabIndex = 2;
            this.pwdTxt.UseSystemPasswordChar = true;
            this.pwdTxt.TextChanged += new System.EventHandler(this.pwdTxt_TextChanged);
            // 
            // btnReset
            // 
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(40, 132);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(219, 33);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "إعادة ضبط تصريح الدخول";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(0, 185);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(322, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "تصريح الدخول مفعل";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // timerTime
            // 
            this.timerTime.Enabled = true;
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // advancedSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 224);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sStrip);
            this.MaximizeBox = false;
            this.Name = "advancedSettings";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "الإعدادات المتقدمة";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.advancedSettings_Load);
            this.sStrip.ResumeLayout(false);
            this.sStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip sStrip;
        private System.Windows.Forms.ToolTip ctTip;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rePwdText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pwdTxt;
        private Glass.GlassButton btnReset;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}