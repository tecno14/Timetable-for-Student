using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;

namespace MyExcelLib
{
    class ExcelFile3 : ExcelFile2
    {
        /*public void LoadFile(string FileName, bool tmpPath)
        {
            try
            {
                OpenFile(FileName, tmpPath);

                //reset all
                FileDS = new System.Data.DataSet();

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
                if (Program.Debug)
                    MessageBox.Show(ex.ToString());
            }
            this.Text = "Excel2List Tool V1.0";

            if (Program.Debug)
                BtnNext_Click(null, null);
        }*/

    }
}
