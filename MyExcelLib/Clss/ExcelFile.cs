using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Data;
using Excel;
using Microsoft.Office.Interop.Excel;

namespace MyExcelLib
{
    public class ExcelFile
    {
        string Path;
        int Sheet;

        public DataSet result;
        IExcelDataReader reader;
        FileStream fs;

        public ExcelFile(string Path, int Sheet = 1)
        {
            this.Path = Path;
            this.Sheet = Sheet;

            try
            {
                reader = null;
                result = null;
                if (!File.Exists(Path))
                    throw new Exception("File ot found");

                string NewPath = System.IO.Path.Combine(System.IO.Path.GetTempPath(), System.IO.Path.GetFileName(Path));
                File.Copy(Path, NewPath, true);
                this.Path = NewPath;
                fs = File.Open(this.Path, FileMode.Open, FileAccess.ReadWrite);
                reader = ExcelReaderFactory.CreateBinaryReader(fs);
                reader.IsFirstRowAsColumnNames = false;
                result = reader.AsDataSet();


                fs.Close();
                Close();

            }
            catch (Exception ex)
            {
                Close();
                throw ex;
            }


        }



            // public string Read(int i,int j)
            //  {
            //return ((_Excel.Range)ws.Cells[i, j]).Value2.toString() ?? "nf";
            // }

            /*public string Read(string c,string r)
            {
                return Read(Convert.GetColumnIndex(c), Convert.GetRowIndex(r));
            }*/

            private void Close()
        {
            //wb.Close();
            if (!reader.IsClosed)
                reader.Close();
            if(File.Exists(this.Path))
                File.Delete(this.Path);
            fs = null;
            reader = null;
        }

    }
}
