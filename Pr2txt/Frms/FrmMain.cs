using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pr2txt.Frms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent(); 
            //Program._Main = this;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.Hide();
            Program._Form1 = new Frms.Frm1Welcom();
            Program._Form2 = new Frms.Frm2AddFile();
            Program._Form3 = new Frms.Frm3AddRols();
            Program._Form4 = new Frms.Frm4Saveas();
            Program._Form1.Show();
        }
    }
}
