using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace Pr2txt.Frms
{
    public partial class Frm2AddFile : Form
    {
        //public static FrmMain frm = (FrmMain)Program._Main;
        //public static DataGridView dataGridView1;
        ///static MyExcelLib.ExcelFile EF;
        //static MyExcelLib.ExcelFile2 EF2;

        public Frm2AddFile()
        {
            InitializeComponent();
            //dataGridView1 = frm.dataGridView1;//new System.Windows.Forms.DataGridView();
            //this.tableLayoutPanel3.Controls.Add(dataGridView1, 0, 3);
        }
        private void BtnNext_Click(object sender, EventArgs e)
        {

            if (
                string.IsNullOrEmpty(Tb_SX.Text) ||
                string.IsNullOrEmpty(Tb_SY.Text) ||

                string.IsNullOrEmpty(Tb_EX.Text) ||
                string.IsNullOrEmpty(Tb_EY.Text) ||

                string.IsNullOrEmpty(Tb_N_SX.Text) ||
                string.IsNullOrEmpty(Tb_N_SY.Text) ||

                string.IsNullOrEmpty(Tb_N_NX.Text) ||
                string.IsNullOrEmpty(Tb_N_NY.Text))
            {
                MessageBox.Show("Fills all empty fields");
                return;
            }

            //chk if positions outside of excel data
            if (MyExcelLib.Convert.GetColumnIndex2(Tb_EX.Text) > dataGridView1.ColumnCount)//end X
                goto Error;
            if (MyExcelLib.Convert.GetColumnIndex2(Tb_SX.Text) < 1)//Start X
                goto Error;

            if (MyExcelLib.Convert.GetRowIndex(Tb_EY.Text) > dataGridView1.RowCount)//end Y
                goto Error;
            if (MyExcelLib.Convert.GetRowIndex(Tb_SY.Text) < 1)//start Y
                goto Error;

            StoreMem();
            //save data table
            //next
            Program.ChangeFrmSetting(this);
            this.Hide();
            Program._Form3 = new Frm3AddRols();
            Program._Form3.Show();
            return;
            Error:
            MessageBox.Show("Felld input rong !!", "Error (33)");
        }
        private void BtnBack_Click(object sender, EventArgs e)
        {
            StoreMem();
            //back
            Program.ChangeFrmSetting(this);
            this.Hide();
            Program._Form1 = new Frm1Welcom();
            Program._Form1.Show();
        }
        private void Frm2AddFile_Load(object sender, EventArgs e)
        {
            if (!Program.Debug)
                TbPath.Text = "";
            Program.GetFrmSetting2(this);
         

        }
        private void Frm2AddFile_FormClosing(object sender, FormClosingEventArgs e)
        {
            StoreMem();
            //story DataTable
            //DataTable data = (DataTable)(dataGridView1.DataSource);
            //EF2.FileDS.Tables
            //data.Columns.Remove(...);
            //
            Program._Main.Close();
        }

        private void BtnBrowser_Click(object sender, EventArgs e)
        {
            //get file path
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Workbook|*.xls;*.xlsx", ValidateNames = true, Multiselect=false })
            //using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Workbook|*.xls", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    LoadFile(TbPath.Text = ofd.FileName, true);
                }
            }
        }
        private void LoadFile(string FileName, bool SelectFirstSheet)
        {
            try
            {
                this.Text = "Excel2List Tool V1.0 (Please wait...)";
                //reset all
                ResetDataGrid();
                CbSheets.Items.Clear();
                //

                //open file
                ///EF = new MyExcelLib.ExcelFile(FileName);
                Program.EF2 = new MyExcelLib.ExcelFile2(FileName);
                //
                //UnMerge All Cells
                Program.EF2.UnMergeAndDublDataFile();
                //save
                Program.EF2.Save();
                //DataSet
                Program.EF2.ReadAll2DataSet();
                //Delet tmp File
                Program.EF2.DeleteTmpFile();

                //get sheets name
                ///if (EF.result.Tables.Count < 1)
                //if (EF2.excel.Sheets.Count < 1)
                //throw new Exception("Open File Failed");

                ///foreach (DataTable dt in EF.result.Tables)
                ///     CbSheets.Items.Add(dt.TableName);
                foreach (string n in Program.EF2.SNames)
                    CbSheets.Items.Add(n);
                //

                TbPath.Text = FileName;

                //select first sheet
                if (SelectFirstSheet)
                    if (CbSheets.Items.Count >= 1)
                        CbSheets.Text = CbSheets.Items[0].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error at Open File !!! (1)");
                if(Program.Debug)
                    MessageBox.Show(ex.ToString());
            }
            this.Text = "Excel2List Tool V1.0";

            if (Program.Debug)
                BtnNext_Click(null, null);
        }
        private void CbSheets_SelectedIndexChanged(object sender, EventArgs e)
        {
            Print2(CbSheets.SelectedIndex);
        }

        /*private void Print(int indx)
        {
            if (indx >= EF.result.Tables.Count)
            {
                MessageBox.Show("Error at sheet count ");
                return;
            }
            CbSheets.Text = CbSheets.Items[indx].ToString();
            dataGridView1.DataSource = EF.result.Tables[indx];
            int i = 0, j = 0;
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
                column.HeaderText = MyExcelLib.Convert.GetColumnName(++i);
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.HeaderCell.Value = MyExcelLib.Convert.GetRowName(++j);
            }
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.AllowUserToResizeColumns = true;

            dataGridView1.Refresh();
            //enable Control
            ResetDataGrid(false);
        }
        */
        private void Print2(int indx)
        {
            if (indx >= Program.EF2.SNames.Count)
            {
                MessageBox.Show("Error at sheet count ","Error (2)");
                return;
            }
            //CbSheets.Text = CbSheets.Items[indx].ToString();
            //EF2.OpenSheet(++indx);
            
            dataGridView1.DataSource = Program.EF2.FileDS.Tables[indx];// EF2.ws;

            int i = 0, j = 0;
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
                column.HeaderText = MyExcelLib.Convert.GetColumnName2(++i);//useless//coz the name set before
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.HeaderCell.Value = MyExcelLib.Convert.GetRowName(++j);//(++j).ToString();//the same
            }
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.AllowUserToResizeColumns = true;

            dataGridView1.Refresh();
            //enable Control
            ResetDataGrid(false);
        }

        private void WS_SizeChanged(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            //chk if positions outside of excel data
            if (MyExcelLib.Convert.GetColumnIndex2(Tb_EX.Text) > dataGridView1.ColumnCount)//end X
                goto Error;
            if (MyExcelLib.Convert.GetColumnIndex2(Tb_SX.Text) < 1)//Start X
                goto Error;

            if (MyExcelLib.Convert.GetRowIndex(Tb_EY.Text) > dataGridView1.RowCount)//end Y
                goto Error;
            if (MyExcelLib.Convert.GetRowIndex(Tb_SY.Text) < 1)//start Y
                goto Error; 

            //All:
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridView1.RowCount; j++)
                {
                    dataGridView1.Rows[j].Cells[i].Style = Program.Outstyle;
                }
            }

            //selected calls:
            for (int j = MyExcelLib.Convert.GetRowIndex(Tb_SY.Text)-1; j < MyExcelLib.Convert.GetRowIndex(Tb_EY.Text); j++)
            {
                for (int i = MyExcelLib.Convert.GetColumnIndex2(Tb_SX.Text)-1; i < MyExcelLib.Convert.GetColumnIndex2(Tb_EX.Text); i++)
                {
                    dataGridView1.Rows[j].Cells[i].Style = Program.Selectedstyle;
                }
            }

            StoreMem();
            return;
            Error:
            MessageBox.Show("Felld input rong !!", "Error (3)");            
        }        
        private void NextStepChanged(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            //chk start point
            if (MyExcelLib.Convert.GetColumnIndex2(Tb_SX.Text) < 1)//Start X
                goto Error;
            if (MyExcelLib.Convert.GetRowIndex(Tb_SY.Text) < 1)//start Y
                goto Error;

            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridView1.RowCount; j++)
                {
                    dataGridView1.Rows[j].Cells[i].Style = Program.Selectedstyle;
                }
            }

            try
            {
                string tmp;
                string tmpTb_SX = MyExcelLib.Convert.GetColumnIndex2(Tb_SX.Text).ToString();
                string tmpTb_SY = MyExcelLib.Convert.GetRowIndex(Tb_SY.Text).ToString();

                tmp = Tb_N_SX.Text.ToUpper();
                tmp = tmp.Replace("X", tmpTb_SX);
                tmp = tmp.Replace("Y", tmpTb_SY);
                tmp = "(" + tmp + ")*1";
                if (!MathsEvaluator.TryParse(tmp, out decimal N_SX))
                    throw new Exception("Operation not valid");

                tmp = Tb_N_SY.Text.ToUpper();
                tmp = tmp.Replace("X", tmpTb_SX);
                tmp = tmp.Replace("Y", tmpTb_SY);
                tmp = "(" + tmp + ")*1";
                if (!MathsEvaluator.TryParse(tmp, out decimal N_SY))
                    throw new Exception("Operation not valid");

                tmp = Tb_N_NX.Text.ToUpper();
                tmp = tmp.Replace("X", tmpTb_SX);
                tmp = tmp.Replace("Y", tmpTb_SY);
                tmp = "(" + tmp + ")*1";
                if (!MathsEvaluator.TryParse(tmp, out decimal N_NX))
                    throw new Exception("Operation not valid");

                tmp = Tb_N_NY.Text.ToUpper();
                tmp = tmp.Replace("X", tmpTb_SX);
                tmp = tmp.Replace("Y", tmpTb_SY);
                tmp = "(" + tmp + ")*1";
                if (!MathsEvaluator.TryParse(tmp, out decimal N_NY))
                    throw new Exception("Operation not valid");
                //point(A ->tb_SX ,1 ->TB-SY)


                //dataGridView1.Rows[MyExcelLib.Convert.GetRowIndex(Tb_SY.Text) - 1].Cells[MyExcelLib.Convert.GetColumnIndex(Tb_SX.Text) - 1].Style = Startstyle;
                dataGridView1[MyExcelLib.Convert.GetColumnIndex2(Tb_SX.Text)-1, Convert.ToInt16(Tb_SY.Text)-1 ].Style = Program.Startstyle;

                //dataGridView1[Convert.ToInt16(N_SX - 1), MyExcelLib.Convert.GetRowIndex(N_SY.ToString()) - 1].Style = NextSstyle;
                dataGridView1[Convert.ToInt16(N_SX) - 1, Convert.ToInt16(N_SY) - 1].Style = Program.NextSstyle;

                //dataGridView1[Convert.ToInt16(N_NX - 1), MyExcelLib.Convert.GetRowIndex(N_NY.ToString()) - 1].Style = NextNstyle;
                dataGridView1[Convert.ToInt16(N_NX) - 1, Convert.ToInt16(N_NY) - 1].Style = Program.NextNstyle;
                StoreMem();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error at select start point and next of it:\r\n"+ex.Message);
                if (Program.Debug)
                    MessageBox.Show(ex.ToString());
            }

            return;
            Error:
            MessageBox.Show("Felld input rong !!", "Error (4)");
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ResetDataGrid();
            CbSheets.Items.Clear();
        }
        private void ResetDataGrid(bool disable = true)
        {
            if (disable)
            {
                ///if (EF != null)
                if (Program.EF2 != null)
                {
                    ///if (EF.result != null)
                    ///    EF.result.Clear();
                    ///EF = null;
                    Program.EF2.Close();
                    Program.EF2 = null;
                    TbPath.Text = "";
                }
                Load_Mem();
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                //CbSheets.Items.Clear();
                //TbPath.Text = "";
            }
            GbNS.Enabled = !disable;
            GbSSize.Enabled = !disable;
            BtnNext.Enabled = !disable;
        }

        private void StoreMem()
        {
            Program.Mem_SX = Tb_SX.Text;
            Program.Mem_SY = Tb_SY.Text;

            Program.Mem_EX = Tb_EX.Text;
            Program.Mem_EY = Tb_EY.Text;

            Program.Mem_N_SX = Tb_N_SX.Text;
            Program.Mem_N_SY = Tb_N_SY.Text;

            Program.Mem_N_NX = Tb_N_NX.Text;
            Program.Mem_N_NY = Tb_N_NY.Text;
            dataGridView1.Update();
            //Program.DGV = dataGridView1;
            Program.FilePath = TbPath.Text;
            Program.SelectedSheetIndex = CbSheets.SelectedIndex;
        }
        private void Load_Mem()
        {
            Tb_SX.Text = Program.Mem_SX;
            Tb_SY.Text = Program.Mem_SY;

            Tb_EX.Text = Program.Mem_EX;
            Tb_EY.Text = Program.Mem_EY;

            Tb_N_SX.Text = Program.Mem_N_SX;
            Tb_N_SY.Text = Program.Mem_N_SY;

            Tb_N_NX.Text = Program.Mem_N_NX;
            Tb_N_NY.Text = Program.Mem_N_NY;

            //if (Program.DGV != null)
            //    dataGridView1 = Program.DGV;

            if (Program.FilePath != null)
                TbPath.Text = Program.FilePath;

        }

        private void Frm2AddFile_Shown(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(Program.Mem_EX))
            StoreMem();
            Load_Mem();
            if (Program.EF2 != null)
            {
                ResetDataGrid(false);
                CbSheets.Items.Clear();
                foreach (string n in Program.EF2.SNames)
                    CbSheets.Items.Add(n);
                CbSheets.SelectedIndex = Program.SelectedSheetIndex;
                //LoadFile(TbPath.Text, true);
            }
            else if (!Program.Debug)
                TbPath.Text = "";

            if (!string.IsNullOrEmpty(TbPath.Text))
                    LoadFile(TbPath.Text, true);
                else
                    TbPath.Text = "";
        }
        string Message = @"* Operation ( Y+2 || 0/0 || ... )";

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                label1.Text = Message + "\r\nColumn(X)= " + (dataGridView1.SelectedCells[0].ColumnIndex + 1) +
                    " ,Row(Y)=" + (dataGridView1.SelectedCells[0].RowIndex + 1);
            }
            catch
            {
                label1.Text = Message;
            }
        }
    }
  
}
