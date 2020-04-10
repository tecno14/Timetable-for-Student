namespace Timetable_Gen
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.wb = new System.Windows.Forms.WebBrowser();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnReset = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CbSheets = new System.Windows.Forms.ComboBox();
            this.TbPath = new System.Windows.Forms.TextBox();
            this.BtnBrowser = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.DGV_RolesHeader = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_ResetAll = new System.Windows.Forms.Button();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DGV_Roles = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Btn_Dwn_Period = new System.Windows.Forms.Button();
            this.Btn_Up_Period = new System.Windows.Forms.Button();
            this.Btn_Dwn_Days = new System.Windows.Forms.Button();
            this.Btn_Up_Days = new System.Windows.Forms.Button();
            this.LB_Period = new System.Windows.Forms.ListBox();
            this.LB_Day = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_Table = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_Back = new System.Windows.Forms.Button();
            this.Lb_Info = new System.Windows.Forms.Label();
            this.Btn_Next = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_RolesHeader)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Roles)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Table)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(653, 377);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabStop = false;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.TabControl1_Selecting);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.wb);
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(645, 348);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Welecom";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // wb
            // 
            this.wb.Location = new System.Drawing.Point(16, 280);
            this.wb.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb.Name = "wb";
            this.wb.Size = new System.Drawing.Size(101, 62);
            this.wb.TabIndex = 20;
            this.wb.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(25, 20);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(20);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(466, 305);
            this.richTextBox1.TabIndex = 19;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(645, 348);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Read List";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnReset);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.CbSheets);
            this.groupBox1.Controls.Add(this.TbPath);
            this.groupBox1.Controls.Add(this.BtnBrowser);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(639, 342);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Path";
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(444, 31);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(65, 23);
            this.BtnReset.TabIndex = 27;
            this.BtnReset.Text = "Reset All";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 69);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(630, 267);
            this.dataGridView1.TabIndex = 28;
            // 
            // CbSheets
            // 
            this.CbSheets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbSheets.FormattingEnabled = true;
            this.CbSheets.Location = new System.Drawing.Point(343, 32);
            this.CbSheets.Name = "CbSheets";
            this.CbSheets.Size = new System.Drawing.Size(94, 21);
            this.CbSheets.TabIndex = 26;
            this.CbSheets.SelectedIndexChanged += new System.EventHandler(this.CbSheets_SelectedIndexChanged);
            // 
            // TbPath
            // 
            this.TbPath.Location = new System.Drawing.Point(42, 32);
            this.TbPath.Name = "TbPath";
            this.TbPath.Size = new System.Drawing.Size(295, 20);
            this.TbPath.TabIndex = 24;
            // 
            // BtnBrowser
            // 
            this.BtnBrowser.Location = new System.Drawing.Point(8, 31);
            this.BtnBrowser.Name = "BtnBrowser";
            this.BtnBrowser.Size = new System.Drawing.Size(29, 23);
            this.BtnBrowser.TabIndex = 25;
            this.BtnBrowser.Text = "...";
            this.BtnBrowser.UseVisualStyleBackColor = true;
            this.BtnBrowser.Click += new System.EventHandler(this.BtnBrowser_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.splitContainer1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(645, 348);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Roles";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Size = new System.Drawing.Size(639, 342);
            this.splitContainer1.SplitterDistance = 92;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 34;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.DGV_RolesHeader);
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(637, 90);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "matching this conditions :";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(317, 70);
            this.button2.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "LoadRoles(Debug)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DGV_RolesHeader
            // 
            this.DGV_RolesHeader.AllowUserToAddRows = false;
            this.DGV_RolesHeader.AllowUserToDeleteRows = false;
            this.DGV_RolesHeader.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGV_RolesHeader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_RolesHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_RolesHeader.Location = new System.Drawing.Point(3, 16);
            this.DGV_RolesHeader.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
            this.DGV_RolesHeader.Name = "DGV_RolesHeader";
            this.DGV_RolesHeader.RowHeadersVisible = false;
            this.DGV_RolesHeader.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_RolesHeader.Size = new System.Drawing.Size(550, 71);
            this.DGV_RolesHeader.TabIndex = 29;
            this.DGV_RolesHeader.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_RolesHeader_CellValueChanged);
            this.DGV_RolesHeader.Click += new System.EventHandler(this.DGV_RolesHeader_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.Btn_ResetAll, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Btn_Add, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(553, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(81, 71);
            this.tableLayoutPanel1.TabIndex = 32;
            // 
            // Btn_ResetAll
            // 
            this.Btn_ResetAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_ResetAll.Location = new System.Drawing.Point(3, 45);
            this.Btn_ResetAll.Name = "Btn_ResetAll";
            this.Btn_ResetAll.Size = new System.Drawing.Size(75, 23);
            this.Btn_ResetAll.TabIndex = 30;
            this.Btn_ResetAll.Text = "Reset All";
            this.Btn_ResetAll.UseVisualStyleBackColor = true;
            this.Btn_ResetAll.Click += new System.EventHandler(this.Btn_ResetAll_Click);
            // 
            // Btn_Add
            // 
            this.Btn_Add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Add.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.Btn_Add.Location = new System.Drawing.Point(3, 3);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(75, 36);
            this.Btn_Add.TabIndex = 31;
            this.Btn_Add.Text = "Add\r\n";
            this.Btn_Add.UseVisualStyleBackColor = true;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DGV_Roles);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(637, 242);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "All conditions :";
            // 
            // DGV_Roles
            // 
            this.DGV_Roles.AllowUserToAddRows = false;
            this.DGV_Roles.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGV_Roles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Roles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.DGV_Roles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Roles.Location = new System.Drawing.Point(3, 16);
            this.DGV_Roles.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
            this.DGV_Roles.MultiSelect = false;
            this.DGV_Roles.Name = "DGV_Roles";
            this.DGV_Roles.ReadOnly = true;
            this.DGV_Roles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Roles.Size = new System.Drawing.Size(631, 223);
            this.DGV_Roles.TabIndex = 29;
            this.DGV_Roles.SelectionChanged += new System.EventHandler(this.DGV_Roles_SelectionChanged);
            this.DGV_Roles.DoubleClick += new System.EventHandler(this.DGV_Roles_DoubleClick);
            // 
            // Column1
            // 
            this.Column1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Column1.HeaderText = "Column1";
            this.Column1.Items.AddRange(new object[] {
            "1",
            "1",
            "2",
            "3",
            "4"});
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Sorted = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox4);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(645, 348);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Get Resault";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.listBox1);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.DGV_Table);
            this.groupBox4.Controls.Add(this.comboBox1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(639, 342);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(9, 19);
            this.button3.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 28);
            this.button3.TabIndex = 34;
            this.button3.Text = "Get All";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(9, 51);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(148, 283);
            this.richTextBox2.TabIndex = 33;
            this.richTextBox2.Text = "";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(20, 8);
            this.button1.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 39);
            this.button1.TabIndex = 17;
            this.button1.Text = "Find";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Btn_Dwn_Period);
            this.groupBox5.Controls.Add(this.Btn_Up_Period);
            this.groupBox5.Controls.Add(this.Btn_Dwn_Days);
            this.groupBox5.Controls.Add(this.Btn_Up_Days);
            this.groupBox5.Controls.Add(this.LB_Period);
            this.groupBox5.Controls.Add(this.LB_Day);
            this.groupBox5.Location = new System.Drawing.Point(3, 45);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(196, 291);
            this.groupBox5.TabIndex = 32;
            this.groupBox5.TabStop = false;
            // 
            // Btn_Dwn_Period
            // 
            this.Btn_Dwn_Period.Location = new System.Drawing.Point(142, 209);
            this.Btn_Dwn_Period.Name = "Btn_Dwn_Period";
            this.Btn_Dwn_Period.Size = new System.Drawing.Size(32, 23);
            this.Btn_Dwn_Period.TabIndex = 22;
            this.Btn_Dwn_Period.Text = "Dwn";
            this.Btn_Dwn_Period.UseVisualStyleBackColor = true;
            this.Btn_Dwn_Period.Click += new System.EventHandler(this.Btn_Dwn_Period_Click);
            // 
            // Btn_Up_Period
            // 
            this.Btn_Up_Period.Location = new System.Drawing.Point(142, 166);
            this.Btn_Up_Period.Name = "Btn_Up_Period";
            this.Btn_Up_Period.Size = new System.Drawing.Size(32, 23);
            this.Btn_Up_Period.TabIndex = 21;
            this.Btn_Up_Period.Text = "Up";
            this.Btn_Up_Period.UseVisualStyleBackColor = true;
            this.Btn_Up_Period.Click += new System.EventHandler(this.Btn_Up_Period_Click);
            // 
            // Btn_Dwn_Days
            // 
            this.Btn_Dwn_Days.Location = new System.Drawing.Point(142, 84);
            this.Btn_Dwn_Days.Name = "Btn_Dwn_Days";
            this.Btn_Dwn_Days.Size = new System.Drawing.Size(32, 23);
            this.Btn_Dwn_Days.TabIndex = 20;
            this.Btn_Dwn_Days.Text = "Dwn";
            this.Btn_Dwn_Days.UseVisualStyleBackColor = true;
            this.Btn_Dwn_Days.Click += new System.EventHandler(this.Btn_Dwn_Days_Click);
            // 
            // Btn_Up_Days
            // 
            this.Btn_Up_Days.Location = new System.Drawing.Point(142, 41);
            this.Btn_Up_Days.Name = "Btn_Up_Days";
            this.Btn_Up_Days.Size = new System.Drawing.Size(32, 23);
            this.Btn_Up_Days.TabIndex = 18;
            this.Btn_Up_Days.Text = "Up";
            this.Btn_Up_Days.UseVisualStyleBackColor = true;
            this.Btn_Up_Days.Click += new System.EventHandler(this.Btn_Up_Days_Click);
            // 
            // LB_Period
            // 
            this.LB_Period.FormattingEnabled = true;
            this.LB_Period.Location = new System.Drawing.Point(10, 143);
            this.LB_Period.Name = "LB_Period";
            this.LB_Period.Size = new System.Drawing.Size(116, 108);
            this.LB_Period.TabIndex = 19;
            // 
            // LB_Day
            // 
            this.LB_Day.FormattingEnabled = true;
            this.LB_Day.Location = new System.Drawing.Point(10, 19);
            this.LB_Day.Name = "LB_Day";
            this.LB_Day.Size = new System.Drawing.Size(116, 108);
            this.LB_Day.TabIndex = 18;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(205, 266);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(62, 30);
            this.listBox1.TabIndex = 30;
            this.listBox1.Visible = false;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "View Table";
            // 
            // DGV_Table
            // 
            this.DGV_Table.AllowUserToAddRows = false;
            this.DGV_Table.AllowUserToDeleteRows = false;
            this.DGV_Table.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_Table.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGV_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Table.Location = new System.Drawing.Point(205, 19);
            this.DGV_Table.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
            this.DGV_Table.Name = "DGV_Table";
            this.DGV_Table.ReadOnly = true;
            this.DGV_Table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Table.Size = new System.Drawing.Size(271, 277);
            this.DGV_Table.TabIndex = 28;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(308, 310);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 21);
            this.comboBox1.TabIndex = 26;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.Btn_Back, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Lb_Info, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.Btn_Next, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 377);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(653, 34);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // Btn_Back
            // 
            this.Btn_Back.Location = new System.Drawing.Point(20, 3);
            this.Btn_Back.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(75, 23);
            this.Btn_Back.TabIndex = 16;
            this.Btn_Back.Text = "< Back";
            this.Btn_Back.UseVisualStyleBackColor = true;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // Lb_Info
            // 
            this.Lb_Info.AutoSize = true;
            this.Lb_Info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lb_Info.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Lb_Info.Location = new System.Drawing.Point(101, 0);
            this.Lb_Info.Name = "Lb_Info";
            this.Lb_Info.Size = new System.Drawing.Size(451, 29);
            this.Lb_Info.TabIndex = 15;
            this.Lb_Info.Text = "TECNO2019 - wael  \r\nwael.had.sy@gmail.com";
            this.Lb_Info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lb_Info.Click += new System.EventHandler(this.Lb_Info_Click);
            // 
            // Btn_Next
            // 
            this.Btn_Next.Location = new System.Drawing.Point(558, 3);
            this.Btn_Next.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.Btn_Next.Name = "Btn_Next";
            this.Btn_Next.Size = new System.Drawing.Size(75, 23);
            this.Btn_Next.TabIndex = 17;
            this.Btn_Next.Text = "Next >";
            this.Btn_Next.UseVisualStyleBackColor = true;
            this.Btn_Next.Click += new System.EventHandler(this.Btn_Next_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.button3);
            this.groupBox6.Controls.Add(this.richTextBox2);
            this.groupBox6.Location = new System.Drawing.Point(485, 9);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(151, 327);
            this.groupBox6.TabIndex = 35;
            this.groupBox6.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 411);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.MinimumSize = new System.Drawing.Size(550, 450);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timetable_Gen v1.1 Alpha";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_RolesHeader)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Roles)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Table)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.Label Lb_Info;
        private System.Windows.Forms.Button Btn_Next;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.ComboBox CbSheets;
        private System.Windows.Forms.TextBox TbPath;
        private System.Windows.Forms.Button BtnBrowser;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DGV_RolesHeader;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView DGV_Roles;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView DGV_Table;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Btn_ResetAll;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button Btn_Dwn_Period;
        private System.Windows.Forms.Button Btn_Up_Period;
        private System.Windows.Forms.Button Btn_Dwn_Days;
        private System.Windows.Forms.Button Btn_Up_Days;
        private System.Windows.Forms.ListBox LB_Period;
        private System.Windows.Forms.ListBox LB_Day;
        private System.Windows.Forms.WebBrowser wb;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox6;
    }
}

