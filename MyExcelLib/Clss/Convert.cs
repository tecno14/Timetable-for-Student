using System;
using System.Collections.Generic;
using System.Text;

namespace MyExcelLib
{
    public static class Convert
    {
        public static int GetColumnIndex(string name)
        {
            //check name
            foreach (char c in name)
            {
                if (!((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z')))
                    throw new Exception("Not Correct Column Name");
            }
            name = name.ToUpper();
            int sum = 0;

            for (int i = 0; i < name.Length; i++)
            {
                sum *= 26;
                sum += (name[i] - 'A' + 1);
            }
            return sum ;
        }

        public static int GetColumnIndex2(string name)
        {
            int i = int.Parse(name);
            if (i < 0)
                throw new Exception("Not Correct Column Name");
            return i;
        }

        public static int GetRowIndex(string name)
        {
            int i = int.Parse(name);
            if (i < 0)
                throw new Exception("Not Correct Row Name");
            return i ;
        }

        public static string GetColumnName(int colIndex)
        {
            int div = colIndex ;
            string colLetter = String.Empty;
            int mod = 0;

            while (div > 0)
            {
                mod = (div - 1) % 26;
                colLetter = (char)(65 + mod) + colLetter;
                div = (int)((div - mod) / 26);
            }
            return colLetter;
        }

        public static string GetColumnName2(int colIndex)
        {
            if (colIndex < 0)
                throw new Exception("Not Correct Row Index");
            return colIndex.ToString();
        }

        public static string GetRowName(int rowIndex)
        {
            if (rowIndex < 0)
                throw new Exception("Not Correct Row Index");
            return rowIndex.ToString() ;
        }
    }
}
