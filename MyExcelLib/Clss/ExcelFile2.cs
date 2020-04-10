using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;
using System.Data;

namespace MyExcelLib
{
    public class ExcelFile2
    {
        //This Library written by TECNO wael.had.sy@gmail.com
        protected string Path;
        protected bool tmpPath;
        protected _Application excel;
        protected Workbook wb;
        protected Worksheet ws;
        public List<string> SNames;
        public DataSet FileDS;
        public string[] FirstRow;

        //Excel.Range FormatRan;

        public ExcelFile2()
        {
            excel = new _Excel.Application();
        }
        public ExcelFile2(string Path,bool tmpPath=true)
        {
            OpenFile(Path, tmpPath);
        }
        public void OpenFile(string Path, bool tmpPath = true)
        {
            this.Path = Path;
            this.tmpPath = tmpPath;

            if (!System.IO.File.Exists(this.Path))
                throw new Exception("File ot found");

            ///Tecno
            if (tmpPath)
            {
                Random r = new Random();
                string RandomName = "";
                for (int i = 0; i < 10; i++)
                    RandomName += r.Next(0, 9).ToString();
                RandomName += System.IO.Path.GetFileName(Path);
                string NewPath = System.IO.Path.Combine(System.IO.Path.GetTempPath(), RandomName);
                System.IO.File.Copy(this.Path, NewPath, true);
                this.Path = NewPath;
            }
            ///

            excel = new _Excel.Application();
            wb = excel.Workbooks.Open(this.Path);

            //ws = wb.Sheets[Sheet];
            //UnMergeandDublData();

            SNames = new List<string>();
            for (int k = 1; k < excel.Sheets.Count + 1; k++)
                SNames.Add(excel.Sheets[k].Name);
            FormatToText();
        }
        public void ReadAll2DataSet()
        {
            FileDS = new DataSet("DS");

            if (wb == null)
                return;
            ////double AllCount = -1;
            ////double tmpCount = 0;
            //for each sheet add new table
            for (int k = 1; k < wb.Sheets.Count + 1; k++)
            {
                System.Data.DataTable tmpTable = new System.Data.DataTable();//table

                //add columns
                for (int i = 1; i < wb.Sheets[k].UsedRange.Columns.Count + 1; i++)
                    tmpTable.Columns.Add(Convert.GetColumnName2(i));

                //add rows
                for (int j = 0; j < wb.Sheets[k].UsedRange.Rows.Count; j++)
                    tmpTable.Rows.Add();

                //ReadData
                ////AllCount = (wb.Sheets[k].UsedRange.Columns.Count) * (wb.Sheets[k].UsedRange.Rows.Count);
                ////tmpCount = 0;
                for (int i = 0; i < wb.Sheets[k].UsedRange.Columns.Count; i++)
                    for (int j = 0; j < wb.Sheets[k].UsedRange.Rows.Count; j++)
                    {
                        tmpTable.Rows[j][i] = ReadCell(i, j, k);
                        ////tmpCount++;
                    }

                //add to DataSet
                FileDS.Tables.Add(tmpTable);
            }

        }
        public void UnMergeAndDublDataFile()
        {
            if (wb == null)
                return;

            Range joinedCells;
            for (int k = 1; k < excel.Sheets.Count + 1; k++)
            {
                foreach (Range Cell in excel.Sheets[k].UsedRange)
                    if (Cell.MergeCells)
                    {
                        joinedCells = Cell.MergeArea;
                        Cell.MergeCells = false;
                        joinedCells.Value2 = Cell.Value2;
                    }
            }
            /*
            Sub UnMergeFill()

            Dim cell As Range, joinedCells As Range

            For Each cell In ThisWorkbook.ActiveSheet.UsedRange
                If cell.MergeCells Then
                    Set joinedCells = cell.MergeArea
                    cell.MergeCells = False
                    joinedCells.Value = cell.Value
                End If
            Next

            End Sub
             */
        }
        protected void OpenSheet(int indx)
        {
            //tmp
            //ws = excel.Sheets[indx];
        }
        public string [] ReadFirstRow(int SheetNnum)
        {
            int w = FileDS.Tables[SheetNnum].Columns.Count;
            FirstRow = new string[w];
            for (int i = 0; i < w; i++)
                FirstRow[i] = ReadCell(i, 0, SheetNnum);
            return FirstRow;
        }
        public string ReadCell(int Col, int Row,int SheetNum=-1)
        {
            if (SheetNum == -1)
                if (ws != null)
                    SheetNum = ws.Index;
                else
                    throw new Exception("Sheet Not Selected !!!");
            Col++;
            Row++;

            if (wb.Sheets[SheetNum].Cells[Row, Col].Value2 != null)
                return (wb.Sheets[SheetNum].Cells[Row, Col].Text).ToString();
            else
                return "";
        }
        public void FormatToText()
        {
            for (int k = 1; k < wb.Sheets.Count + 1; k++)
                wb.Sheets[k].UsedRange.NumberFormat = "@";
        }
        public void WriteToCell(int Col, int Row, string s,int SheetNum=-1)
        {
            //wb.Sheets[k].UsedRange
            if (SheetNum == -1)
                if (ws != null)
                    SheetNum = ws.Index;
                else
                    throw new Exception("Sheet Not Selected !!!");
            Col++;
            Row++;
            wb.Sheets[SheetNum].Cells[Row, Col].Value = string.Format("'" + s);
        }
        public void Save()
        {
            wb.Save();
        }
        public void SaveAs(string path)
        {
            wb.SaveAs(path);
        }
        public void Close()
        {
            if (excel != null)
            {
                if(wb!=null)
                {
                    wb.Close();
                    wb = null;
                }
                excel.Quit();
                excel = null;
            }
                       
        }
        public void DeleteTmpFile()
        {
            if (!tmpPath)
                return;
            Close();
            System.IO.File.Delete(this.Path);
            this.Path = "";
        }
        public void CreateNewFile()
        {
            this.wb = excel.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
            this.ws = wb.Worksheets[1];
        }
        public void CreateNewSheet()
        {
            //tmp
            //Worksheet tempsheet = wb.Worksheets.Add(After: ws);
        }

    }
}
