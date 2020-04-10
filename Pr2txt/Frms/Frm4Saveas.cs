using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Pr2txt.Frms
{
    public partial class Frm4Saveas : Form
    {
        int Start_X;
        int Start_Y;
        int End_X;
        int End_Y;

        public Frm4Saveas()
        {
            InitializeComponent();
        }

        private void Frm4Saveas_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program._Main.Close();
        }

        private void Frm4Saveas_Load(object sender, EventArgs e)
        {
            Program.GetFrmSetting2(this);
        }

        private void RowID()
        {
            int k = 1;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.HeaderCell.Value = (k++).ToString();
            }
        }

        private void Frm4Saveas_Resize(object sender, EventArgs e)
        {
            Program.ChangeFrmSetting(this);
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            //back
            Program.ChangeFrmSetting(this);
            this.Hide();
            Program._Form3 = new Frm3AddRols();
            Program._Form3.Show();
        }

        private void BtnSaveAs_Click(object sender, EventArgs e)
        {
            try
            {
                //new  file dir 
                //using (SaveFileDialog ofd = new SaveFileDialog() { Filter = "Excel Workbook (*.xlsx)|*.xlsx|Excel 97-2003 Workbook (*.xls)|*.xls", ValidateNames = true })
                using (SaveFileDialog ofd = new SaveFileDialog() { Filter = "Excel Workbook (*.xlsx)|*.xlsx", ValidateNames = true })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        dataGridView1.Update();
                        MyExcelLib.ExcelFile2 NFile = new MyExcelLib.ExcelFile2();
                        NFile.CreateNewFile();
                        NFile.CreateNewSheet();
                        NFile.SaveAs(ofd.FileName);
                        
                        //Titles
                        for (int i = 0; i < Program.Roles.Count; i++)
                            NFile.WriteToCell(i, 0, Program.Roles[i].Name);

                        //copy
                        for (int i = 0; i < dataGridView1.Columns.Count; i++)
                            for (int j = 0; j < dataGridView1.Rows.Count; j++)
                                NFile.WriteToCell(i, j + 1, dataGridView1.Rows[j].Cells[i].Value.ToString());
                        //save
                        NFile.Save();
                        NFile.Close();
                        //success msg
                        MessageBox.Show("Done", "Done (ツ)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error 4.1");
            }
        }



        void GenerateTable()
        {
            dataGridView1.Visible = false;
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                //add columns
                for (int k = 0; k < Program.Roles.Count; k++)
                    dataGridView1.Columns.Add(k.ToString(), Program.Roles[k].Name);

                int i = Start_X;
                int j = Start_Y;

                while (IsCellinside(i, j))
                {
                    while (IsCellinside(i, j))
                    {
                        ApplyRoles(i, j);
                        i = CalcCell(Program.Mem_N_SX, i, j);
                        j = CalcCell(Program.Mem_N_SY, i, j);
                    }
                    i = Start_X = CalcCell(Program.Mem_N_NX, Start_X, Start_Y);
                    j = Start_Y = CalcCell(Program.Mem_N_NY, Start_X, Start_Y);
                }


                /*
                //calc next cell on same line(   i,j => nextStepS(i), nextStepS(j)    )
                //if the cell out the PR
                //{
                //calc next cells at next line
                //start cell ++ step line( i,j = start_X,strat_Y => nextStepN() )
                //}
                //----------------------------            
                 * 1- calc next cell on same line:
                 * i,j => nextStepS(i), nextStepS(j)
                 * 
                 * 2- calc next cells at next line:
                 * start_X,strat_Y => nextStepN()            
                //----------------------------
               */
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message, "Error 4");
                if (Program.Debug)
                    MessageBox.Show(ex.ToString());
            }
            dataGridView1.Visible = true;
        }

        private bool IsCellinside(int i, int j)
        {
            if (i >= Convert.ToInt16(Program.Mem_EX))//Program.EF2.FileDS.Tables[Program.SelectedSheetIndex].Columns.Count)//end X
                return false;
            if (i < 0)//Start X
                return false;

            if (j >= Convert.ToInt16(Program.Mem_EY))//Program.EF2.FileDS.Tables[Program.SelectedSheetIndex].Rows.Count)//end Y
                return false;
            if (j < 0)//start Y
                return false;
            return true;
        }

        private void ApplyRoles(int i, int j)
        {
            //if cell empty :return
            string CellValue = Program.EF2.FileDS.Tables[Program.SelectedSheetIndex].Rows[j][i].ToString();
            if (string.IsNullOrEmpty(CellValue))
                return;

            string[] NewRow = new string[Program.Roles.Count];
            //NewRow[0] = CellValue;
            for (int k = 0; k < Program.Roles.Count; k++)// Role R in Program.Roles)
            {
                if (!Program.Roles[k].UseDelRegx)
                    NewRow[k] = Program.EF2.FileDS.Tables[Program.SelectedSheetIndex].Rows[CalcCell(Program.Roles[k].Row, i, j)][CalcCell(Program.Roles[k].Column, i, j)].ToString();
                else
                {
                    string tmp = Program.EF2.FileDS.Tables[Program.SelectedSheetIndex].Rows[CalcCell(Program.Roles[k].Row, i, j)][CalcCell(Program.Roles[k].Column, i, j)].ToString();
                    Regex rx = new Regex(Program.Roles[k].DelReg, RegexOptions.Compiled | RegexOptions.IgnoreCase);
                    if (!string.IsNullOrEmpty(rx.Match(tmp).Value))
                        tmp = tmp.Replace(rx.Match(tmp).Value, "");
                    NewRow[k] = tmp;//(string.IsNullOrEmpty(tmp) ? "(null)" : tmp);//if empty add "-"
                }
            }
            dataGridView1.Rows.Add(NewRow);
            //dataGridView1.Rows[dataGridView1.Rows.Count - 1].HeaderCell.Value = dataGridView1.Rows.Count.ToString();
        }
        private int CalcCell(string Op,int i,int j)
        {
            i++;j++;
            Op = Op.ToUpper();
            Op = Op.Replace("X", i.ToString());
            Op = Op.Replace("Y", j.ToString());
            Op = "(" + Op + ")*1";
            if (!MathsEvaluator.TryParse(Op, out decimal Res))
                throw new Exception("Operation not valid");
            return Convert.ToInt16(Res - 1);
        }

        private void Frm4Saveas_Shown(object sender, EventArgs e)
        {
            Start_X = MyExcelLib.Convert.GetColumnIndex2(Program.Mem_SX) - 1;
            Start_Y = MyExcelLib.Convert.GetRowIndex(Program.Mem_SY) - 1;
            End_X = MyExcelLib.Convert.GetRowIndex(Program.Mem_EX) - 1;
            End_Y = MyExcelLib.Convert.GetRowIndex(Program.Mem_EY) - 1;

            //Generate the Final Table
            GenerateTable();
            //RowID();
            label1.Text = dataGridView1.Rows.Count.ToString();
        }

        private void DataGridView1_RowsChanged(object sender, object e)
        {
            label1.Text = dataGridView1.Rows.Count.ToString();
        }


    }
}
