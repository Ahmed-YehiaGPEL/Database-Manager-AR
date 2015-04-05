namespace DB_Manager
{
    partial class queryBuilder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(queryBuilder));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.stripName = new System.Windows.Forms.ToolStripButton();
            this.stripAge = new System.Windows.Forms.ToolStripButton();
            this.stripWeight = new System.Windows.Forms.ToolStripButton();
            this.stripWA = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.timTime = new System.Windows.Forms.Timer(this.components);
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripName,
            this.stripAge,
            this.stripWeight,
            this.stripWA,
            this.toolStripButton1});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip.Size = new System.Drawing.Size(791, 25);
            this.toolStrip.Stretch = true;
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // stripName
            // 
            this.stripName.Image = ((System.Drawing.Image)(resources.GetObject("stripName.Image")));
            this.stripName.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stripName.Name = "stripName";
            this.stripName.Size = new System.Drawing.Size(110, 22);
            this.stripName.Tag = "1";
            this.stripName.Text = "بحث بواسطة الإسم";
            this.stripName.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // stripAge
            // 
            this.stripAge.Image = ((System.Drawing.Image)(resources.GetObject("stripAge.Image")));
            this.stripAge.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stripAge.Name = "stripAge";
            this.stripAge.Size = new System.Drawing.Size(108, 22);
            this.stripAge.Tag = "2";
            this.stripAge.Text = "بحث بواسطة العمر";
            this.stripAge.Click += new System.EventHandler(this.stripAge_Click);
            // 
            // stripWeight
            // 
            this.stripWeight.Image = ((System.Drawing.Image)(resources.GetObject("stripWeight.Image")));
            this.stripWeight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stripWeight.Name = "stripWeight";
            this.stripWeight.Size = new System.Drawing.Size(110, 22);
            this.stripWeight.Tag = "3";
            this.stripWeight.Text = "بحث بواسطة الوزن";
            this.stripWeight.Click += new System.EventHandler(this.stripWeight_Click);
            // 
            // stripWA
            // 
            this.stripWA.Image = ((System.Drawing.Image)(resources.GetObject("stripWA.Image")));
            this.stripWA.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stripWA.Name = "stripWA";
            this.stripWA.Size = new System.Drawing.Size(143, 22);
            this.stripWA.Tag = "4";
            this.stripWA.Text = "بحث بواسطة العمر و الوزن";
            this.stripWA.Click += new System.EventHandler(this.stripWA_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(140, 22);
            this.toolStripButton1.Text = "بحث بواسطة رقم العضوية";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 305);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(791, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(776, 17);
            this.toolStripStatusLabel.Spring = true;
            this.toolStripStatusLabel.Text = "Status";
            this.toolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timTime
            // 
            this.timTime.Enabled = true;
            this.timTime.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // queryBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 327);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.statusStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.IsMdiContainer = true;
            this.MinimizeBox = false;
            this.Name = "queryBuilder";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "نافذة الإستعلامات";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Timer timTime;
        private System.Windows.Forms.ToolStripButton stripName;
        private System.Windows.Forms.ToolStripButton stripAge;
        private System.Windows.Forms.ToolStripButton stripWeight;
        private System.Windows.Forms.ToolStripButton stripWA;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}



