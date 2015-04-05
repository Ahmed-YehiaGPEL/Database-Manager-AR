namespace DB_Manager
{
    partial class queryWeightAge
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnSubmit = new Glass.GlassButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbAge2 = new System.Windows.Forms.ComboBox();
            this.numAge2 = new System.Windows.Forms.NumericUpDown();
            this.numAge1 = new System.Windows.Forms.NumericUpDown();
            this.cmbAge1 = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numWe1 = new System.Windows.Forms.NumericUpDown();
            this.cmbWe2 = new System.Windows.Forms.ComboBox();
            this.numWe2 = new System.Windows.Forms.NumericUpDown();
            this.cmbWe1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAge2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAge1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWe1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWe2)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.groupBox4);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(681, 379);
            this.splitContainer1.SplitterDistance = 204;
            this.splitContainer1.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.checkBox1);
            this.groupBox4.Controls.Add(this.btnSubmit);
            this.groupBox4.Location = new System.Drawing.Point(3, 148);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(675, 78);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "بحث متشعب :";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(582, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(87, 22);
            this.checkBox1.TabIndex = 24;
            this.checkBox1.Text = "بحث متشعب";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(6, 19);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.OuterBorderColor = System.Drawing.Color.Transparent;
            this.btnSubmit.Size = new System.Drawing.Size(335, 35);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "ابدأ البحث";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.cmbAge2);
            this.groupBox3.Controls.Add(this.numAge2);
            this.groupBox3.Controls.Add(this.numAge1);
            this.groupBox3.Controls.Add(this.cmbAge1);
            this.groupBox3.Controls.Add(this.lblName);
            this.groupBox3.Location = new System.Drawing.Point(366, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(315, 142);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "العمر :";
            // 
            // cmbAge2
            // 
            this.cmbAge2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAge2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAge2.Enabled = false;
            this.cmbAge2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAge2.FormattingEnabled = true;
            this.cmbAge2.Items.AddRange(new object[] {
            ">",
            "<",
            ">=",
            "<=",
            "==",
            "!="});
            this.cmbAge2.Location = new System.Drawing.Point(96, 81);
            this.cmbAge2.Name = "cmbAge2";
            this.cmbAge2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbAge2.Size = new System.Drawing.Size(213, 27);
            this.cmbAge2.TabIndex = 25;
            this.cmbAge2.Tag = "multi";
            // 
            // numAge2
            // 
            this.numAge2.Enabled = false;
            this.numAge2.Location = new System.Drawing.Point(188, 114);
            this.numAge2.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numAge2.Name = "numAge2";
            this.numAge2.Size = new System.Drawing.Size(121, 20);
            this.numAge2.TabIndex = 22;
            this.numAge2.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // numAge1
            // 
            this.numAge1.Location = new System.Drawing.Point(188, 47);
            this.numAge1.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numAge1.Name = "numAge1";
            this.numAge1.Size = new System.Drawing.Size(121, 20);
            this.numAge1.TabIndex = 23;
            this.numAge1.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // cmbAge1
            // 
            this.cmbAge1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAge1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAge1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAge1.FormattingEnabled = true;
            this.cmbAge1.Items.AddRange(new object[] {
            ">",
            "<",
            ">=",
            "<=",
            "==",
            "!="});
            this.cmbAge1.Location = new System.Drawing.Point(96, 14);
            this.cmbAge1.Name = "cmbAge1";
            this.cmbAge1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbAge1.Size = new System.Drawing.Size(213, 27);
            this.cmbAge1.TabIndex = 21;
            this.cmbAge1.SelectedIndexChanged += new System.EventHandler(this.cmbAge1_SelectedIndexChanged);
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(451, 37);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(50, 19);
            this.lblName.TabIndex = 21;
            this.lblName.Text = "الوزن :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.numWe1);
            this.groupBox2.Controls.Add(this.cmbWe2);
            this.groupBox2.Controls.Add(this.numWe2);
            this.groupBox2.Controls.Add(this.cmbWe1);
            this.groupBox2.Location = new System.Drawing.Point(3, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 142);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " الوزن :";
            // 
            // numWe1
            // 
            this.numWe1.Location = new System.Drawing.Point(220, 47);
            this.numWe1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numWe1.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numWe1.Name = "numWe1";
            this.numWe1.Size = new System.Drawing.Size(121, 20);
            this.numWe1.TabIndex = 26;
            this.numWe1.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // cmbWe2
            // 
            this.cmbWe2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbWe2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWe2.Enabled = false;
            this.cmbWe2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbWe2.FormattingEnabled = true;
            this.cmbWe2.Items.AddRange(new object[] {
            ">",
            "<",
            ">=",
            "<=",
            "==",
            "!="});
            this.cmbWe2.Location = new System.Drawing.Point(128, 81);
            this.cmbWe2.Name = "cmbWe2";
            this.cmbWe2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbWe2.Size = new System.Drawing.Size(213, 27);
            this.cmbWe2.TabIndex = 25;
            // 
            // numWe2
            // 
            this.numWe2.Enabled = false;
            this.numWe2.Location = new System.Drawing.Point(220, 114);
            this.numWe2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numWe2.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numWe2.Name = "numWe2";
            this.numWe2.Size = new System.Drawing.Size(121, 20);
            this.numWe2.TabIndex = 24;
            this.numWe2.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // cmbWe1
            // 
            this.cmbWe1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbWe1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWe1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbWe1.FormattingEnabled = true;
            this.cmbWe1.Items.AddRange(new object[] {
            ">",
            "<",
            ">=",
            "<=",
            "==",
            "!="});
            this.cmbWe1.Location = new System.Drawing.Point(128, 14);
            this.cmbWe1.Name = "cmbWe1";
            this.cmbWe1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbWe1.Size = new System.Drawing.Size(213, 27);
            this.cmbWe1.TabIndex = 22;
            this.cmbWe1.SelectedIndexChanged += new System.EventHandler(this.cmbWe1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(681, 171);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "نتائج البحث :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(675, 152);
            this.dataGridView1.TabIndex = 0;
            // 
            // queryWeightAge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 379);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "queryWeightAge";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "الإستعلام عن الوزن و العمر :";
            this.Load += new System.EventHandler(this.queryWeightAge_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAge2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAge1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numWe1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWe2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private Glass.GlassButton btnSubmit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbWe2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.NumericUpDown numAge1;
        private System.Windows.Forms.NumericUpDown numAge2;
        private System.Windows.Forms.ComboBox cmbAge1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbAge2;
        private System.Windows.Forms.NumericUpDown numWe2;
        private System.Windows.Forms.ComboBox cmbWe1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.NumericUpDown numWe1;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}