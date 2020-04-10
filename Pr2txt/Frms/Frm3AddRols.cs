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
    public partial class Frm3AddRols : Form
    {
        string Save = "Save";
        string Add = "Add";
        string NameNoRpeat = "RoleName";
        public Frm3AddRols()
        {
            InitializeComponent();
        }
        private void Frm3AddRols_Load(object sender, EventArgs e)
        {
            Program.GetFrmSetting2(this);

        }
        private void Frm3AddRols_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program._Main.Close();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            SaveRoles();
            //back
            Program.ChangeFrmSetting(this);
            this.Hide();
            Program._Form2 = new Frm2AddFile();
            Program._Form2.Show();
        }
        private void PrintSheet()
        {
            dataGridView2.Visible = false;
            //print table
            dataGridView2.DataSource = Program.EF2.FileDS.Tables[Program.SelectedSheetIndex];
            int i = 0, j = 0;
            foreach (DataGridViewColumn column in dataGridView2.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
                column.HeaderText = MyExcelLib.Convert.GetColumnName2(++i);//useless//coz the name set before
            }
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                row.HeaderCell.Value = MyExcelLib.Convert.GetRowName(++j);//(++j).ToString();//the same
            }
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView2.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView2.AllowUserToResizeColumns = true;

            dataGridView2.Refresh();
            //
            dataGridView2.Visible = true;
        }
        private void StartAndSeletedCells()
        {
            dataGridView2.ClearSelection();
            string tmp;
            string tmpTb_SX = MyExcelLib.Convert.GetColumnIndex2(Program.Mem_SX).ToString();
            string tmpTb_SY = MyExcelLib.Convert.GetRowIndex(Program.Mem_SY).ToString();

            //All
            for (int i = 0; i < dataGridView2.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridView2.RowCount; j++)
                {
                    dataGridView2.Rows[j].Cells[i].Style = Program.Outstyle;
                }
            }
            //selected cells
            for (int j = MyExcelLib.Convert.GetRowIndex(Program.Mem_SY) - 1; j < MyExcelLib.Convert.GetRowIndex(Program.Mem_EY); j++)
            {
                for (int i = MyExcelLib.Convert.GetColumnIndex2(Program.Mem_SX) - 1; i < MyExcelLib.Convert.GetColumnIndex2(Program.Mem_EX); i++)
                {
                    dataGridView2.Rows[j].Cells[i].Style = Program.Selectedstyle;
                }
            }
            try
            {             
                tmp = Program.Mem_N_SX.ToUpper();
                tmp = tmp.Replace("X", tmpTb_SX);
                tmp = tmp.Replace("Y", tmpTb_SY);
                tmp = "(" + tmp + ")*1";
                if (!MathsEvaluator.TryParse(tmp, out decimal N_SX))
                    throw new Exception("Operation not valid");

                tmp = Program.Mem_N_SY.ToUpper();
                tmp = tmp.Replace("X", tmpTb_SX);
                tmp = tmp.Replace("Y", tmpTb_SY);
                tmp = "(" + tmp + ")*1";
                if (!MathsEvaluator.TryParse(tmp, out decimal N_SY))
                    throw new Exception("Operation not valid");

                tmp = Program.Mem_N_NX.ToUpper();
                tmp = tmp.Replace("X", tmpTb_SX);
                tmp = tmp.Replace("Y", tmpTb_SY);
                tmp = "(" + tmp + ")*1";
                if (!MathsEvaluator.TryParse(tmp, out decimal N_NX))
                    throw new Exception("Operation not valid");

                tmp = Program.Mem_N_NY.ToUpper();
                tmp = tmp.Replace("X", tmpTb_SX);
                tmp = tmp.Replace("Y", tmpTb_SY);
                tmp = "(" + tmp + ")*1";
                if (!MathsEvaluator.TryParse(tmp, out decimal N_NY))
                    throw new Exception("Operation not valid");

                dataGridView2[MyExcelLib.Convert.GetColumnIndex2(Program.Mem_SX) - 1, Convert.ToInt16(Program.Mem_SY) - 1].Style = Program.Startstyle;

                dataGridView2[Convert.ToInt16(N_SX) - 1, Convert.ToInt16(N_SY) - 1].Style = Program.NextSstyle;

                dataGridView2[Convert.ToInt16(N_NX) - 1, Convert.ToInt16(N_NY) - 1].Style = Program.NextNstyle;

            }
            catch (Exception ex)
            {
                MessageBox.Show("error at select start point and next of it:\r\n" + ex.Message,"Error (2.1)");
                if (Program.Debug)
                    MessageBox.Show(ex.ToString());
            }

        }
        private void PrintRoles()
        {
            Lv_Roles.Items.Clear();
            foreach (Role R in Program.Roles)
                Lv_Roles.Items.Add(new ListViewItem(new string[] {
                    R.Name, R.Column, R.Row, (R.UseDelRegx ? R.DelReg : "")
                }));          
        }

        private void SaveRoles()
        {
            Program.Roles = new List<Role>();
            foreach (ListViewItem item in Lv_Roles.Items)
                Program.Roles.Add(new Role(
                    item.SubItems[0].Text, item.SubItems[1].Text,
                    item.SubItems[2].Text,
                    (string.IsNullOrEmpty(item.SubItems[3].Text) ? false : true),
                    (string.IsNullOrEmpty(item.SubItems[3].Text) ? "" : item.SubItems[3].Text)
                    ));
        }
        private void Cb_DelReg_CheckedChanged(object sender, EventArgs e)
        {
            Tb_DelReg.Enabled = Cb_DelReg.Checked;
        }
        int SelectedRolIndx = -1;
        private void Lv_Roles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Lv_Roles.SelectedItems.Count==1)
            {
                SelectedRolIndx = Lv_Roles.SelectedItems[0].Index;
                EditRol();
            }
            else
            {
                SelectedRolIndx = -1;
                SelectNullRol();
            }
        }

        void SelectNullRol()
        {
            BtnRolAction.Text = Add;
            Gb_RolProp.Enabled = false;
            BtnDelRol.Enabled = false;

            //Tb_RolName.Text = "NameNoRpeat";
            //Tb_RolRegX.Text = "X";
            //Tb_RolRegY.Text = "Y";
            //Cb_DelReg.Checked = false;
            //Tb_DelReg.Text = "[^,]*,";

        }
        void EditRol(bool ExistRolSelected = true)
        {
            BtnRolAction.Text = Save;
            Gb_RolProp.Enabled = true;
            BtnDelRol.Enabled = true;

            Tb_RolName.Text = NameNoRpeat;
            Tb_RolRegX.Text = "X";
            Tb_RolRegY.Text = "Y";
            Cb_DelReg.Checked = false;
            Tb_DelReg.Text = "[^,]*,";

            if (ExistRolSelected)
            {
                Tb_RolName.Text = Lv_Roles.SelectedItems[0].SubItems[0].Text;
                Tb_RolRegX.Text = Lv_Roles.SelectedItems[0].SubItems[1].Text;
                Tb_RolRegY.Text = Lv_Roles.SelectedItems[0].SubItems[2].Text;
                if (string.IsNullOrEmpty(Lv_Roles.SelectedItems[0].SubItems[3].Text))
                {
                    Cb_DelReg.Checked = false;
                    Tb_DelReg.Text = "";
                }
                else
                {
                    Cb_DelReg.Checked = true;
                    Tb_DelReg.Text = Lv_Roles.SelectedItems[0].SubItems[3].Text;
                }
            }
            //for later version
            if (CbDrowCells.Checked)
            {
                //default Cells Colors
                StartAndSeletedCells();
                //color Cells
                try
                {
                    //calc cells position and drow it
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error 3.1 Drow Role Cell Position");
                    if (Program.Debug)
                        MessageBox.Show(ex.ToString());
                }
            }
        }

        private void BtnRolAction_Click(object sender, EventArgs e)
        {
            //if save then update program.rolls after chek empty filds
            //chk repeat
            //name !="NameNoRpeat"
            //try
            if (BtnRolAction.Text == Add)
            {
                EditRol(false);
                BtnRolAction.Text = Save;
            }
            else//save
            {             
                ListViewItem tmplvi= new ListViewItem(new string[] {
                    Tb_RolName.Text,Tb_RolRegX.Text,Tb_RolRegY.Text, (Cb_DelReg.Checked ?Tb_DelReg.Text : "")
                });

                if (SelectedRolIndx == -1)//new role
                {
                    for (int k = 0; k < Lv_Roles.Items.Count; k++)//name no repeat
                        if (Tb_RolName.Text == Lv_Roles.Items[k].Text)
                        {
                            MessageBox.Show("Please Change Role Name !!");
                            return;
                        }
                    Lv_Roles.Items.Add(tmplvi);
                }
                else//edite exsist role
                    Lv_Roles.Items[SelectedRolIndx] = tmplvi;
                
                //SaveRoles();
                SelectNullRol();
            }
        }

        private void BtnDelRol_Click(object sender, EventArgs e)
        {
            //delete selected if selected or error msg
            if(SelectedRolIndx!=-1)
                Lv_Roles.Items.RemoveAt(SelectedRolIndx);
            SelectedRolIndx = -1;
            //SaveRoles();
            SelectNullRol();           
            //update roles
        }

        private void BtnSaveAs_Click(object sender, EventArgs e)
        {
            try
            {
                //save
                SaveRoles();
                //chk all role operations
                TryAllOper();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error 3.9");
                if (Program.Debug)
                    MessageBox.Show(ex.ToString());
                return;
            }

            //next
            Program.ChangeFrmSetting(this);
            this.Hide();
            Program._Form4 = new Frm4Saveas();
            Program._Form4.Show();
        }

        void TryAllOper()
        {
            foreach (Role R in Program.Roles)
            {
                if (string.IsNullOrEmpty(R.Column))
                    throw new Exception("Empty value not allowed\r\n at Column "+R.Name);
                if (string.IsNullOrEmpty(R.Row))
                    throw new Exception("Empty value not allowed\r\n at Row " + R.Name);
                if (!MathsEvaluator.TryParse(((R.Column).Replace("X","0").Replace("Y","0")) , out decimal tmpTb_SX))
                    throw new Exception("Operation not valid " + "(At Role \"" + R.Name + "\"");
                if (!MathsEvaluator.TryParse(((R.Row).Replace("X", "0").Replace("Y", "0")), out decimal tmpTb_SY))
                    throw new Exception("Operation not valid " + "(At Role \"" + R.Name + "\"");
                
            }
        }

        private void Frm3AddRols_Shown(object sender, EventArgs e)
        {

            SaveRoles();
            PrintRoles();

            PrintSheet();
            StartAndSeletedCells();

            SelectNullRol();

            if (Program.Debug)
                BtnSaveAs_Click(null, null);
        }
    }
}
