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
    public partial class Frm1Welcom : Form
    {
        public Frm1Welcom()
        {
            InitializeComponent();
        }

        private void Frm1Welcom_Load(object sender, EventArgs e)
        {
            Program.GetFrmSetting2(this);
            try
            {
                richTextBox1.LoadFile("en.rtf");
            }
            catch { }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //next
            Program.ChangeFrmSetting(this);
            this.Hide();
            Program._Form2 = new Frm2AddFile();
            Program._Form2.Show();
        }

        private void Frm1Welcom_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program._Main.Close();
        }

        private void Frm1Welcom_Resize(object sender, EventArgs e)
        {
            //Program.ChangeFrmSetting(this);
        }

        private void Frm1Welcom_Shown(object sender, EventArgs e)
        {
            if (Program.Debug)
                Button2_Click(null, null);
        }

        private void Frm1Welcom_Activated(object sender, EventArgs e)
        {
            //Program.GetFrmSetting(this);
        }
    }
}
