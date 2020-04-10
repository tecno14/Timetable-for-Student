namespace Pr2txt.Frms
{
    partial class Frm3AddRols
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Course",
            "X",
            "Y",
            "-.*"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Group",
            "X",
            "Y",
            "[^-]*-"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Present",
            "X",
            "Y+1",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "Day",
            "X",
            "2",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "Period",
            "X",
            "3",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "Room",
            "1",
            "Y",
            ""}, -1);
            this.BtnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSaveAs = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CbDrowCells = new System.Windows.Forms.CheckBox();
            this.BtnDelRol = new System.Windows.Forms.Button();
            this.Lv_Roles = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnRolAction = new System.Windows.Forms.Button();
            this.Gb_RolProp = new System.Windows.Forms.GroupBox();
            this.Tb_DelReg = new System.Windows.Forms.TextBox();
            this.Cb_DelReg = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Tb_RolName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.Tb_RolRegY = new System.Windows.Forms.TextBox();
            this.Tb_RolRegX = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Gb_RolProp.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(20, 3);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 23);
            this.BtnBack.TabIndex = 16;
            this.BtnBack.Text = "< Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(101, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 34);
            this.label1.TabIndex = 15;
            this.label1.Text = "* RegEx ( [^,]*, || ... )";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnSaveAs
            // 
            this.BtnSaveAs.Location = new System.Drawing.Point(440, 3);
            this.BtnSaveAs.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.BtnSaveAs.Name = "BtnSaveAs";
            this.BtnSaveAs.Size = new System.Drawing.Size(75, 23);
            this.BtnSaveAs.TabIndex = 17;
            this.BtnSaveAs.Text = "Generate >";
            this.BtnSaveAs.UseVisualStyleBackColor = true;
            this.BtnSaveAs.Click += new System.EventHandler(this.BtnSaveAs_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.dataGridView2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(535, 365);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 188);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView2.Size = new System.Drawing.Size(526, 174);
            this.dataGridView2.TabIndex = 27;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.Gb_RolProp);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 6);
            this.groupBox1.Size = new System.Drawing.Size(529, 179);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Roles";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.CbDrowCells);
            this.panel1.Controls.Add(this.BtnDelRol);
            this.panel1.Controls.Add(this.Lv_Roles);
            this.panel1.Controls.Add(this.BtnRolAction);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 160);
            this.panel1.TabIndex = 30;
            // 
            // CbDrowCells
            // 
            this.CbDrowCells.AutoSize = true;
            this.CbDrowCells.Font = new System.Drawing.Font("Tahoma", 8F);
            this.CbDrowCells.Location = new System.Drawing.Point(10, 132);
            this.CbDrowCells.Name = "CbDrowCells";
            this.CbDrowCells.Size = new System.Drawing.Size(146, 17);
            this.CbDrowCells.TabIndex = 27;
            this.CbDrowCells.Text = "Drow Role ( for first cell )";
            this.CbDrowCells.UseVisualStyleBackColor = true;
            this.CbDrowCells.Visible = false;
            // 
            // BtnDelRol
            // 
            this.BtnDelRol.Enabled = false;
            this.BtnDelRol.Location = new System.Drawing.Point(292, 129);
            this.BtnDelRol.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.BtnDelRol.Name = "BtnDelRol";
            this.BtnDelRol.Size = new System.Drawing.Size(75, 23);
            this.BtnDelRol.TabIndex = 29;
            this.BtnDelRol.Text = "Delete";
            this.BtnDelRol.UseVisualStyleBackColor = true;
            this.BtnDelRol.Click += new System.EventHandler(this.BtnDelRol_Click);
            // 
            // Lv_Roles
            // 
            this.Lv_Roles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.Lv_Roles.FullRowSelect = true;
            this.Lv_Roles.GridLines = true;
            this.Lv_Roles.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.Lv_Roles.Location = new System.Drawing.Point(6, 7);
            this.Lv_Roles.MultiSelect = false;
            this.Lv_Roles.Name = "Lv_Roles";
            this.Lv_Roles.Size = new System.Drawing.Size(380, 115);
            this.Lv_Roles.TabIndex = 27;
            this.Lv_Roles.UseCompatibleStateImageBehavior = false;
            this.Lv_Roles.View = System.Windows.Forms.View.Details;
            this.Lv_Roles.SelectedIndexChanged += new System.EventHandler(this.Lv_Roles_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "# Name";
            this.columnHeader1.Width = 82;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Column(X)";
            this.columnHeader2.Width = 99;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Row(Y)";
            this.columnHeader3.Width = 95;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "DelRegEx";
            this.columnHeader4.Width = 99;
            // 
            // BtnRolAction
            // 
            this.BtnRolAction.Location = new System.Drawing.Point(185, 129);
            this.BtnRolAction.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.BtnRolAction.Name = "BtnRolAction";
            this.BtnRolAction.Size = new System.Drawing.Size(75, 23);
            this.BtnRolAction.TabIndex = 28;
            this.BtnRolAction.Text = "Add";
            this.BtnRolAction.UseVisualStyleBackColor = true;
            this.BtnRolAction.Click += new System.EventHandler(this.BtnRolAction_Click);
            // 
            // Gb_RolProp
            // 
            this.Gb_RolProp.AutoSize = true;
            this.Gb_RolProp.Controls.Add(this.Tb_DelReg);
            this.Gb_RolProp.Controls.Add(this.Cb_DelReg);
            this.Gb_RolProp.Controls.Add(this.label17);
            this.Gb_RolProp.Controls.Add(this.label16);
            this.Gb_RolProp.Controls.Add(this.Tb_RolName);
            this.Gb_RolProp.Controls.Add(this.label15);
            this.Gb_RolProp.Controls.Add(this.Tb_RolRegY);
            this.Gb_RolProp.Controls.Add(this.Tb_RolRegX);
            this.Gb_RolProp.Dock = System.Windows.Forms.DockStyle.Right;
            this.Gb_RolProp.Enabled = false;
            this.Gb_RolProp.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.Gb_RolProp.Location = new System.Drawing.Point(403, 13);
            this.Gb_RolProp.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.Gb_RolProp.Name = "Gb_RolProp";
            this.Gb_RolProp.Size = new System.Drawing.Size(123, 160);
            this.Gb_RolProp.TabIndex = 27;
            this.Gb_RolProp.TabStop = false;
            this.Gb_RolProp.Text = "안녕 !  (ツ)";
            // 
            // Tb_DelReg
            // 
            this.Tb_DelReg.BackColor = System.Drawing.Color.Red;
            this.Tb_DelReg.Enabled = false;
            this.Tb_DelReg.Font = new System.Drawing.Font("Tahoma", 8F);
            this.Tb_DelReg.ForeColor = System.Drawing.Color.White;
            this.Tb_DelReg.Location = new System.Drawing.Point(26, 134);
            this.Tb_DelReg.Name = "Tb_DelReg";
            this.Tb_DelReg.Size = new System.Drawing.Size(91, 20);
            this.Tb_DelReg.TabIndex = 14;
            this.Tb_DelReg.Text = "[^,]*,";
            this.Tb_DelReg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Cb_DelReg
            // 
            this.Cb_DelReg.AutoSize = true;
            this.Cb_DelReg.Font = new System.Drawing.Font("Tahoma", 8F);
            this.Cb_DelReg.Location = new System.Drawing.Point(6, 114);
            this.Cb_DelReg.Name = "Cb_DelReg";
            this.Cb_DelReg.Size = new System.Drawing.Size(57, 17);
            this.Cb_DelReg.TabIndex = 13;
            this.Cb_DelReg.Text = "Delete";
            this.Cb_DelReg.UseVisualStyleBackColor = true;
            this.Cb_DelReg.CheckedChanged += new System.EventHandler(this.Cb_DelReg_CheckedChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 8F);
            this.label17.Location = new System.Drawing.Point(5, 26);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(15, 13);
            this.label17.TabIndex = 9;
            this.label17.Text = "#";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 8F);
            this.label16.Location = new System.Drawing.Point(5, 92);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(21, 13);
            this.label16.TabIndex = 12;
            this.label16.Text = "Y=";
            // 
            // Tb_RolName
            // 
            this.Tb_RolName.Font = new System.Drawing.Font("Tahoma", 8F);
            this.Tb_RolName.Location = new System.Drawing.Point(26, 22);
            this.Tb_RolName.Name = "Tb_RolName";
            this.Tb_RolName.Size = new System.Drawing.Size(91, 20);
            this.Tb_RolName.TabIndex = 8;
            this.Tb_RolName.Text = "NameNoRpeat";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 8F);
            this.label15.Location = new System.Drawing.Point(5, 58);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(21, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "X=";
            // 
            // Tb_RolRegY
            // 
            this.Tb_RolRegY.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Tb_RolRegY.Font = new System.Drawing.Font("Tahoma", 8F);
            this.Tb_RolRegY.ForeColor = System.Drawing.Color.White;
            this.Tb_RolRegY.Location = new System.Drawing.Point(26, 88);
            this.Tb_RolRegY.Name = "Tb_RolRegY";
            this.Tb_RolRegY.Size = new System.Drawing.Size(91, 20);
            this.Tb_RolRegY.TabIndex = 11;
            this.Tb_RolRegY.Text = "Y";
            this.Tb_RolRegY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Tb_RolRegX
            // 
            this.Tb_RolRegX.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Tb_RolRegX.Font = new System.Drawing.Font("Tahoma", 8F);
            this.Tb_RolRegX.ForeColor = System.Drawing.Color.White;
            this.Tb_RolRegX.Location = new System.Drawing.Point(26, 54);
            this.Tb_RolRegX.Name = "Tb_RolRegX";
            this.Tb_RolRegX.Size = new System.Drawing.Size(91, 20);
            this.Tb_RolRegX.TabIndex = 11;
            this.Tb_RolRegX.Text = "X";
            this.Tb_RolRegX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.BtnBack, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnSaveAs, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 374);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(535, 34);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(534, 411);
            this.tableLayoutPanel1.TabIndex = 26;
            // 
            // Frm3AddRols
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 411);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(550, 450);
            this.Name = "Frm3AddRols";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excel2List Tool V1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm3AddRols_FormClosing);
            this.Load += new System.EventHandler(this.Frm3AddRols_Load);
            this.Shown += new System.EventHandler(this.Frm3AddRols_Shown);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Gb_RolProp.ResumeLayout(false);
            this.Gb_RolProp.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSaveAs;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button BtnDelRol;
        private System.Windows.Forms.ListView Lv_Roles;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button BtnRolAction;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox Gb_RolProp;
        private System.Windows.Forms.TextBox Tb_DelReg;
        private System.Windows.Forms.CheckBox Cb_DelReg;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox Tb_RolName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox Tb_RolRegY;
        private System.Windows.Forms.TextBox Tb_RolRegX;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.CheckBox CbDrowCells;
    }
}