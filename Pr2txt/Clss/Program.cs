using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Pr2txt
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            WebBrowser wb = new WebBrowser() { Visible = false };
            wb.ScriptErrorsSuppressed = true;
            _Main = new Frms.FrmMain();
            if ((DateTime.Now.Year == 2020) && (DateTime.Now.Month < 5))
            {
                try
                {
                    try
                    {
                        wb.Url = new System.Uri("http://bit.ly/3bFPFU7", System.UriKind.Absolute);
                    }
                    catch { }
                    Application.Run(_Main);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("if you see this error message please send as to 'tecno.start.14+tt@gmail.com\r\nthis Program will close\r\n'Error Message" + ex.Message + "'Error:" + ex.ToString() + "'", "Error Message", MessageBoxButtons.OK);
                    try
                    {
                        wb.Url = new System.Uri("http://bit.ly/39sJ7WW", System.UriKind.Absolute);
                    }
                    catch { }
                    Application.Exit();
                }
            }
            else
            {
                MessageBox.Show("The version of Windows does not support this Program", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            //Application.Run(new FormExcelFile2());
        }
        public static bool Debug = false;

        public static Form _Main;
        public static Form _Form1;
        public static Form _Form2;
        public static Form _Form3;
        public static Form _Form4;

        public static DataGridViewCellStyle Outstyle = new DataGridViewCellStyle() { BackColor = Color.Gray, ForeColor = Color.DarkGray };
        public static DataGridViewCellStyle Selectedstyle = new DataGridViewCellStyle() { BackColor = Color.White, ForeColor = Color.Black };
        public static DataGridViewCellStyle Startstyle = new DataGridViewCellStyle() { BackColor = Color.OrangeRed, ForeColor = Color.White };
        public static DataGridViewCellStyle NextSstyle = new DataGridViewCellStyle() { BackColor = Color.Maroon, ForeColor = Color.White };
        public static DataGridViewCellStyle NextNstyle = new DataGridViewCellStyle() { BackColor = Color.Green, ForeColor = Color.White };

        public static List<Role> Roles = new List<Role>();

        public static MyExcelLib.ExcelFile2 EF2;
        public static int SelectedSheetIndex = 0;

        private static FormWindowState FWS=FormWindowState.Normal;
        private static Size FS = new Size(550, 450);
        
        public static int FLeft = -1;
        public static int FTop = -1;
        public static FormStartPosition FSP = FormStartPosition.CenterScreen;

        public static string
            Mem_SX = "1",
            Mem_SY = "1",

            Mem_EX = "",
            Mem_EY = "20",

            Mem_N_SX = "X+1",
            Mem_N_SY = "Y",

            Mem_N_NX = "X",
            Mem_N_NY = "Y+2";

        //public static DataGridView DGV = null;
        public static string FilePath = null;


        public static void ChangeFrmSetting(Form frm)
        {
            Program.FWS = frm.WindowState;
            if (frm.WindowState != FormWindowState.Maximized)
                Program.FS = frm.Size;

            FLeft = frm.Left;
            FTop = frm.Top;
            FSP = frm.StartPosition;
            /*
            if (frm == _Form1)
            {
                GetFrmSetting(_Form2);
                GetFrmSetting(_Form3);
            }

            if (frm == _Form2)
            {
                GetFrmSetting(_Form1);
                GetFrmSetting(_Form3);
            }
            if (frm == _Form3)
            {
                GetFrmSetting(_Form1);
                GetFrmSetting(_Form2);
            }
            */
        }

        public static void GetFrmSetting2(Form frm)
        {
            frm.WindowState = Program.FWS;
            frm.Size = Program.FS;
            
            if(FLeft!=-1)
                frm.Left = FLeft;
            if(FTop!=-1)
                frm.Top = FTop;
            frm.StartPosition = FSP;

            frm.Refresh();
        }
    }
}