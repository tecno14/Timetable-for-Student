namespace Pr2txt.Frms
{
    partial class Frm2AddFile
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
            this.BtnBrowser = new System.Windows.Forms.Button();
            this.TbPath = new System.Windows.Forms.TextBox();
            this.CbSheets = new System.Windows.Forms.ComboBox();
            this.GbSSize = new System.Windows.Forms.GroupBox();
            this.BtnSS = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Tb_EX = new System.Windows.Forms.TextBox();
            this.Tb_EY = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Tb_SY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Tb_SX = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnReset = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnNext = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GbNS = new System.Windows.Forms.GroupBox();
            this.BtnNS = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.Tb_N_NX = new System.Windows.Forms.TextBox();
            this.Tb_N_NY = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.Tb_N_SY = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.Tb_N_SX = new System.Windows.Forms.TextBox();
            this.GbSSize.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.GbNS.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnBrowser
            // 
            this.BtnBrowser.Location = new System.Drawing.Point(11, 20);
            this.BtnBrowser.Name = "BtnBrowser";
            this.BtnBrowser.Size = new System.Drawing.Size(29, 23);
            this.BtnBrowser.TabIndex = 21;
            this.BtnBrowser.Text = "...";
            this.BtnBrowser.UseVisualStyleBackColor = true;
            this.BtnBrowser.Click += new System.EventHandler(this.BtnBrowser_Click);
            // 
            // TbPath
            // 
            this.TbPath.Location = new System.Drawing.Point(45, 21);
            this.TbPath.Name = "TbPath";
            this.TbPath.Size = new System.Drawing.Size(295, 20);
            this.TbPath.TabIndex = 21;
            this.TbPath.Text = "D:\\_Emisa\\Student Timetable Manager\\البرنامج الدراسي 20172.xlsx";
            // 
            // CbSheets
            // 
            this.CbSheets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbSheets.FormattingEnabled = true;
            this.CbSheets.Location = new System.Drawing.Point(346, 21);
            this.CbSheets.Name = "CbSheets";
            this.CbSheets.Size = new System.Drawing.Size(94, 21);
            this.CbSheets.TabIndex = 22;
            this.CbSheets.SelectedIndexChanged += new System.EventHandler(this.CbSheets_SelectedIndexChanged);
            // 
            // GbSSize
            // 
            this.GbSSize.Controls.Add(this.BtnSS);
            this.GbSSize.Controls.Add(this.tableLayoutPanel5);
            this.GbSSize.Controls.Add(this.tableLayoutPanel4);
            this.GbSSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GbSSize.Enabled = false;
            this.GbSSize.Location = new System.Drawing.Point(3, 63);
            this.GbSSize.Name = "GbSSize";
            this.GbSSize.Size = new System.Drawing.Size(529, 56);
            this.GbSSize.TabIndex = 23;
            this.GbSSize.TabStop = false;
            this.GbSSize.Text = "2- Weekly schedule Size";
            // 
            // BtnSS
            // 
            this.BtnSS.Location = new System.Drawing.Point(471, 22);
            this.BtnSS.Name = "BtnSS";
            this.BtnSS.Size = new System.Drawing.Size(52, 23);
            this.BtnSS.TabIndex = 26;
            this.BtnSS.Text = "Chk";
            this.BtnSS.UseVisualStyleBackColor = true;
            this.BtnSS.Click += new System.EventHandler(this.WS_SizeChanged);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 5;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label9, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.label10, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.Tb_EX, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.Tb_EY, 4, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(240, 22);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(225, 26);
            this.tableLayoutPanel5.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 26);
            this.label8.TabIndex = 8;
            this.label8.Text = "End";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(128, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 26);
            this.label9.TabIndex = 10;
            this.label9.Text = "Row-Y";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(34, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 26);
            this.label10.TabIndex = 9;
            this.label10.Text = "Col-X";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Tb_EX
            // 
            this.Tb_EX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tb_EX.Location = new System.Drawing.Point(72, 3);
            this.Tb_EX.Name = "Tb_EX";
            this.Tb_EX.Size = new System.Drawing.Size(50, 20);
            this.Tb_EX.TabIndex = 4;
            this.Tb_EX.Text = "25";
            this.Tb_EX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Tb_EY
            // 
            this.Tb_EY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tb_EY.Location = new System.Drawing.Point(172, 3);
            this.Tb_EY.Name = "Tb_EY";
            this.Tb_EY.Size = new System.Drawing.Size(50, 20);
            this.Tb_EY.TabIndex = 5;
            this.Tb_EY.Text = "39";
            this.Tb_EY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.Tb_SY, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.Tb_SX, 2, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(5, 25);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(225, 26);
            this.tableLayoutPanel4.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Start";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(40, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Col-X";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Tb_SY
            // 
            this.Tb_SY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tb_SY.Location = new System.Drawing.Point(175, 3);
            this.Tb_SY.Name = "Tb_SY";
            this.Tb_SY.Size = new System.Drawing.Size(47, 20);
            this.Tb_SY.TabIndex = 3;
            this.Tb_SY.Text = "4";
            this.Tb_SY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(131, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Row-Y";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Tb_SX
            // 
            this.Tb_SX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tb_SX.Location = new System.Drawing.Point(78, 3);
            this.Tb_SX.Name = "Tb_SX";
            this.Tb_SX.Size = new System.Drawing.Size(47, 20);
            this.Tb_SX.TabIndex = 2;
            this.Tb_SX.Text = "2";
            this.Tb_SX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnReset);
            this.groupBox1.Controls.Add(this.CbSheets);
            this.groupBox1.Controls.Add(this.TbPath);
            this.groupBox1.Controls.Add(this.BtnBrowser);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 54);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1- File Path";
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(447, 20);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(65, 23);
            this.BtnReset.TabIndex = 23;
            this.BtnReset.Text = "Reset All";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
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
            this.tableLayoutPanel1.TabIndex = 25;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.BtnBack, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnNext, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 374);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(535, 34);
            this.tableLayoutPanel2.TabIndex = 0;
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
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(101, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 34);
            this.label1.TabIndex = 15;
            this.label1.Text = "* Operation ( Y+2 || 0/0 || ... )";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnNext
            // 
            this.BtnNext.Enabled = false;
            this.BtnNext.Location = new System.Drawing.Point(440, 3);
            this.BtnNext.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(75, 23);
            this.BtnNext.TabIndex = 17;
            this.BtnNext.Text = "Next >";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.dataGridView1, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.GbNS, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.GbSSize, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(535, 365);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 187);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(526, 175);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.DataGridView1_SelectionChanged);
            // 
            // GbNS
            // 
            this.GbNS.Controls.Add(this.BtnNS);
            this.GbNS.Controls.Add(this.tableLayoutPanel6);
            this.GbNS.Controls.Add(this.tableLayoutPanel7);
            this.GbNS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GbNS.Enabled = false;
            this.GbNS.Location = new System.Drawing.Point(3, 125);
            this.GbNS.Name = "GbNS";
            this.GbNS.Size = new System.Drawing.Size(529, 56);
            this.GbNS.TabIndex = 26;
            this.GbNS.TabStop = false;
            this.GbNS.Text = "3- Next Steps(for first cell only)";
            // 
            // BtnNS
            // 
            this.BtnNS.Location = new System.Drawing.Point(471, 25);
            this.BtnNS.Name = "BtnNS";
            this.BtnNS.Size = new System.Drawing.Size(52, 23);
            this.BtnNS.TabIndex = 27;
            this.BtnNS.Text = "Chk";
            this.BtnNS.UseVisualStyleBackColor = true;
            this.BtnNS.Click += new System.EventHandler(this.NextStepChanged);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 5;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.label19, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.label20, 3, 0);
            this.tableLayoutPanel6.Controls.Add(this.label21, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.Tb_N_NX, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.Tb_N_NY, 4, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(240, 22);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.Size = new System.Drawing.Size(225, 26);
            this.tableLayoutPanel6.TabIndex = 12;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.ForeColor = System.Drawing.Color.Green;
            this.label19.Location = new System.Drawing.Point(3, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(52, 26);
            this.label19.TabIndex = 8;
            this.label19.Text = "Next Line";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label20.Location = new System.Drawing.Point(141, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(38, 26);
            this.label20.TabIndex = 10;
            this.label20.Text = "Row-Y";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label21.Location = new System.Drawing.Point(61, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(32, 26);
            this.label21.TabIndex = 9;
            this.label21.Text = "Col-X";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Tb_N_NX
            // 
            this.Tb_N_NX.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Tb_N_NX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tb_N_NX.ForeColor = System.Drawing.Color.White;
            this.Tb_N_NX.Location = new System.Drawing.Point(99, 3);
            this.Tb_N_NX.Name = "Tb_N_NX";
            this.Tb_N_NX.Size = new System.Drawing.Size(36, 20);
            this.Tb_N_NX.TabIndex = 4;
            this.Tb_N_NX.Text = "X";
            this.Tb_N_NX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Tb_N_NY
            // 
            this.Tb_N_NY.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Tb_N_NY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tb_N_NY.ForeColor = System.Drawing.Color.White;
            this.Tb_N_NY.Location = new System.Drawing.Point(185, 3);
            this.Tb_N_NY.Name = "Tb_N_NY";
            this.Tb_N_NY.Size = new System.Drawing.Size(37, 20);
            this.Tb_N_NY.TabIndex = 5;
            this.Tb_N_NY.Text = "Y+2";
            this.Tb_N_NY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 5;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.label22, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.label23, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.Tb_N_SY, 4, 0);
            this.tableLayoutPanel7.Controls.Add(this.label24, 3, 0);
            this.tableLayoutPanel7.Controls.Add(this.Tb_N_SX, 2, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(5, 24);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.Size = new System.Drawing.Size(225, 26);
            this.tableLayoutPanel7.TabIndex = 11;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label22.ForeColor = System.Drawing.Color.Maroon;
            this.label22.Location = new System.Drawing.Point(3, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(55, 26);
            this.label22.TabIndex = 5;
            this.label22.Text = "Same Line";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label23.Location = new System.Drawing.Point(64, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(32, 26);
            this.label23.TabIndex = 6;
            this.label23.Text = "Col-X";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Tb_N_SY
            // 
            this.Tb_N_SY.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Tb_N_SY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tb_N_SY.ForeColor = System.Drawing.Color.White;
            this.Tb_N_SY.Location = new System.Drawing.Point(187, 3);
            this.Tb_N_SY.Name = "Tb_N_SY";
            this.Tb_N_SY.Size = new System.Drawing.Size(35, 20);
            this.Tb_N_SY.TabIndex = 3;
            this.Tb_N_SY.Text = "Y";
            this.Tb_N_SY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label24.Location = new System.Drawing.Point(143, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(38, 26);
            this.label24.TabIndex = 7;
            this.label24.Text = "Row-Y";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Tb_N_SX
            // 
            this.Tb_N_SX.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Tb_N_SX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tb_N_SX.ForeColor = System.Drawing.Color.White;
            this.Tb_N_SX.Location = new System.Drawing.Point(102, 3);
            this.Tb_N_SX.Name = "Tb_N_SX";
            this.Tb_N_SX.Size = new System.Drawing.Size(35, 20);
            this.Tb_N_SX.TabIndex = 2;
            this.Tb_N_SX.Text = "X+1";
            this.Tb_N_SX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Frm2AddFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 411);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(550, 450);
            this.Name = "Frm2AddFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excel2List Tool V1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm2AddFile_FormClosing);
            this.Load += new System.EventHandler(this.Frm2AddFile_Load);
            this.Shown += new System.EventHandler(this.Frm2AddFile_Shown);
            this.GbSSize.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.GbNS.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnBrowser;
        private System.Windows.Forms.TextBox TbPath;
        private System.Windows.Forms.ComboBox CbSheets;
        private System.Windows.Forms.GroupBox GbSSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tb_SY;
        private System.Windows.Forms.TextBox Tb_SX;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Tb_EX;
        private System.Windows.Forms.TextBox Tb_EY;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.GroupBox GbNS;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox Tb_N_NX;
        private System.Windows.Forms.TextBox Tb_N_NY;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox Tb_N_SY;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox Tb_N_SX;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnSS;
        private System.Windows.Forms.Button BtnNS;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}