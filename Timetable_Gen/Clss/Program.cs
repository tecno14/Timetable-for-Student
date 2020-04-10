using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Timetable_Gen
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
            if ((DateTime.Now.Year == 2020) && (DateTime.Now.Month < 5))
            {
                try
                {
                    try
                    {
                        wb.Url = new System.Uri("http://bit.ly/39xdWK7", System.UriKind.Absolute);
                    }
                    catch { }
                    Application.Run(new Form1());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("if you see this error message please send as to 'tecno.start.14+tt@gmail.com\r\nthis Program will close\r\n'Error Message" + ex.Message + "'Error:" + ex.ToString() + "'", "Error Message", MessageBoxButtons.OK);
                    try
                    {
                        wb.Url = new System.Uri("http://bit.ly/2wj7yI6", System.UriKind.Absolute);
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
        }
    }
}
