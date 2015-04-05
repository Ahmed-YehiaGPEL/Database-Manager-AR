namespace DB_Manager
{
    partial class queryWeight
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cmbAge2 = new System.Windows.Forms.ComboBox();
            this.numAge2 = new System.Windows.Forms.NumericUpDown();
            this.numAge1 = new System.Windows.Forms.NumericUpDown();
            this.cmbAge1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkMulti = new System.Windows.Forms.CheckBox();
            this.btnSubmit = new Glass.GlassButton();
            this.lblName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAge2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAge1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cmbAge2);
            this.splitContainer1.Panel1.Controls.Add(this.numAge2);
            this.splitContainer1.Panel1.Controls.Add(this.numAge1);
            this.splitContainer1.Panel1.Controls.Add(this.cmbAge1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.checkMulti);
            this.splitContainer1.Panel1.Controls.Add(this.btnSubmit);
            this.splitContainer1.Panel1.Controls.Add(this.lblName);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(612, 334);
            this.splitContainer1.SplitterDistance = 144;
            this.splitContainer1.TabIndex = 2;
            // 
            // cmbAge2
            // 
            this.cmbAge2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAge2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAge2.Enabled = false;
            this.cmbAge2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAge2.FormattingEnabled = true;
            this.cmbAge2.Items.AddRange(new object[] {
            ">",
            "<",
            "==",
            "<=",
            ">=",
            "!="});
            this.cmbAge2.Location = new System.Drawing.Point(405, 83);
            this.cmbAge2.Name = "cmbAge2";
            this.cmbAge2.Size = new System.Drawing.Size(125, 27);
            this.cmbAge2.TabIndex = 13;
            // 
            // numAge2
            // 
            this.numAge2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numAge2.Enabled = false;
            this.numAge2.Location = new System.Drawing.Point(203, 90);
            this.numAge2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numAge2.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numAge2.Name = "numAge2";
            this.numAge2.Size = new System.Drawing.Size(182, 20);
            this.numAge2.TabIndex = 11;
            this.numAge2.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numAge1
            // 
            this.numAge1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numAge1.Location = new System.Drawing.Point(203, 11);
            this.numAge1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numAge1.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numAge1.Name = "numAge1";
            this.numAge1.Size = new System.Drawing.Size(182, 20);
            this.numAge1.TabIndex = 10;
            this.numAge1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // cmbAge1
            // 
            this.cmbAge1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAge1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAge1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAge1.FormattingEnabled = true;
            this.cmbAge1.Items.AddRange(new object[] {
            ">",
            "<",
            "==",
            "<=",
            ">=",
            "!="});
            this.cmbAge1.Location = new System.Drawing.Point(405, 12);
            this.cmbAge1.Name = "cmbAge1";
            this.cmbAge1.Size = new System.Drawing.Size(125, 27);
            this.cmbAge1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(553, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "الوزن :";
            // 
            // checkMulti
            // 
            this.checkMulti.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkMulti.AutoSize = true;
            this.checkMulti.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkMulti.Location = new System.Drawing.Point(509, 55);
            this.checkMulti.Name = "checkMulti";
            this.checkMulti.Size = new System.Drawing.Size(87, 22);
            this.checkMulti.TabIndex = 3;
            this.checkMulti.Text = "بحث متشعب";
            this.checkMulti.UseVisualStyleBackColor = true;
            this.checkMulti.CheckedChanged += new System.EventHandler(this.checkMulti_CheckedChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSubmit.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(5, 105);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.OuterBorderColor = System.Drawing.Color.Transparent;
            this.btnSubmit.Size = new System.Drawing.Size(187, 36);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "ابدأ البحث";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(553, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(50, 19);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "الوزن :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(612, 186);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "نتائج البحث :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(606, 167);
            this.dataGridView1.TabIndex = 0;
            // 
            // queryWeight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 334);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "queryWeight";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "الإستعلام عن الوزن :";
            this.Load += new System.EventHandler(this.queryWeight_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numAge2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAge1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox cmbAge2;
        private System.Windows.Forms.NumericUpDown numAge2;
        private System.Windows.Forms.NumericUpDown numAge1;
        private System.Windows.Forms.ComboBox cmbAge1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkMulti;
        private Glass.GlassButton btnSubmit;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;

    }
}