using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Timetable_Gen.Clss.tmp;
using Timetable_Gen.Clss.tmp.Flds;

namespace Timetable_Gen
{
    public partial class Form1 : Form
    {
        bool Changetab = false;
        private int SelectTabIndex
        {
            set
            {
                Changetab = true;
                tabControl1.SelectedIndex = value;
                Changetab = false;
            }
            get
            {
                return tabControl1.SelectedIndex;
            }
        }

        public MyExcelLib.ExcelFile2 EF2;
        public bool Debug = false;//true;
        public bool Alpha = false;
        //public bool IS_DB_Load = false;
        //public DataGridViewRow FirstRow;
        //object DB_All = null;
        //object DB_Role = null;
        //bool DB_All_IsCreated = false;
        //bool DB_Rol_IsCreated = false;
        const string Any = "\"Any\"";
        const string Include = "Include";
        const string Exclude = "exclude";
        int SDGVRolIndx = -1;
        const string Add = "Add";
        const string Edit = "Edit";
        int BackTab = -1;
        int SelectedDGV_RolesIndex
        {
            set
            {
                SDGVRolIndx = value;
                if (value == -1)
                {
                    Btn_Add.Text = Add;
                    LoadDGV_RolesHeader();
                    DGV_RolesHeader.ClearSelection();
                }
                else Btn_Add.Text = Edit;
            }
            get
            {
                return SDGVRolIndx;
            }
        }
        public List<List<string>> AllColomns = null;
        //Form
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SelectTabIndex = 0;
            TabControl1_SelectedIndexChanged(null, null);
            ////tmp for alhpa ver////
            if (Alpha)//2019 -1 program 
            {
                
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
                dataGridView1.Columns.Add("1", "1");
                dataGridView1.Columns.Add("2", "2");
                dataGridView1.Columns.Add("3", "3");
                dataGridView1.Columns.Add("4", "4");
                dataGridView1.Columns.Add("5", "5");
                dataGridView1.Columns.Add("6", "6");
                dataGridView1.Rows.Add("Course", "Group", "Present", "Day", "Period", "Room");
                dataGridView1.Rows.Add("CAL1", "2", "shr", "Saturday", "8--10", "ICE-01");
                dataGridView1.Rows.Add("CAL1", "2", "shr", "Saturday", "10--12", "ICE-01");
                dataGridView1.Rows.Add("CAL1", "3", "shr", "Saturday", "12--14", "ICE-01");
                dataGridView1.Rows.Add("CAL1", "3", "shr", "Saturday", "14-16", "ICE-01");
                dataGridView1.Rows.Add("PS", "1", "sa", "Sunday", "8--10", "ICE-01");
                dataGridView1.Rows.Add("PS", "1", "sa", "Sunday", "10--12", "ICE-01");
                dataGridView1.Rows.Add("CAL1", "1", "sa", "Sunday", "12--14", "ICE-01");
                dataGridView1.Rows.Add("SAD", "1", "hn", "Monday", "8--10", "ICE-01");
                dataGridView1.Rows.Add("SAD", "1", "hn", "Monday", "10--12", "ICE-01");
                dataGridView1.Rows.Add("PH1", "3", "mi", "Monday", "14-16", "ICE-01");
                dataGridView1.Rows.Add("CAL1", "1", "sa", "Tuesday", "10--12", "ICE-01");
                dataGridView1.Rows.Add("CS", "2", "zm", "Tuesday", "12--14", "ICE-01");
                dataGridView1.Rows.Add("SAD", "2", "hn", "Wedensday", "8--10", "ICE-01");
                dataGridView1.Rows.Add("SAD", "2", "hn", "Wedensday", "10--12", "ICE-01");
                dataGridView1.Rows.Add("LA", "1", "nrg", "Saturday", "8--10", "ICE-02");
                dataGridView1.Rows.Add("LA", "1", "nrg", "Saturday", "10--12", "ICE-02");
                dataGridView1.Rows.Add("LA", "2", "nrg", "Saturday", "12--14", "ICE-02");
                dataGridView1.Rows.Add("LA", "2", "nrg", "Saturday", "14-16", "ICE-02");
                dataGridView1.Rows.Add("PH1", "1", "mi", "Sunday", "8--10", "ICE-02");
                dataGridView1.Rows.Add("PH1", "2", "mi", "Sunday", "10--12", "ICE-02");
                dataGridView1.Rows.Add("PH1", "4", "mi", "Sunday", "12--14", "ICE-02");
                dataGridView1.Rows.Add("ESP1", "1", "nt", "Sunday", "14-16", "ICE-02");
                dataGridView1.Rows.Add("CS", "5", "zm", "Monday", "8--10", "ICE-02");
                dataGridView1.Rows.Add("PH1", "5", "mi", "Monday", "10--12", "ICE-02");
                dataGridView1.Rows.Add("CAL2", "1", "fd", "Monday", "12--14", "ICE-02");
                dataGridView1.Rows.Add("DE", "DE", "fd", "Monday", "14-16", "ICE-02");
                dataGridView1.Rows.Add("CAL2", "1", "fd", "Tuesday", "12--14", "ICE-02");
                dataGridView1.Rows.Add("AI", "1", "xx", "Wedensday", "8--10", "ICE-02");
                dataGridView1.Rows.Add("AI", "1/2", "xx", "Wedensday", "10--12", "ICE-02");
                dataGridView1.Rows.Add("AI", "2", "xx", "Wedensday", "12--14", "ICE-02");
                dataGridView1.Rows.Add("IAP", "5", "akm", "Saturday", "10--12", "ICE-03");
                dataGridView1.Rows.Add("IAP", "2", "akm", "Saturday", "12--14", "ICE-03");
                dataGridView1.Rows.Add("IAP", "4", "akm", "Saturday", "14-16", "ICE-03");
                dataGridView1.Rows.Add("DM", "1", "ry", "Sunday", "10--12", "ICE-03");
                dataGridView1.Rows.Add("OR", "2", "xx", "Sunday", "12--14", "ICE-03");
                dataGridView1.Rows.Add("OR", "2", "xx", "Sunday", "14-16", "ICE-03");
                dataGridView1.Rows.Add("CS", "1", "zm", "Monday", "10--12", "ICE-03");
                dataGridView1.Rows.Add("NA", "1", "ry", "Monday", "12--14", "ICE-03");
                dataGridView1.Rows.Add("NA", "1", "ry", "Monday", "14-16", "ICE-03");
                dataGridView1.Rows.Add("DM", "1", "ry", "Tuesday", "8--10", "ICE-03");
                dataGridView1.Rows.Add("CS", "4", "zm", "Tuesday", "10--12", "ICE-03");
                dataGridView1.Rows.Add("PS", "3", "sa", "Tuesday", "12--14", "ICE-03");
                dataGridView1.Rows.Add("PS", "3", "sa", "Tuesday", "14-16", "ICE-03");
                dataGridView1.Rows.Add("CAL2", "2", "isn", "Wedensday", "10--12", "ICE-03");
                dataGridView1.Rows.Add("CAL2", "3", "isn", "Wedensday", "12--14", "ICE-03");
                dataGridView1.Rows.Add("DB2", "1", "tsh", "Saturday", "8--10", "ICE-04");
                dataGridView1.Rows.Add("SW1", "1", "tsh", "Saturday", "10--12", "ICE-04");
                dataGridView1.Rows.Add("ADB", "ADB", "tsh", "Saturday", "12--14", "ICE-04");
                dataGridView1.Rows.Add("DB2", "2", "tsh", "Saturday", "14-16", "ICE-04");
                dataGridView1.Rows.Add("CS", "3", "zm", "Sunday", "8--10", "ICE-04");
                dataGridView1.Rows.Add("ARWP", "ARWP", "nt", "Sunday", "10--12", "ICE-04");
                dataGridView1.Rows.Add("RM", "6", "hk", "Sunday", "12--14", "ICE-04");
                dataGridView1.Rows.Add("RM", "6", "hk", "Sunday", "14-16", "ICE-04");
                dataGridView1.Rows.Add("PH1", "6", "mi", "Tuesday", "8--10", "ICE-04");
                dataGridView1.Rows.Add("DM", "6", "ry", "Tuesday", "10--12", "ICE-04");
                dataGridView1.Rows.Add("DM", "6", "ry", "Tuesday", "12--14", "ICE-04");
                dataGridView1.Rows.Add("RE(L3)", "RE(L3)", "RE(L3)", "Tuesday", "14-16", "ICE-04");
                dataGridView1.Rows.Add("RE(L3)", "RE(L3)", "RE(L3)", "Wedensday", "8--10", "ICE-04");
                dataGridView1.Rows.Add("RE(L3)", "RE(L3)", "RE(L3)", "Wedensday", "10--12", "ICE-04");
                dataGridView1.Rows.Add("NA", "2", "ry", "Wedensday", "12--14", "ICE-04");
                dataGridView1.Rows.Add("NA", "2", "ry", "Wedensday", "14-16", "ICE-04");
                dataGridView1.Rows.Add("IAP", "1", "xx", "Saturday", "8--10", "ICE-05");
                dataGridView1.Rows.Add("IAP", "3", "xx", "Saturday", "10--12", "ICE-05");
                dataGridView1.Rows.Add("tsh", "tsh", "xx", "Saturday", "12--14", "ICE-05");
                dataGridView1.Rows.Add("tsh", "tsh", "xx", "Saturday", "14-16", "ICE-05");
                dataGridView1.Rows.Add("DCM", "DCM", "ky", "Sunday", "8--10", "ICE-05");
                dataGridView1.Rows.Add("RE", "RE", "", "Sunday", "10--12", "ICE-05");
                dataGridView1.Rows.Add("NA", "3", "ry", "Sunday", "12--14", "ICE-05");
                dataGridView1.Rows.Add("NA", "3", "ry", "Sunday", "14-16", "ICE-05");
                dataGridView1.Rows.Add("OS1", "1", "mha", "Monday", "8--10", "ICE-05");
                dataGridView1.Rows.Add("OS1", "1/", "mha", "Monday", "10--12", "ICE-05");
                dataGridView1.Rows.Add("ELC1", "ELC1", "ssh", "Monday", "14-16", "ICE-05");
                dataGridView1.Rows.Add("RE", "RE", "", "Tuesday", "10--12", "ICE-05");
                dataGridView1.Rows.Add("RE(L3)", "RE(L3)", "RE(L3)", "Tuesday", "14-16", "ICE-05");
                dataGridView1.Rows.Add("RE(L3)", "RE(L3)", "RE(L3)", "Wedensday", "8--10", "ICE-05");
                dataGridView1.Rows.Add("RE(L3)", "RE(L3)", "RE(L3)", "Wedensday", "10--12", "ICE-05");
                dataGridView1.Rows.Add("IAP", "6", "akm", "Saturday", "8--10", "ICE-06");
                dataGridView1.Rows.Add("AAD", "1", "saj", "Saturday", "10--12", "ICE-06");
                dataGridView1.Rows.Add("CD", "CD", "saj", "Saturday", "12--14", "ICE-06");
                dataGridView1.Rows.Add("AAD", "2", "saj", "Saturday", "14-16", "ICE-06");
                dataGridView1.Rows.Add("DB1", "1", "xx", "Sunday", "10--12", "ICE-06");
                dataGridView1.Rows.Add("DB1", "2", "xx", "Sunday", "12--14", "ICE-06");
                dataGridView1.Rows.Add("PR1", "3", "hn", "Monday", "12--14", "ICE-06");
                dataGridView1.Rows.Add("ESP1", "2", "nt", "Monday", "14-16", "ICE-06");
                dataGridView1.Rows.Add("ADS", "3", "fk", "Tuesday", "8--10", "ICE-06");
                dataGridView1.Rows.Add("RE(L3)", "RE(L3)", "RE(L3)", "Tuesday", "14-16", "ICE-06");
                dataGridView1.Rows.Add("RE(L3)", "RE(L3)", "RE(L3)", "Wedensday", "8--10", "ICE-06");
                dataGridView1.Rows.Add("RE(L3)", "RE(L3)", "RE(L3)", "Wedensday", "10--12", "ICE-06");
                dataGridView1.Rows.Add("CV", "CV", "xx", "Wedensday", "12--14", "ICE-06");
                dataGridView1.Rows.Add("MM", "MM", "xx", "Wedensday", "14-16", "ICE-06");
                dataGridView1.Rows.Add("CA", "1", "gam", "Saturday", "8--10", "ICE-07");
                dataGridView1.Rows.Add("PR2", "1", "gam", "Saturday", "10--12", "ICE-07");
                dataGridView1.Rows.Add("PR2", "2", "gam", "Saturday", "12--14", "ICE-07");
                dataGridView1.Rows.Add("LC", "2", "mz", "Sunday", "8--10", "ICE-07");
                dataGridView1.Rows.Add("CO", "2", "sas", "Sunday", "10--12", "ICE-07");
                dataGridView1.Rows.Add("CO", "2", "sas", "Sunday", "12--14", "ICE-07");
                dataGridView1.Rows.Add("INTH", "1", "sj", "Sunday", "14-16", "ICE-07");
                dataGridView1.Rows.Add("EEC", "2", "ah", "Monday", "10--12", "ICE-07");
                dataGridView1.Rows.Add("DCM", "DCM", "ky", "Monday", "12--14", "ICE-07");
                dataGridView1.Rows.Add("LC", "2", "mz", "Tuesday", "8--10", "ICE-07");
                dataGridView1.Rows.Add("DCO", "DCO", "fk", "Tuesday", "10--12", "ICE-07");
                dataGridView1.Rows.Add("DE", "DE", "", "Tuesday", "14-16", "ICE-07");
                dataGridView1.Rows.Add("ELC1", "ELC1", "ssh", "Wedensday", "14-16", "ICE-07");
                dataGridView1.Rows.Add("CAL1", "4", "nsh", "Saturday", "8--10", "ICE-08");
                dataGridView1.Rows.Add("CAL1", "4", "nsh", "Saturday", "10--12", "ICE-08");
                dataGridView1.Rows.Add("CAL1", "5", "nsh", "Saturday", "12--14", "ICE-08");
                dataGridView1.Rows.Add("CAL1", "5", "nsh", "Saturday", "14-16", "ICE-08");
                dataGridView1.Rows.Add("EEC", "1", "sj", "Sunday", "10--12", "ICE-08");
                dataGridView1.Rows.Add("ME", "ME", "ky", "Sunday", "12--14", "ICE-08");
                dataGridView1.Rows.Add("EM", "EM", "kdb", "Sunday", "14-16", "ICE-08");
                dataGridView1.Rows.Add("LC", "1", "hj", "Monday", "10--12", "ICE-08");
                dataGridView1.Rows.Add("ADS", "2", "fk", "Monday", "12--14", "ICE-08");
                dataGridView1.Rows.Add("LC", "1", "hj", "Tuesday", "10--12", "ICE-08");
                dataGridView1.Rows.Add("CO", "1", "hj", "Tuesday", "12--14", "ICE-08");
                dataGridView1.Rows.Add("CO", "1/", "hj", "Tuesday", "14-16", "ICE-08");
                dataGridView1.Rows.Add("CO", "3", "sas", "Wedensday", "8--10", "ICE-08");
                dataGridView1.Rows.Add("CO", "3", "sas", "Wedensday", "10--12", "ICE-08");
                dataGridView1.Rows.Add("C&S", "1", "la", "Saturday", "8--10", "ICE-09");
                dataGridView1.Rows.Add("EAP", "EAP", "la", "Saturday", "10--12", "ICE-09");
                dataGridView1.Rows.Add("C&S", "2", "la", "Saturday", "12--14", "ICE-09");
                dataGridView1.Rows.Add("CTH", "1", "saj", "Sunday", "8--10", "ICE-09");
                dataGridView1.Rows.Add("CTH", "1/2", "saj", "Sunday", "10--12", "ICE-09");
                dataGridView1.Rows.Add("CTH", "2", "saj", "Sunday", "12--14", "ICE-09");
                dataGridView1.Rows.Add("DIS", "DIS", "sas", "Monday", "10--12", "ICE-09");
                dataGridView1.Rows.Add("PLP", "PLP", "sas", "Monday", "12--14", "ICE-09");
                dataGridView1.Rows.Add("DM", "5", "yw", "Tuesday", "10--12", "ICE-09");
                dataGridView1.Rows.Add("RE", "RE", "", "Tuesday", "12--14", "ICE-09");
                dataGridView1.Rows.Add("INTH", "2", "sj", "Tuesday", "14-16", "ICE-09");
                dataGridView1.Rows.Add("IT", "1", "gsh", "Saturday", "8--10", "ICE-10");
                dataGridView1.Rows.Add("IT", "2", "gsh", "Saturday", "10--12", "ICE-10");
                dataGridView1.Rows.Add("CN", "1", "gsh", "Saturday", "12--14", "ICE-10");
                dataGridView1.Rows.Add("CN", "2", "gsh", "Saturday", "14-16", "ICE-10");
                dataGridView1.Rows.Add("OR", "1", "xx", "Sunday", "8--10", "ICE-10");
                dataGridView1.Rows.Add("OR", "1", "xx", "Sunday", "10--12", "ICE-10");
                dataGridView1.Rows.Add("CAL2", "2", "isn", "Sunday", "12--14", "ICE-10");
                dataGridView1.Rows.Add("CAL2", "3", "isn", "Sunday", "14-16", "ICE-10");
                dataGridView1.Rows.Add("DM", "3", "yw", "Monday", "8--10", "ICE-10");
                dataGridView1.Rows.Add("EF", "EF", "ssh", "Monday", "10--12", "ICE-10");
                dataGridView1.Rows.Add("CS", "6", "zm", "Monday", "12--14", "ICE-10");
                dataGridView1.Rows.Add("RE", "RE", "", "Monday", "14-16", "ICE-10");
                dataGridView1.Rows.Add("DM", "3", "yw", "Tuesday", "8--10", "ICE-10");
                dataGridView1.Rows.Add("EEC", "3", "ah", "Tuesday", "10--12", "ICE-10");
                dataGridView1.Rows.Add("RE", "RE", "", "Tuesday", "14-16", "ICE-10");
                dataGridView1.Rows.Add("MCM", "MCM", "ky", "Wedensday", "8--10", "ICE-10");
                dataGridView1.Rows.Add("MCM", "MCM", "ky", "Wedensday", "10--12", "ICE-10");
                dataGridView1.Rows.Add("EF", "EF", "ssh", "Wedensday", "12--14", "ICE-10");
                dataGridView1.Rows.Add("APD", "APD", "rah", "Saturday", "8--10", "ICE-11");
                dataGridView1.Rows.Add("CG", "1", "rah", "Saturday", "12--14", "ICE-11");
                dataGridView1.Rows.Add("CG", "2", "rah", "Saturday", "14-16", "ICE-11");
                dataGridView1.Rows.Add("MCO", "MCO", "ssh", "Sunday", "8--10", "ICE-11");
                dataGridView1.Rows.Add("MCO", "MCO", "ssh", "Sunday", "10--12", "ICE-11");
                dataGridView1.Rows.Add("STI", "STI", "hj", "Sunday", "12--14", "ICE-11");
                dataGridView1.Rows.Add("EC1", "EC1", "ah", "Monday", "8--10", "ICE-11");
                dataGridView1.Rows.Add("ADS", "1", "fk", "Monday", "10--12", "ICE-11");
                dataGridView1.Rows.Add("FZL", "FZL", "tb", "Monday", "12--14", "ICE-11");
                dataGridView1.Rows.Add("EC1", "EC1", "ah", "Tuesday", "8--10", "ICE-11");
                dataGridView1.Rows.Add("SIP2", "SIP2", "sj", "Tuesday", "12--14", "ICE-11");
                dataGridView1.Rows.Add("ENM", "1", "kdb", "Tuesday", "14-16", "ICE-11");
                dataGridView1.Rows.Add("EC2", "EC2", "sj", "Wedensday", "10--12", "ICE-11");
                dataGridView1.Rows.Add("ENM", "2", "kdb", "Wedensday", "14-16", "ICE-11");
                dataGridView1.Rows.Add("DM", "4", "yw", "Saturday", "12--14", "ICE-12");
                dataGridView1.Rows.Add("DM", "2/", "yw", "Saturday", "14-16", "ICE-12");
                dataGridView1.Rows.Add("DM", "5", "yw", "Sunday", "10--12", "ICE-12");
                dataGridView1.Rows.Add("DM", "2", "yw", "Sunday", "12--14", "ICE-12");
                dataGridView1.Rows.Add("RE", "RE", "", "Sunday", "14-16", "ICE-12");
                dataGridView1.Rows.Add("EMF", "EMF", "nt", "Monday", "8--10", "ICE-12");
                dataGridView1.Rows.Add("EMF", "EMF", "nt", "Monday", "10--12", "ICE-12");
                dataGridView1.Rows.Add("DM", "4", "yw", "Monday", "12--14", "ICE-12");
                dataGridView1.Rows.Add("RE", "RE", "", "Monday", "14-16", "ICE-12");
                dataGridView1.Rows.Add("NN", "NN", "xx", "Tuesday", "10--12", "ICE-12");
                dataGridView1.Rows.Add("EXP", "EXP", "xx", "Tuesday", "12--14", "ICE-12");
                dataGridView1.Rows.Add("RE", "RE", "", "Tuesday", "14-16", "ICE-12");
                dataGridView1.Rows.Add("PL", "PL", "mha", "Wedensday", "10--12", "ICE-12");
                dataGridView1.Rows.Add("SP", "1", "mha", "Wedensday", "12--14", "ICE-12");
                dataGridView1.Rows.Add("IPA/DIP", "IPA/DIP", "and", "Saturday", "8--10", "ICE-13");
                dataGridView1.Rows.Add("KD", "KD", "and", "Saturday", "12--14", "ICE-13");
                dataGridView1.Rows.Add("IRS", "IRS", "and", "Saturday", "14-16", "ICE-13");
                dataGridView1.Rows.Add("CAL1", "6", "", "Sunday", "8--10", "ICE-13");
                dataGridView1.Rows.Add("CAL1", "6", "", "Sunday", "10--12", "ICE-13");
                dataGridView1.Rows.Add("RE", "RE", "", "Sunday", "12--14", "ICE-13");
                dataGridView1.Rows.Add("RE", "RE", "", "Sunday", "14-16", "ICE-13");
                dataGridView1.Rows.Add("sa", "sa", "", "Monday", "8--10", "ICE-13");
                dataGridView1.Rows.Add("sa", "sa", "", "Monday", "10--12", "ICE-13");
                dataGridView1.Rows.Add("hj", "hj", "", "Monday", "12--14", "ICE-13");
                dataGridView1.Rows.Add("RE", "RE", "", "Monday", "14-16", "ICE-13");
                dataGridView1.Rows.Add("OS1", "2", "mha", "Tuesday", "8--10", "ICE-13");
                dataGridView1.Rows.Add("OS1", "2/", "mha", "Tuesday", "10--12", "ICE-13");
                dataGridView1.Rows.Add("SP", "2", "mha", "Tuesday", "12--14", "ICE-13");
                dataGridView1.Rows.Add("RE", "RE", "", "Tuesday", "14-16", "ICE-13");
                dataGridView1.Rows.Add("ISS", "ISS", "mz", "Wedensday", "8--10", "ICE-13");
                dataGridView1.Rows.Add("PR1L", "11", "zh", "Saturday", "8--10", "CL1");
                dataGridView1.Rows.Add("PR1L", "11", "zh", "Saturday", "10--12", "CL1");
                dataGridView1.Rows.Add("DB1L", "11", "kj", "Sunday", "8--10", "CL1");
                dataGridView1.Rows.Add("DB1L", "21", "kj", "Sunday", "10--12", "CL1");
                dataGridView1.Rows.Add("DB1L", "12", "kj", "Sunday", "12--14", "CL1");
                dataGridView1.Rows.Add("DB1L", "22", "kj", "Sunday", "14-16", "CL1");
                dataGridView1.Rows.Add("CSL", "61", "io", "Monday", "10--12", "CL1");
                dataGridView1.Rows.Add("DB2L", "32", "dj", "Monday", "12--14", "CL1");
                dataGridView1.Rows.Add("PLPL", "12", "alz", "Monday", "14-16", "CL1");
                dataGridView1.Rows.Add("CL", "1", "wk", "Tuesday", "8--10", "CL1");
                dataGridView1.Rows.Add("CL", "2", "wk", "Tuesday", "12--14", "CL1");
                dataGridView1.Rows.Add("PLL", "PLL", "ts", "Wedensday", "8--10", "CL1");
                dataGridView1.Rows.Add("SPL", "11", "ts", "Wedensday", "10--12", "CL1");
                dataGridView1.Rows.Add("SPL", "12", "ts", "Wedensday", "14-16", "CL1");
                dataGridView1.Rows.Add("PR1L", "12", "md", "Saturday", "8--10", "CL2");
                dataGridView1.Rows.Add("PR1L", "12", "md", "Saturday", "10--12", "CL2");
                dataGridView1.Rows.Add("IAPL", "62", "mb", "Saturday", "12--14", "CL2");
                dataGridView1.Rows.Add("IAPL", "62", "mb", "Saturday", "14-16", "CL2");
                dataGridView1.Rows.Add("AADL", "11", "ts", "Sunday", "8--10", "CL2");
                dataGridView1.Rows.Add("AADL", "12", "ts", "Sunday", "10--12", "CL2");
                dataGridView1.Rows.Add("AADL", "21", "ts", "Sunday", "12--14", "CL2");
                dataGridView1.Rows.Add("AADL", "22", "ts", "Sunday", "14-16", "CL2");
                dataGridView1.Rows.Add("ADSL", "11", "tm", "Monday", "8--10", "CL2");
                dataGridView1.Rows.Add("ADSL", "21", "tm", "Monday", "10--12", "CL2");
                dataGridView1.Rows.Add("ADSL", "12", "tm", "Monday", "12--14", "CL2");
                dataGridView1.Rows.Add("ADSL", "22", "tm", "Monday", "14-16", "CL2");
                dataGridView1.Rows.Add("ADSL", "31", "ts", "Tuesday", "10--12", "CL2");
                dataGridView1.Rows.Add("ADSL", "32", "ts", "Tuesday", "12--14", "CL2");
                dataGridView1.Rows.Add("SPL", "21", "ts", "Tuesday", "14-16", "CL2");
                dataGridView1.Rows.Add("CVL", "CVL", "xx", "Wedensday", "10--12", "CL2");
                dataGridView1.Rows.Add("PR2L", "21", "mnm", "Wedensday", "12--14", "CL2");
                dataGridView1.Rows.Add("IAPL", "51", "mb", "Saturday", "8--10", "CL3");
                dataGridView1.Rows.Add("IAPL", "11", "mb", "Saturday", "10--12", "CL3");
                dataGridView1.Rows.Add("PR2L", "12", "mnm", "Saturday", "12--14", "CL3");
                dataGridView1.Rows.Add("PR2L", "12", "mnm", "Saturday", "14-16", "CL3");
                dataGridView1.Rows.Add("IAPL", "21", "mb", "Sunday", "8--10", "CL3");
                dataGridView1.Rows.Add("IAPL", "41", "mb", "Sunday", "10--12", "CL3");
                dataGridView1.Rows.Add("IAPL", "31", "mb", "Sunday", "12--14", "CL3");
                dataGridView1.Rows.Add("PR1L", "22", "zh", "Monday", "8--10", "CL3");
                dataGridView1.Rows.Add("PR1L", "21", "zh", "Monday", "10--12", "CL3");
                dataGridView1.Rows.Add("CSL", "31", "io", "Monday", "12--14", "CL3");
                dataGridView1.Rows.Add("CSL", "51", "io", "Monday", "14-16", "CL3");
                dataGridView1.Rows.Add("CSL", "41", "io", "Tuesday", "8--10", "CL3");
                dataGridView1.Rows.Add("CSL", "21", "io", "Tuesday", "10--12", "CL3");
                dataGridView1.Rows.Add("CSL", "11", "io", "Tuesday", "12--14", "CL3");
                dataGridView1.Rows.Add("AIL", "22", "tb", "Tuesday", "14-16", "CL3");
                dataGridView1.Rows.Add("DB2L", "11", "tm", "Wedensday", "8--10", "CL3");
                dataGridView1.Rows.Add("DB2L", "12", "tm", "Wedensday", "10--12", "CL3");
                dataGridView1.Rows.Add("DB2L", "21", "tm", "Wedensday", "12--14", "CL3");
                dataGridView1.Rows.Add("DB2L", "22", "tm", "Wedensday", "14-16", "CL3");
                dataGridView1.Rows.Add("IAPL", "52", "ork", "Saturday", "8--10", "CL4");
                dataGridView1.Rows.Add("IAPL", "12", "ork", "Saturday", "10--12", "CL4");
                dataGridView1.Rows.Add("EAPL", "EAPL", "", "Saturday", "12--14", "CL4");
                dataGridView1.Rows.Add("IAPL", "22", "ork", "Sunday", "8--10", "CL4");
                dataGridView1.Rows.Add("IAPL", "42", "ork", "Sunday", "10--12", "CL4");
                dataGridView1.Rows.Add("IAPL", "32", "ork", "Sunday", "12--14", "CL4");
                dataGridView1.Rows.Add("OS1L", "12", "zs", "Sunday", "14-16", "CL4");
                dataGridView1.Rows.Add("PR1L", "22", "md", "Monday", "8--10", "CL4");
                dataGridView1.Rows.Add("PR1L", "22", "md", "Monday", "10--12", "CL4");
                dataGridView1.Rows.Add("CSL", "32", "mk", "Monday", "12--14", "CL4");
                dataGridView1.Rows.Add("CSL", "52", "mk", "Monday", "14-16", "CL4");
                dataGridView1.Rows.Add("CSL", "42", "mk", "Tuesday", "8--10", "CL4");
                dataGridView1.Rows.Add("CSL", "22", "mk", "Tuesday", "10--12", "CL4");
                dataGridView1.Rows.Add("CSL", "12", "mk", "Tuesday", "12--14", "CL4");
                dataGridView1.Rows.Add("CSL", "11", "kj", "Wedensday", "8--10", "CL4");
                dataGridView1.Rows.Add("KDL", "KDL", "kj", "Wedensday", "10--12", "CL4");
                dataGridView1.Rows.Add("CDL", "12", "kj", "Wedensday", "12--14", "CL4");
                dataGridView1.Rows.Add("IRSL", "IRSL", "kj", "Wedensday", "14-16", "CL4");
                dataGridView1.Rows.Add("MML", "11", "an", "Saturday", "8--10", "CL5");
                dataGridView1.Rows.Add("MML", "11", "an", "Saturday", "10--12", "CL5");
                dataGridView1.Rows.Add("MML", "12", "an", "Saturday", "12--14", "CL5");
                dataGridView1.Rows.Add("MML", "12", "an", "Saturday", "14-16", "CL5");
                dataGridView1.Rows.Add("APDL", "11", "an", "Sunday", "8--10", "CL5");
                dataGridView1.Rows.Add("APDL", "12", "an", "Sunday", "10--12", "CL5");
                dataGridView1.Rows.Add("DISL", "DISL", "alz", "Monday", "8--10", "CL5");
                dataGridView1.Rows.Add("PLP", "11", "alz", "Monday", "10--12", "CL5");
                dataGridView1.Rows.Add("FZLL", "FZLL", "", "Monday", "14-16", "CL5");
                dataGridView1.Rows.Add("PR1L", "31", "msh", "Tuesday", "8--10", "CL5");
                dataGridView1.Rows.Add("PR1L", "31", "msh", "Tuesday", "10--12", "CL5");
                dataGridView1.Rows.Add("PR1", "32", "msh", "Tuesday", "12--14", "CL5");
                dataGridView1.Rows.Add("PR1L", "32", "msh", "Tuesday", "14-16", "CL5");
                dataGridView1.Rows.Add("CGL", "21", "abm", "Wedensday", "8--10", "CL5");
                dataGridView1.Rows.Add("CGL", "21", "abm", "Wedensday", "10--12", "CL5");
                dataGridView1.Rows.Add("CGL", "12", "abm", "Wedensday", "12--14", "CL5");
                dataGridView1.Rows.Add("CGL", "12", "abm", "Wedensday", "14-16", "CL5");
                dataGridView1.Rows.Add("AIL", "11", "wk", "Saturday", "10--12", "CL6");
                dataGridView1.Rows.Add("AIL", "12", "wk", "Saturday", "12--14", "CL6");
                dataGridView1.Rows.Add("AIL", "12", "wk", "Saturday", "14-16", "CL6");
                dataGridView1.Rows.Add("IPAL", "11", "hah", "Monday", "8--10", "CL6");
                dataGridView1.Rows.Add("IPAL", "12", "hah", "Monday", "10--12", "CL6");
                dataGridView1.Rows.Add("CGL", "11", "hah", "Monday", "12--14", "CL6");
                dataGridView1.Rows.Add("CGL", "11", "hah", "Monday", "14-16", "CL6");
                dataGridView1.Rows.Add("ITL", "11", "kzh", "Tuesday", "8--10", "CL6");
                dataGridView1.Rows.Add("ITL", "12", "kzh", "Tuesday", "10--12", "CL6");
                dataGridView1.Rows.Add("ITL", "21", "kzh", "Tuesday", "12--14", "CL6");
                dataGridView1.Rows.Add("ITL", "22", "kzh", "Tuesday", "14-16", "CL6");
                dataGridView1.Rows.Add("ISSL", "11", "an", "Saturday", "8--10", "CNL");
                dataGridView1.Rows.Add("ISSL", "12", "aa", "Saturday", "10--12", "CNL");
                dataGridView1.Rows.Add("CNL", "21", "ork", "Saturday", "12--14", "CNL");
                dataGridView1.Rows.Add("CNL", "11", "ork", "Saturday", "14-16", "CNL");
                dataGridView1.Rows.Add("OS1L", "21", "zs", "Sunday", "8--10", "CNL");
                dataGridView1.Rows.Add("OS1L", "22", "zs", "Sunday", "10--12", "CNL");
                dataGridView1.Rows.Add("OS1L", "11", "zs", "Sunday", "12--14", "CNL");
                dataGridView1.Rows.Add("CNL", "12", "ork", "Sunday", "14-16", "CNL");
                dataGridView1.Rows.Add("DB2L", "31", "dj", "Monday", "8--10", "CNL");
                dataGridView1.Rows.Add("SW1L", "21", "dj", "Monday", "10--12", "CNL");
                dataGridView1.Rows.Add("CGL", "22", "abm", "Monday", "12--14", "CNL");
                dataGridView1.Rows.Add("CGL", "22", "abm", "Monday", "14-16", "CNL");
                dataGridView1.Rows.Add("NNL", "11", "tb", "Tuesday", "8--10", "CNL");
                dataGridView1.Rows.Add("EXPL", "11", "wk", "Tuesday", "10--12", "CNL");
                dataGridView1.Rows.Add("NNL", "12", "tb", "Tuesday", "12--14", "CNL");
                dataGridView1.Rows.Add("EXPL", "12", "wk", "Tuesday", "14-16", "CNL");
                dataGridView1.Rows.Add("SW1L", "12", "dj", "Wedensday", "8--10", "CNL");
                dataGridView1.Rows.Add("SW1L", "11", "dj", "Wedensday", "10--12", "CNL");
                dataGridView1.Rows.Add("ADBL", "ADBL", "dj", "Wedensday", "12--14", "CNL");
                dataGridView1.Rows.Add("SW1L", "22", "dj", "Wedensday", "14-16", "CNL");
                dataGridView1.Rows.Add("CAL", "21", "wsh", "Saturday", "8--10", "DSL");
                dataGridView1.Rows.Add("CAL", "12", "wsh", "Saturday", "10--12", "DSL");
                dataGridView1.Rows.Add("CAL", "11", "wsh", "Saturday", "12--14", "DSL");
                dataGridView1.Rows.Add("CAL", "22", "wsh", "Saturday", "14-16", "DSL");
                dataGridView1.Rows.Add("ARWPL", "ARWPL", "sar", "Sunday", "8--10", "DSL");
                dataGridView1.Rows.Add("DCML", "DCML", "sar", "Sunday", "10--12", "DSL");
                dataGridView1.Rows.Add("MEL", "MEL", "sar", "Sunday", "14-16", "DSL");
                dataGridView1.Rows.Add("DCOL", "11", "wsh", "Tuesday", "8--10", "DSL");
                dataGridView1.Rows.Add("SIP", "11", "wsh", "Tuesday", "10--12", "DSL");
                dataGridView1.Rows.Add("DCOL", "12", "wsh", "Tuesday", "12--14", "DSL");
                dataGridView1.Rows.Add("PH1L", "31", "", "Saturday", "8--10", "PHL");
                dataGridView1.Rows.Add("PH1L", "61", "", "Saturday", "10--12", "PHL");
                dataGridView1.Rows.Add("PHL", "DENT", "", "Saturday", "12--14", "PHL");
                dataGridView1.Rows.Add("PHL", "DENT", "", "Saturday", "14-16", "PHL");
                dataGridView1.Rows.Add("PHL", "C", "", "Sunday", "8--10", "PHL");
                dataGridView1.Rows.Add("PHL", "C", "", "Sunday", "10--12", "PHL");
                dataGridView1.Rows.Add("PHL", "C", "", "Sunday", "12--14", "PHL");
                dataGridView1.Rows.Add("PH1L", "32", "", "Sunday", "14-16", "PHL");
                dataGridView1.Rows.Add("PH1L", "11", "", "Monday", "8--10", "PHL");
                dataGridView1.Rows.Add("PH1L", "42", "", "Monday", "10--12", "PHL");
                dataGridView1.Rows.Add("PH1L", "12", "", "Monday", "12--14", "PHL");
                dataGridView1.Rows.Add("PHL", "DENT", "", "Monday", "14-16", "PHL");
                dataGridView1.Rows.Add("PH1L", "22", "", "Tuesday", "8--10", "PHL");
                dataGridView1.Rows.Add("PHL", "C", "", "Tuesday", "10--12", "PHL");
                dataGridView1.Rows.Add("PH1L", "41", "", "Tuesday", "12--14", "PHL");
                dataGridView1.Rows.Add("PH1L", "21", "", "Tuesday", "14-16", "PHL");
                dataGridView1.Rows.Add("PHL", "C", "", "Wedensday", "8--10", "PHL");
                dataGridView1.Rows.Add("PHL", "C", "", "Wedensday", "10--12", "PHL");
                dataGridView1.Rows.Add("PH1L", "52", "", "Wedensday", "12--14", "PHL");
                dataGridView1.Rows.Add("PH1L", "51", "", "Wedensday", "14-16", "PHL");
                dataGridView1.Rows.Add("LCL", "11", "wh", "Saturday", "8--10", "EECL");
                dataGridView1.Rows.Add("LCL", "12", "wh", "Saturday", "10--12", "EECL");
                dataGridView1.Rows.Add("LCL", "21", "wh", "Saturday", "12--14", "EECL");
                dataGridView1.Rows.Add("LCL", "22", "wh", "Saturday", "14-16", "EECL");
                dataGridView1.Rows.Add("EECL", "11", "ma", "Sunday", "8--10", "EECL");
                dataGridView1.Rows.Add("EECL", "12", "ma", "Sunday", "12--14", "EECL");
                dataGridView1.Rows.Add("EECL", "21", "ma", "Sunday", "14-16", "EECL");
                dataGridView1.Rows.Add("EECL", "31", "ma", "Tuesday", "8--10", "EECL");
                dataGridView1.Rows.Add("EC1L", "EC1L", "sar", "Tuesday", "10--12", "EECL");
                dataGridView1.Rows.Add("EECL", "32", "ma", "Tuesday", "12--14", "EECL");
                dataGridView1.Rows.Add("EECL", "22", "ma", "Tuesday", "14-16", "EECL");
                dataGridView1.Rows.Add("EC2L", "EC2L", "sar", "Wedensday", "8--10", "EECL");
                dataGridView1.Rows.Add("EFL", "EFL", "sar", "Wedensday", "10--12", "EECL");
                dataGridView1.Rows.Add("ELC1L", "ELC1L", "sar", "Wedensday", "12--14", "EECL");
            }
            
           /* if (Debug)// 2017 -2 program
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
                dataGridView1.Columns.Add("1", "1");
                dataGridView1.Columns.Add("2", "2");
                dataGridView1.Columns.Add("3", "3");
                dataGridView1.Columns.Add("4", "4");
                dataGridView1.Columns.Add("5", "5");
                dataGridView1.Columns.Add("6", "6");
                dataGridView1.Rows.Add("Course", "Group", "Present", "Day", "Period", "Room");
                dataGridView1.Rows.Add("AAD", "1", "bk", "Saturday", "10--12", "B4");
                dataGridView1.Rows.Add("AAD", "2", "bk", "Saturday", "12--14", "C1");
                dataGridView1.Rows.Add("AADL", "12", "tm", "Saturday", "8--10", "CL2");
                dataGridView1.Rows.Add("AADL", "22", "tm", "Saturday", "10--12", "CL2");
                dataGridView1.Rows.Add("AADL", "11", "ts", "Saturday", "8--10", "CL1");
                dataGridView1.Rows.Add("AADL", "21", "ts", "Saturday", "10--12", "CL1");
                dataGridView1.Rows.Add("ACM", "ACM", "ky", "Sunday", "12--14", "C1");
                dataGridView1.Rows.Add("ACM", "ACM", "ky", "Monday", "14-16", "C1");
                dataGridView1.Rows.Add("ACML", "ACML", "sar", "Sunday", "14-16", "DSL");
                dataGridView1.Rows.Add("ADB", "ADB", "mhm", "Saturday", "10--12", "A5");
                dataGridView1.Rows.Add("ADBL", "ADBL", "rj", "Saturday", "8--10", "CNL");
                dataGridView1.Rows.Add("ADS", "2", "bk", "Monday", "10--12", "B3");
                dataGridView1.Rows.Add("ADS", "1", "bk", "Monday", "8--10", "B2");
                dataGridView1.Rows.Add("ADS2", "ADS2", "sj", "Sunday", "10--12", "B1");
                dataGridView1.Rows.Add("ADS2L", "12", "tm", "Sunday", "12--14", "CNL");
                dataGridView1.Rows.Add("ADS2L", "11", "tm", "Sunday", "8--10", "CNL");
                dataGridView1.Rows.Add("ADSL", "11", "ts", "Monday", "10--12", "CL1");
                dataGridView1.Rows.Add("ADSL", "21", "ts", "Monday", "8--10", "CL1");
                dataGridView1.Rows.Add("ADSL", "22", "tm", "Tuesday", "12--14", "CL3");
                dataGridView1.Rows.Add("ADSL", "12", "tm", "Monday", "10--12", "CL2");
                dataGridView1.Rows.Add("AI", "AI", "bk", "Monday", "12--14", "A3");
                dataGridView1.Rows.Add("AIL", "11", "wk", "Monday", "10--12", "CNL");
                dataGridView1.Rows.Add("AIL", "12", "wk", "Monday", "14-16", "CL2");
                dataGridView1.Rows.Add("AR", "2", "", "Thursday", "10--12", "B1");
                dataGridView1.Rows.Add("AR", "1", "", "Thursday", "8--10", "B1");
                dataGridView1.Rows.Add("ARWP", "ARWP", "nt", "Sunday", "8--10", "A5");
                dataGridView1.Rows.Add("ARWPL", "ARWPL", "sar", "Sunday", "10--12", "DSL");
                dataGridView1.Rows.Add("AWR", "AWR", "", "Tuesday", "14-16", "A3");
                dataGridView1.Rows.Add("C&S", "C&S", "ms", "Sunday", "14-16", "B1");
                dataGridView1.Rows.Add("CA", "2", "ha", "Wedensday", "10--12", "B1");
                dataGridView1.Rows.Add("CA", "1", "ha", "Wedensday", "8--10", "B1");
                dataGridView1.Rows.Add("CAL", "12", "mns", "Saturday", "10--12", "DSL");
                dataGridView1.Rows.Add("CAL", "21", "mns", "Saturday", "12--14", "DSL");
                dataGridView1.Rows.Add("CAL", "11", "mns", "Saturday", "8--10", "DSL");
                dataGridView1.Rows.Add("CAL", "22", "mns", "Saturday", "14-16", "DSL");
                dataGridView1.Rows.Add("CAL1", "3", "shr", "Monday", "12--14", "B1");
                dataGridView1.Rows.Add("CAL1", "1", "shr", "Saturday", "8--10", "B1");
                dataGridView1.Rows.Add("CAL1", "4", "shr", "Monday", "14-16", "B1");
                dataGridView1.Rows.Add("CAL1", "4", "shr", "Saturday", "12--14", "B1");
                dataGridView1.Rows.Add("CAL1", "2", "shr", "Monday", "10--12", "B1");
                dataGridView1.Rows.Add("CAL1", "2", "shr", "Saturday", "10--12", "B1");
                dataGridView1.Rows.Add("CAL1", "1", "shr", "Monday", "8--10", "B1");
                dataGridView1.Rows.Add("CAL1", "3", "shr", "Saturday", "14-16", "B1");
                dataGridView1.Rows.Add("CAL2", "2", "nsh", "Tuesday", "14-16", "B2");
                dataGridView1.Rows.Add("CAL2", "1", "nsh", "Tuesday", "12--14", "B3");
                dataGridView1.Rows.Add("CAL2", "2", "nsh", "Saturday", "10--12", "B2");
                dataGridView1.Rows.Add("CAL2", "1", "nsh", "Saturday", "8--10", "B3");
                dataGridView1.Rows.Add("CD", "1", "sj", "Monday", "10--12", "B5");
                dataGridView1.Rows.Add("CDL", "11", "kj", "Monday", "8--10", "CNL");
                dataGridView1.Rows.Add("CDL", "12", "kj", "Sunday", "14-16", "CL2");
                dataGridView1.Rows.Add("CG", "1", "rh", "Sunday", "12--14", "C2");
                dataGridView1.Rows.Add("CGL", "11", "an", "Sunday", "8--10", "CL2");
                dataGridView1.Rows.Add("CGL", "12", "an", "Sunday", "10--12", "CNL");
                dataGridView1.Rows.Add("CL", "1", "wk", "Wedensday", "8--10", "CL3");
                dataGridView1.Rows.Add("CL", "2", "wk", "Tuesday", "8--10", "CL4");
                dataGridView1.Rows.Add("CN", "CN", "la", "Sunday", "8--10", "A3");
                dataGridView1.Rows.Add("CN", "CN", "la", "Sunday", "10--12", "A3");
                dataGridView1.Rows.Add("CNL", "12", "aa", "Tuesday", "14-16", "CNL");
                dataGridView1.Rows.Add("CNL", "11", "aa", "Sunday", "14-16", "CNL");
                dataGridView1.Rows.Add("CO", "2", "sas", "Monday", "14-16", "C2");
                dataGridView1.Rows.Add("CO", "1", "sas", "Monday", "12--14", "C2");
                dataGridView1.Rows.Add("CO", "2-Jan", "sas", "Wedensday", "8--10", "C2");
                dataGridView1.Rows.Add("CS", "1", "zm", "Wedensday", "12--14", "B3");
                dataGridView1.Rows.Add("CS", "2", "zm", "Tuesday", "12--14", "A3");
                dataGridView1.Rows.Add("CSL", "11", "wk", "Wedensday", "10--12", "CL2");
                dataGridView1.Rows.Add("CSL", "22", "IO", "Tuesday", "14-16", "CL4");
                dataGridView1.Rows.Add("CSL", "21", "wk", "Tuesday", "14-16", "CL3");
                dataGridView1.Rows.Add("CSL", "12", "IO", "Wedensday", "10--12", "CL3");
                dataGridView1.Rows.Add("CTH", "2", "sj", "Monday", "12--14", "B5");
                dataGridView1.Rows.Add("CTH", "2", "sj", "Sunday", "12--14", "B5");
                dataGridView1.Rows.Add("CTH", "1", "sj", "Sunday", "8--10", "A2");
                dataGridView1.Rows.Add("CTH", "1", "sj", "Monday", "8--10", "A2");
                dataGridView1.Rows.Add("CV", "CV", "rh", "Saturday", "12--14", "CL2");
                dataGridView1.Rows.Add("CVL", "CVL", "rh", "Saturday", "14-16", "CL2");
                dataGridView1.Rows.Add("DB1", "1", "ms", "Sunday", "8--10", "B2");
                dataGridView1.Rows.Add("DB1", "2", "ms", "Sunday", "10--12", "C1");
                dataGridView1.Rows.Add("DB1L", "11", "mt", "Sunday", "10--12", "CL1");
                dataGridView1.Rows.Add("DB1L", "22", "kj", "Sunday", "8--10", "CL4");
                dataGridView1.Rows.Add("DB1L", "21", "mt", "Sunday", "14-16", "CL3");
                dataGridView1.Rows.Add("DB1L", "12", "kj", "Sunday", "10--12", "CL2");
                dataGridView1.Rows.Add("DB2", "1", "sat", "Tuesday", "12--14", "B1");
                dataGridView1.Rows.Add("DB2", "2", "sat", "Saturday", "14-16", "B2");
                dataGridView1.Rows.Add("DB2L", "11", "rb", "Tuesday", "8--10", "CL1");
                dataGridView1.Rows.Add("DB2L", "21", "rb", "Tuesday", "12--14", "CL1");
                dataGridView1.Rows.Add("DB2L", "12", "rb", "Tuesday", "10--12", "CL1");
                dataGridView1.Rows.Add("DB2L", "22", "rb", "Tuesday", "14-16", "CL1");
                dataGridView1.Rows.Add("DCM", "DCM", "hj", "Sunday", "14-16", "A3");
                dataGridView1.Rows.Add("DCM", "DCM", "hj", "Monday", "10--12", "A2");
                dataGridView1.Rows.Add("DCML", "DCML", "sar", "Sunday", "12--14", "DSL");
                dataGridView1.Rows.Add("DCO", "2", "ky", "Monday", "12--14", "C1");
                dataGridView1.Rows.Add("DCO", "1", "fk", "Monday", "10--12", "B2");
                dataGridView1.Rows.Add("DCOL", "21", "wj", "Monday", "10--12", "DSL");
                dataGridView1.Rows.Add("DCOL", "22", "wj", "Monday", "14-16", "DSL");
                dataGridView1.Rows.Add("DCOL", "12", "wj", "Monday", "12--14", "DSL");
                dataGridView1.Rows.Add("DCOL", "11", "wj", "Monday", "8--10", "DSL");
                dataGridView1.Rows.Add("DE", "DE", "fd", "Tuesday", "14-16", "B4");
                dataGridView1.Rows.Add("DE", "DE", "fd", "Tuesday", "12--14", "B4");
                dataGridView1.Rows.Add("DIS", "DIS", "mha", "Tuesday", "10--12", "CL3");
                dataGridView1.Rows.Add("DISL", "DISL", "hd", "Tuesday", "8--10", "CNL");
                dataGridView1.Rows.Add("DM", "1", "yw", "Saturday", "10--12", "A3");
                dataGridView1.Rows.Add("DM", "2-Jan", "yw", "Monday", "10--12", "A3");
                dataGridView1.Rows.Add("DM", "2", "yw", "Saturday", "8--10", "A3");
                dataGridView1.Rows.Add("EAP", "EAP", "la", "Saturday", "12--14", "A5");
                dataGridView1.Rows.Add("EAP", "EAP", "la", "Saturday", "14-16", "A5");
                dataGridView1.Rows.Add("EC1", "EC1", "ah", "Sunday", "12--14", "A5");
                dataGridView1.Rows.Add("EC1", "EC1", "ah", "Wedensday", "10--12", "A5");
                dataGridView1.Rows.Add("EC1L", "EC1L", "sar", "Wedensday", "8--10", "EECL");
                dataGridView1.Rows.Add("EC2", "EC2", "ah", "Wedensday", "8--10", "A5");
                dataGridView1.Rows.Add("EC2L", "EC2L", "sar", "Wedensday", "10--12", "EECL");
                dataGridView1.Rows.Add("ECO", "1", "", "Thursday", "8--10", "B3");
                dataGridView1.Rows.Add("ECO", "2", "", "Thursday", "10--12", "B3");
                dataGridView1.Rows.Add("EEC", "31", "ma", "Tuesday", "12--14", "EECL");
                dataGridView1.Rows.Add("EEC", "32", "ma", "Tuesday", "14-16", "EECL");
                dataGridView1.Rows.Add("EEC", "3", "saj", "Sunday", "12--14", "B4");
                dataGridView1.Rows.Add("EEC", "2", "saj", "Monday", "10--12", "B4");
                dataGridView1.Rows.Add("EEC", "1", "saj", "Monday", "12--14", "B4");
                dataGridView1.Rows.Add("EECL", "21", "ma", "Monday", "8--10", "EECL");
                dataGridView1.Rows.Add("EECL", "11", "ma", "Monday", "10--12", "EECL");
                dataGridView1.Rows.Add("EECL", "22", "ma", "Monday", "12--14", "EECL");
                dataGridView1.Rows.Add("EECL", "12", "ma", "Monday", "14-16", "EECL");
                dataGridView1.Rows.Add("EF", "EF", "ssh", "Monday", "8--10", "B5");
                dataGridView1.Rows.Add("EF", "EF", "ssh", "Sunday", "10--12", "A2");
                dataGridView1.Rows.Add("EF", "EF", "ssh", "Sunday", "10--12", "B5");
                dataGridView1.Rows.Add("EFL", "EFL", "sar", "Wedensday", "14-16", "EECL");
                dataGridView1.Rows.Add("ELC2", "ELC2", "ssh", "Monday", "12--14", "A2");
                dataGridView1.Rows.Add("ELC2", "ELC2", "ssh", "Sunday", "14-16", "A2");
                dataGridView1.Rows.Add("ELC2L", "ELC2L", "sar", "Wedensday", "12--14", "EECL");
                dataGridView1.Rows.Add("EMF", "EMF", "nt", "Monday", "14-16", "A2");
                dataGridView1.Rows.Add("EMF", "EMF", "nt", "Monday", "10--12", "A5");
                dataGridView1.Rows.Add("ENM", "ENM", "kdb", "Monday", "14-16", "A3");
                dataGridView1.Rows.Add("ESP1", "ESP1", "nt", "Sunday", "12--14", "A3");
                dataGridView1.Rows.Add("EXP", "EXP", "ng", "Wedensday", "10--12", "A2");
                dataGridView1.Rows.Add("EXPL", "EXPL", "wk", "Wedensday", "12--14", "CL3");
                dataGridView1.Rows.Add("IAP", "1", "fk", "Sunday", "8--10", "B1");
                dataGridView1.Rows.Add("IAP", "2", "fk", "Sunday", "14-16", "C2");
                dataGridView1.Rows.Add("IAPL", "11", "mns", "Sunday", "10--12", "CL3");
                dataGridView1.Rows.Add("IAPL", "12", "os", "Sunday", "10--12", "CL4");
                dataGridView1.Rows.Add("IAPL", "21", "mns", "Sunday", "12--14", "CL3");
                dataGridView1.Rows.Add("IAPL", "22", "os", "Sunday", "12--14", "CL4");
                dataGridView1.Rows.Add("INTH", "INTH", "saj", "Wedensday", "10--12", "B4");
                dataGridView1.Rows.Add("IPA", "IPA", "rh", "Saturday", "10--12", "C1");
                dataGridView1.Rows.Add("IPAL", "IPAL", "an", "Sunday", "12--14", "CL2");
                dataGridView1.Rows.Add("IPS", "1", "", "Thursday", "8--10", "B4");
                dataGridView1.Rows.Add("IPS", "2", "", "Thursday", "10--12", "B4");
                dataGridView1.Rows.Add("IRS", "IRS", "bk", "Saturday", "8--10", "C2");
                dataGridView1.Rows.Add("IRSL", "11", "kj", "Saturday", "10--12", "CNL");
                dataGridView1.Rows.Add("IRSL", "12", "kj", "Saturday", "12--14", "CNL");
                dataGridView1.Rows.Add("ISS", "ISS", "mz", "Wedensday", "12--14", "B4");
                dataGridView1.Rows.Add("ISSL", "11", "aa", "Wedensday", "14-16", "CNL");
                dataGridView1.Rows.Add("ISSL", "12", "aa", "Monday", "14-16", "CNL");
                dataGridView1.Rows.Add("IT", "1", "", "Wedensday", "10--12", "A3");
                dataGridView1.Rows.Add("IT", "2", "", "Monday", "14-16", "B3");
                dataGridView1.Rows.Add("ITL", "21", "kh", "Wedensday", "14-16", "CL1");
                dataGridView1.Rows.Add("ITL", "12", "kh", "Wedensday", "12--14", "CL1");
                dataGridView1.Rows.Add("ITL", "22", "kh", "Wedensday", "10--12", "CL1");
                dataGridView1.Rows.Add("ITL", "11", "kh", "Wedensday", "8--10", "CL1");
                dataGridView1.Rows.Add("LA", "2", "ry", "Monday", "12--14", "B3");
                dataGridView1.Rows.Add("LA", "3", "ry", "Wedensday", "8--10", "B5");
                dataGridView1.Rows.Add("LA", "2", "ry", "Saturday", "10--12", "B3");
                dataGridView1.Rows.Add("LA", "1", "yw", "Monday", "8--10", "B3");
                dataGridView1.Rows.Add("LA", "1", "yw", "Saturday", "12--14", "B3");
                dataGridView1.Rows.Add("LA", "3", "ry", "Sunday", "8--10", "B5");
                dataGridView1.Rows.Add("LC", "3", "mz", "Tuesday", "12--14", "B2");
                dataGridView1.Rows.Add("LC", "1", "hj", "Sunday", "8--10", "C2");
                dataGridView1.Rows.Add("LC", "3", "mz", "Sunday", "10--12", "B2");
                dataGridView1.Rows.Add("LC", "4", "mz", "Sunday", "12--14", "B2");
                dataGridView1.Rows.Add("LC", "4", "mz", "Monday", "12--14", "B2");
                dataGridView1.Rows.Add("LC", "1", "hj", "Saturday", "10--12", "C2");
                dataGridView1.Rows.Add("LC", "2", "hj", "Saturday", "12--14", "C2");
                dataGridView1.Rows.Add("LC", "2", "hj", "Sunday", "10--12", "C2");
                dataGridView1.Rows.Add("LCL", "12", "mt", "Saturday", "14-16", "EECL");
                dataGridView1.Rows.Add("LCL", "31", "af", "Sunday", "8--10", "EECL");
                dataGridView1.Rows.Add("LCL", "42", "af", "Sunday", "14-16", "EECL");
                dataGridView1.Rows.Add("LCL", "41", "af", "Sunday", "10--12", "EECL");
                dataGridView1.Rows.Add("LCL", "11", "mt", "Saturday", "10--12", "EECL");
                dataGridView1.Rows.Add("LCL", "21", "mt", "Saturday", "8--10", "EECL");
                dataGridView1.Rows.Add("LCL", "22", "mt", "Saturday", "12--14", "EECL");
                dataGridView1.Rows.Add("LCL", "32", "af", "Sunday", "12--14", "EECL");
                dataGridView1.Rows.Add("MCM", "MCM", "ky", "Sunday", "10--12", "B4");
                dataGridView1.Rows.Add("MCM", "MCM", "ky", "Monday", "8--10", "B4");
                dataGridView1.Rows.Add("MCO", "MCO", "ssh", "Tuesday", "12--14", "C1");
                dataGridView1.Rows.Add("MCO", "MCO", "ssh", "Tuesday", "14-16", "C1");
                dataGridView1.Rows.Add("MCS", "MCS", "ky", "Tuesday", "12--14", "A2");
                dataGridView1.Rows.Add("MCSL", "MCSL", "sar", "Sunday", "8--10", "DSL");
                dataGridView1.Rows.Add("MGS", "MGS", "BA", "Wedensday", "14-16", "CL2");
                dataGridView1.Rows.Add("ML", "ML", "ng", "Monday", "8--10", "A5");
                dataGridView1.Rows.Add("MLL", "MLL", "nb", "Sunday", "12--14", "CL1");
                dataGridView1.Rows.Add("MM", "MM", "rh", "Sunday", "14-16", "B5");
                dataGridView1.Rows.Add("MM", "11", "an", "Tuesday", "10--12", "CL2");
                dataGridView1.Rows.Add("MML", "11", "an", "Tuesday", "8--10", "CL2");
                dataGridView1.Rows.Add("MML", "12", "an", "Tuesday", "14-16", "CL2");
                dataGridView1.Rows.Add("MML", "12", "an", "Tuesday", "12--14", "CL2");
                dataGridView1.Rows.Add("NA", "1", "ry", "Monday", "10--12", "C1");
                dataGridView1.Rows.Add("NA", "2", "ry", "Sunday", "14-16", "C1");
                dataGridView1.Rows.Add("NA", "NA", "ry", "Saturday", "8--10", "B2");
                dataGridView1.Rows.Add("NA", "2", "ry", "Wedensday", "12--14", "C1");
                dataGridView1.Rows.Add("NA", "NA", "ry", "Sunday", "12--14", "B3");
                dataGridView1.Rows.Add("NA", "1", "ry", "Wedensday", "10--12", "C1");
                dataGridView1.Rows.Add("NLP", "NLP", "ng", "Wedensday", "8--10", "A2");
                dataGridView1.Rows.Add("NLPL", "NLPL", "nb", "Sunday", "8--10", "CL1");
                dataGridView1.Rows.Add("NN", "NN", "ms", "Sunday", "12--14", "A2");
                dataGridView1.Rows.Add("NNL", "NNL", "kj", "Saturday", "14-16", "CNL");
                dataGridView1.Rows.Add("NS", "NS", "la", "Sunday", "12--14", "PHL");
                dataGridView1.Rows.Add("NSL", "NSL", "aa", "Monday", "12--14", "CNL");
                dataGridView1.Rows.Add("OR", "OR", "fwk", "Monday", "12--14", "A5");
                dataGridView1.Rows.Add("OR", "OR", "fwk", "Monday", "14-16", "A5");
                dataGridView1.Rows.Add("OS1", "OS1", "sas", "Monday", "8--10", "C2");
                dataGridView1.Rows.Add("OS1", "OS1", "sas", "Monday", "10--12", "C2");
                dataGridView1.Rows.Add("OS1L", "12", "hd", "Wedensday", "12--14", "CNL");
                dataGridView1.Rows.Add("OS1L", "11", "hd", "Wedensday", "10--12", "CNL");
                dataGridView1.Rows.Add("OS2", "OS2", "mha", "Tuesday", "8--10", "CL3");
                dataGridView1.Rows.Add("OS2L", "OS2L", "hd", "Tuesday", "10--12", "CNL");
                dataGridView1.Rows.Add("PH1", "2", "msd", "Saturday", "12--14", "A3");
                dataGridView1.Rows.Add("PH1", "1", "msd", "Saturday", "8--10", "C1");
                dataGridView1.Rows.Add("PH1L", "21", "", "Monday", "8--10", "PHL");
                dataGridView1.Rows.Add("PH1L", "12", "", "Monday", "14-16", "PHL");
                dataGridView1.Rows.Add("PH1L", "22", "", "Monday", "10--12", "PHL");
                dataGridView1.Rows.Add("PH1L", "11", "", "Monday", "12--14", "PHL");
                dataGridView1.Rows.Add("PH2", "PH2", "msd", "Saturday", "10--12", "PHL");
                dataGridView1.Rows.Add("PH2l", "PH2l", "msd", "Saturday", "14-16", "PHL");
                dataGridView1.Rows.Add("PHC", "PHC", "", "Wedensday", "10--12", "PHL");
                dataGridView1.Rows.Add("PHC", "PHC", "", "Wedensday", "8--10", "PHL");
                dataGridView1.Rows.Add("PHC", "PHC", "", "Wedensday", "12--14", "PHL");
                dataGridView1.Rows.Add("PHC", "PHC", "", "Wedensday", "14-16", "PHL");
                dataGridView1.Rows.Add("PL", "1", "rh", "Sunday", "8--10", "C1");
                dataGridView1.Rows.Add("PLL", "11", "ts", "Monday", "12--14", "CL2");
                dataGridView1.Rows.Add("PLL", "12", "ts", "Saturday", "14-16", "CL1");
                dataGridView1.Rows.Add("PLP", "PLP", "sas", "Saturday", "8--10", "A5");
                dataGridView1.Rows.Add("PLPL", "PLPL", "hd", "Tuesday", "12--14", "CNL");
                dataGridView1.Rows.Add("PR1", "21", "zh", "Monday", "14-16", "CL3");
                dataGridView1.Rows.Add("PR1", "3", "fk", "Wedensday", "8--10", "B3");
                dataGridView1.Rows.Add("PR1", "42", "md", "Saturday", "10--12", "CL4");
                dataGridView1.Rows.Add("PR1", "42", "md", "Saturday", "8--10", "CL4");
                dataGridView1.Rows.Add("PR1", "1", "hn", "Sunday", "10--12", "B3");
                dataGridView1.Rows.Add("PR1", "4", "fk", "Wedensday", "10--12", "B3");
                dataGridView1.Rows.Add("PR1", "2", "hn", "Sunday", "8--10", "B3");
                dataGridView1.Rows.Add("PR1L", "41", "zh", "Saturday", "8--10", "CL3");
                dataGridView1.Rows.Add("PR1L", "32", "md", "Monday", "10--12", "CL4");
                dataGridView1.Rows.Add("PR1L", "12", "zh", "Wedensday", "12--14", "CL4");
                dataGridView1.Rows.Add("PR1L", "11", "zh", "Wedensday", "10--12", "CL4");
                dataGridView1.Rows.Add("PR1L", "32", "md", "Monday", "8--10", "CL4");
                dataGridView1.Rows.Add("PR1L", "31", "zh", "Monday", "10--12", "CL3");
                dataGridView1.Rows.Add("PR1L", "31", "zh", "Monday", "8--10", "CL3");
                dataGridView1.Rows.Add("PR1L", "22", "md", "Monday", "12--14", "CL4");
                dataGridView1.Rows.Add("PR1L", "22", "md", "Monday", "14-16", "CL4");
                dataGridView1.Rows.Add("PR1L", "11", "zh", "Wedensday", "8--10", "CL4");
                dataGridView1.Rows.Add("PR1L", "41", "zh", "Saturday", "10--12", "CL3");
                dataGridView1.Rows.Add("PR1L", "21", "zh", "Monday", "12--14", "CL3");
                dataGridView1.Rows.Add("PR1L", "12", "zh", "Wedensday", "14-16", "CL4");
                dataGridView1.Rows.Add("PR2", "3", "", "Saturday", "12--14", "A2");
                dataGridView1.Rows.Add("PR2", "2", "mhm", "Saturday", "14-16", "B5");
                dataGridView1.Rows.Add("PR2", "1", "mhm", "Saturday", "12--14", "B2");
                dataGridView1.Rows.Add("PR2", "12", "mnm", "Saturday", "14-16", "CL4");
                dataGridView1.Rows.Add("PR2L", "22", "mnm", "Saturday", "12--14", "CL4");
                dataGridView1.Rows.Add("PR2L", "31", "tm", "Monday", "12--14", "CL1");
                dataGridView1.Rows.Add("PR2L", "11", "tm", "Saturday", "14-16", "CL3");
                dataGridView1.Rows.Add("PR2L", "32", "tm", "Monday", "14-16", "CL1");
                dataGridView1.Rows.Add("PR2L", "21", "tm", "Saturday", "12--14", "CL3");
                dataGridView1.Rows.Add("PS", "1", "sa", "Saturday", "12--14", "B4");
                dataGridView1.Rows.Add("PS", "2-Jan", "sa", "Sunday", "8--10", "B4");
                dataGridView1.Rows.Add("PS", "2", "sa", "Saturday", "14-16", "B4");
                dataGridView1.Rows.Add("RM", "RM", "hk", "Monday", "8--10", "A3");
                dataGridView1.Rows.Add("RM", "RM", "hk", "Wedensday", "8--10", "A3");
                dataGridView1.Rows.Add("SAD", "1", "sat", "Saturday", "8--10", "B5");
                dataGridView1.Rows.Add("SAD", "2", "sat", "Saturday", "12--14", "B5");
                dataGridView1.Rows.Add("SAD", "2-Jan", "sat", "Saturday", "10--12", "B5");
                dataGridView1.Rows.Add("SIP1", "SIP1", "saj", "Tuesday", "12--14", "A5");
                dataGridView1.Rows.Add("SIP1L", "SIP1L", "mns", "Wedensday", "12--14", "DSL");
                dataGridView1.Rows.Add("SIP2", "SIP2", "saj", "Wedensday", "12--14", "A5");
                dataGridView1.Rows.Add("SIP2L", "SIP2L", "mns", "Wedensday", "10--12", "DSL");
                dataGridView1.Rows.Add("SOC", "2", "", "Thursday", "10--12", "B2");
                dataGridView1.Rows.Add("SOC", "1", "", "Thursday", "8--10", "B2");
                dataGridView1.Rows.Add("SP", "1", "mha", "Wedensday", "10--12", "B2");
                dataGridView1.Rows.Add("SPL", "12", "ts", "Wedensday", "12--14", "CL2");
                dataGridView1.Rows.Add("SPL", "11", "ts", "Wedensday", "8--10", "CL2");
                dataGridView1.Rows.Add("STI", "STI", "hj", "Tuesday", "12--14", "B5");
                dataGridView1.Rows.Add("SW1", "SW1", "sat", "Tuesday", "14-16", "B1");
                dataGridView1.Rows.Add("SW1L", "12", "mnz", "Tuesday", "10--12", "CL4");
                dataGridView1.Rows.Add("SW1L", "11", "mnz", "Tuesday", "12--14", "CL4");
            }*/
            if (Debug)
            {
               button2.Visible = true;
            }
        }
        private void TabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            e.Cancel = !Changetab;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (EF2 != null) EF2.Close();
        }
        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Btn_Back.Enabled = Btn_Next.Enabled = true;
            Btn_Next.Text = "Next >";
            Lb_Info.Text = "TECNO2019\r\ntecno.start.14@gmail.com";
            Lb_Info.ForeColor = Color.DarkBlue;

            if (SelectTabIndex == 0)//welcome
            {
                Btn_Back.Enabled = false;
                Btn_Next.Text = "Accept >";
                if (Debug) Btn_Next_Click(null, null);
            }
            else if (SelectTabIndex == 1)//read list
            {
                if ((EF2 == null))//||(!IS_DB_Empty))
                    Btn_Next.Enabled = false;
                //if (Debug) Btn_Next_Click(null, null);
                if (Alpha) Btn_Next.Enabled = true;
            }
            else if (SelectTabIndex == 2)//roles
            {
                Lb_Info.Text = "Please wait ...";
                Btn_Next.Text = "Search >";
                //Load All Data
                
                ResetAllRolesTab();
                SelectedDGV_RolesIndex = -1;
                //Lb_Info.Text = "More Conditions => Find Resault faster\r\nDelete Row: Select Row then press 'Dele' (keybord)";
                Lb_Info.Text = "New Row: double click HERE\r\nDelete Row: Select Row then press 'Dele' (keybord) ";
                ////DGV_Roles.ClearSelection();

            }
            else if (SelectTabIndex == 3)//get resault
            {
                Btn_Next.Enabled = false;
                Lb_Info.Text = "That can take alot of time";

            }
            if (Debug)
            {
                Btn_Next.Enabled = true;
                Btn_Back.Enabled = true;
            }
            BackTab = SelectTabIndex;
        }

        private void Btn_Next_Click(object sender, EventArgs e)
        {
            SelectTabIndex++;
        }
        private void Btn_Back_Click(object sender, EventArgs e)
        {
            SelectTabIndex--;
        }
        //
        //readList
        private void BtnBrowser_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Workbook|*.xls;*.xlsx", ValidateNames = true, Multiselect = false })
                if (ofd.ShowDialog() == DialogResult.OK)
                    LoadFile(TbPath.Text = ofd.FileName);
            if (EF2 != null) EF2.Close();
        }
        private void ResetDataGrid(bool Reset = true)
        {
            if (Reset)
            {
                if (EF2 != null) { EF2.Close(); EF2 = null; }
                //IS_DB_Load = false;
                TbPath.Text = "";

                //dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
                //dataGridView1.DataSource = null;
                Btn_Next.Enabled = false;

                //DGV_RolesHeader.Rows.Clear();
                //DGV_RolesHeader.Columns.Clear();
                //DGV_RolesHeader.DataSource = null;
                //DGV_RolesHeader.Rows.Clear();

                ResetDGV_Roles();

                //DB_All_IsCreated = false;
                //DB_Rol_IsCreated = false;
            }
            else
            {
                Btn_Next.Enabled = true;
            }
        }
        private void LoadFile(string FileName, bool SelectFirstSheet = true)
        {
            string stt = Lb_Info.Text;
            Lb_Info.ForeColor = Color.DarkRed;
           Lb_Info.Text = "1- Load File Please wait...(about minute)";

            string stt2;

            try
            {
                //reset all
                ResetDataGrid();
                CbSheets.Items.Clear();
                //open file
                EF2 = new MyExcelLib.ExcelFile2(FileName, !Debug);
                //UnMerge All Cells
                EF2.UnMergeAndDublDataFile();
                //save
                EF2.Save();
                //DataSet
                stt2 = Lb_Info.Text;
                Lb_Info.Text = "2- Read File Please wait...(about minute)";
                EF2.ReadAll2DataSet();
                Lb_Info.Text = stt2;
                //Delet tmp File
                EF2.DeleteTmpFile();
                //sheets
                foreach (string n in EF2.SNames)
                    CbSheets.Items.Add(n);
                //success and save file link at textbox
                TbPath.Text = FileName;
                //----------
                //select first sheet
                if (SelectFirstSheet)
                    if (CbSheets.Items.Count >= 1)
                        CbSheets.Text = CbSheets.Items[0].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error at Open File :\r\n" + ex.Message, "Error (1)");
                if (Debug) MessageBox.Show(ex.ToString());
                Lb_Info.Text = stt;
            }
            Lb_Info.Text = stt;
            ///if (Debug) Btn_Next_Click(null, null);
            Lb_Info.ForeColor = Color.DarkBlue;
        }
        private void Print2(int indx)
        {
            string stt = Lb_Info.Text;
            Lb_Info.Text = "ViewFile Please wait...";
            try
            {
                if (indx >= EF2.SNames.Count)
                {
                    MessageBox.Show("Error at sheet count ", "Error (2)");
                    return;
                }

                dataGridView1.DataSource = EF2.FileDS.Tables[indx];// EF2.ws;

                int i = 0, j = 0;//left first row
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                    column.HeaderText = MyExcelLib.Convert.GetColumnName2(++i);//useless//coz the name set before
                }

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.HeaderCell.Value = MyExcelLib.Convert.GetRowName(++j);//(++j).ToString();//the same
                }
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
                dataGridView1.AllowUserToResizeColumns = true;

                dataGridView1.Refresh();
                //enable Control
                ResetDataGrid(false);
                dataGridView1.Rows[0].Frozen = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error at Print Table:\r\n" + ex.Message, "Error (3)");
                if (Debug) MessageBox.Show(ex.ToString());
                Lb_Info.Text = stt;
            }
            Lb_Info.Text = stt;
        }

        private void CbSheets_SelectedIndexChanged(object sender, EventArgs e)
        {
            Print2(CbSheets.SelectedIndex);
        }
        private void BtnReset_Click(object sender, EventArgs e)
        {
            ResetDataGrid();
        }
        //
        //roles
        void LoadDGV_RolesHeader()
        {
            string stt = Lb_Info.Text;
            Lb_Info.Text = "LoadRolesHeader Please wait...";
            DGV_RolesHeader.ReadOnly = false;
            if (DontResetHeader)
                return;
            //DGV_RolesHeader.Rows.Clear();
            DGV_RolesHeader.Columns.Clear();
            //DGV_RolesHeader.DataSource = null;//reset dgv
            if (AllColomns == null)
                return;

            DGV_RolesHeader.EditMode = DataGridViewEditMode.EditOnEnter;
            DataGridViewComboBoxCell MyCell;

            //DGV_RolesHeader.Rows.Clear();
            //DGV_RolesHeader.Columns.Clear();
            //DGV_RolesHeader.DataSource = (new DataSet());
            //DGV_RolesHeader.Rows.Add();
            //for each col
            //DGV_RolesHeader.Columns.Add("tmp", "tmp");
            //DGV_RolesHeader.Rows.Add();

            //include or not:
            DGV_RolesHeader.Columns.Add("Then", "Then");

            MyCell = new DataGridViewComboBoxCell()
            {
                DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox,
                Sorted = true,
                FlatStyle = FlatStyle.Flat
            };

            
            MyCell.Items.Add(Include);
            ////MyCell.Items.Add(Exclude);
            ////MyCell.Value = Exclude;
            MyCell.Value = Include;
            if (DGV_RolesHeader.Rows.Count < 1)
                DGV_RolesHeader.Rows.Add();
            DGV_RolesHeader.Rows[0].Cells[0] = MyCell;
            ///tmp
            MyCell.Style.BackColor = Color.DarkGray;
            MyCell.ReadOnly = true;

            for (int Col = 0; Col < AllColomns.Count; Col++)
            {
                if (dataGridView1.Rows.Count < 1)
                    return;
                DGV_RolesHeader.Columns.Add(Col.ToString(), (dataGridView1[Col, 0].Value ?? "").ToString());

                MyCell = new DataGridViewComboBoxCell();
                MyCell.FlatStyle = FlatStyle.Flat;
                MyCell.Items.Add(Any);
                MyCell.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
                MyCell.Sorted = true;
                MyCell.Value = Any;
                MyCell.Style.BackColor = Color.DarkGray;
                ///

                foreach (string i in AllColomns[Col])
                    MyCell.Items.Add(i);
                if (DGV_RolesHeader.Rows.Count < 1)
                    DGV_RolesHeader.Rows.Add();
                DGV_RolesHeader.Rows[0].Cells[Col + 1] = MyCell;
                ///tmp:
                DGV_RolesHeader.Rows[0].Cells[Col + 1].ReadOnly = true;
            }
            ///DGV_RolesHeader.Rows[0].Cells[0].ReadOnly = DGV_RolesHeader.Rows[0].Cells[1].ReadOnly = false;
            DGV_RolesHeader.Rows[0].Cells[1].ReadOnly = false;
            DGV_RolesHeader.Rows[0].Cells[1].Style.BackColor = Color.White;
            //
            //DGV_RolesHeader.Columns.Remove("tmp");
            DGV_RolesHeader.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
            Lb_Info.Text = stt;
        }
        void RedDGV_RolesHeader()
        {

            for (int i = 1; i < DGV_RolesHeader.ColumnCount; i++)
            {
                DataGridViewComboBoxCell Cell;
                Cell = (DataGridViewComboBoxCell)DGV_RolesHeader[i, 0];
                //Cell.Items.Remove(Any);

                for (int j = 0; j < Cell.Items.Count; j++)
                    if (Cell.Items[j].ToString() == Any)
                        continue;
                    else if (!AllColomns[i - 1].Contains(Cell.Items[j].ToString()))
                    {
                        Cell.Items.RemoveAt(j);
                        j--;
                        continue;
                    }
                //Cell.Items.Add(Any);
            }


        }
        public void LoadColumnsDataDISTINCT(DataGridView SourceDGV = null)
        {
            int StartIndex = 0;
            if (SourceDGV == null)
            {
                SourceDGV = dataGridView1;
                StartIndex = 1;
            }
            string stt = Lb_Info.Text;
            Lb_Info.Text = "LoadColumnsData Please wait...";
            if (SourceDGV.Rows.Count > 0)
            {
                AllColomns = new List<List<string>>();
                for (int Col = 0; Col < SourceDGV.Columns.Count; Col++)//cols
                {
                    AllColomns.Add(new List<string>());
                    bool AllowUserToAddRows = SourceDGV.AllowUserToAddRows;
                    SourceDGV.AllowUserToAddRows = false;
                    for (int Row = StartIndex; Row < SourceDGV.Rows.Count; Row++)
                        if (!AllColomns[Col].Contains((SourceDGV[Col, Row].Value ?? "").ToString()))
                            AllColomns[Col].Add((SourceDGV[Col, Row].Value ?? "").ToString());
                    SourceDGV.AllowUserToAddRows = AllowUserToAddRows;
                }
            }
            Lb_Info.Text = stt;
        }
        bool DontResetHeader = false;
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            //chk if empty
            bool IsEmpty = true;
            for (int i = 1; i < DGV_RolesHeader.ColumnCount; i++)
            {
                if ((DGV_RolesHeader[i, 0].Value ?? "").ToString() != Any)
                { IsEmpty = false; break; }
            }
            if (IsEmpty)
                goto Done;

            List<string> tmp = new List<string>();
            
            if (Btn_Add.Text == Add)
            {
                for (int i = 0; i < DGV_RolesHeader.Columns.Count; i++)
                    tmp.Add((DGV_RolesHeader.Rows[0].Cells[i].Value ?? "").ToString());
                DGV_Roles.Rows.Add(tmp.ToArray());
                SelectedDGV_RolesIndex = -1;
                LoadColumnsDataDISTINCT();
                LoadDGV_RolesHeader();
            }
            else
            {
                for (int i = 0; i < DGV_RolesHeader.Columns.Count; i++)
                    DGV_Roles.Rows[SelectedDGV_RolesIndex].Cells[i].Value = DGV_RolesHeader.Rows[0].Cells[i].Value;
                SelectedDGV_RolesIndex = -1;
            }
            Done:
            DGV_Roles.ClearSelection();
            //LoadDGV_RolesHeader();
        }
        private void Btn_ResetAll_Click(object sender, EventArgs e)
        {
            ResetAllRolesTab();
        }
        private void DGV_Roles_SelectionChanged(object sender, EventArgs e)
        {
            LoadDGV_RolesHeader();
            SelectedDGV_RolesIndex = -1;
            if (DGV_Roles.SelectedRows.Count < 1)
                return;
            //if (FirstTime)
            //{ FirstTime = false; return; }

            for (int i = 0; i < DGV_RolesHeader.ColumnCount; i++)
                DGV_RolesHeader.Rows[0].Cells[i].Value = (DGV_Roles.SelectedRows[0].Cells[i].Value.ToString() ?? "");
            SelectedDGV_RolesIndex = DGV_Roles.SelectedRows[0].Index;
        }
        private void DGV_Roles_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            /*
            if ((e.RowIndex < 0) || (e.ColumnIndex < 0))
                return;
            //string tmp = (DGV_Roles.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() ?? "");
            if (string.IsNullOrEmpty(DGV_Roles.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()))
                DGV_Roles.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Any;
            */
        }
       
        void ResetDGV_Roles()
        {
            if (SelectTabIndex < BackTab)
                return;
            //DGV_Roles.Rows.Clear();
            DGV_Roles.Columns.Clear();
            //DGV_Roles.DataSource = null;
            if (AllColomns == null)
                return;

            DGV_Roles.EditMode = DataGridViewEditMode.EditOnEnter;
            //DGV_Roles.DataSource = (new DataSet());
            for (int Col = 0; Col < DGV_RolesHeader.ColumnCount; Col++)
                DGV_Roles.Columns.Add(DGV_RolesHeader.Columns[Col].Name, DGV_RolesHeader.Columns[Col].HeaderText);// dataGridView1[Col, 0].Value.ToString());
        }
        void ResetAllRolesTab()
        {
            LoadColumnsDataDISTINCT();
            LoadDGV_RolesHeader();
            ResetDGV_Roles();
        }

        private void DGV_Roles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGV_Roles_Click(object sender, EventArgs e)
        {

        }

        private void DGV_Roles_DoubleClick(object sender, EventArgs e)
        {
            SelectedDGV_RolesIndex = -1;
            LoadColumnsDataDISTINCT();
            LoadDGV_RolesHeader();
        }
        AllCourseCls SelectedCourse;
        List<WeekTable> WT;
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            bool dgv1 = dataGridView1.AllowUserToAddRows, dgvR = DGV_Roles.AllowUserToAddRows;
            dataGridView1.AllowUserToAddRows = false; DGV_Roles.AllowUserToAddRows = false;

            Clss.tmp.FndRslt f = new Clss.tmp.FndRslt(ref dataGridView1, ref DGV_Roles);
            dataGridView1.AllowUserToAddRows = dgv1; DGV_Roles.AllowUserToAddRows = dgvR;
            SelectedCourse = new AllCourseCls();

            WT = f.Run(out SelectedCourse);
            if (WT == null)
                return;
            comboBox1.Items.Clear();
            for (int i = 0; i < WT.Count; i++)
            {
                comboBox1.Items.Add(i + 1);
            }

            LoadColumnsDataDISTINCT();
            List<string> All_Day_Des = AllColomns[f.DayC];
            List<string> All_Period_Des = AllColomns[f.PeriodC];
            LB_Day.Items.Clear();
            LB_Period.Items.Clear();
            for (int i = 0; i < All_Day_Des.Count; i++)
                LB_Day.Items.Add(All_Day_Des[i]);

            for (int i = 0; i < All_Period_Des.Count; i++)
                LB_Period.Items.Add(All_Period_Des[i]);

            if (comboBox1.Items.Count > 0)
                comboBox1.SelectedIndex = 0;

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBox1.Enabled = false;
            if (string.IsNullOrEmpty(comboBox1.SelectedItem.ToString()))
                return;
            listBox1.Items.Clear();
            int WTID = Convert.ToInt16(comboBox1.SelectedIndex.ToString());

            /*
            foreach (Course_GroupIndexCls item in WT[WTID].AddedItems)      
                listBox1.Items.Add("Course:\t" + SelectedCourse.Course[item.Course].Name +
                    "\t\tGroup:\t" + SelectedCourse.Course[item.Course].Group[item.Group].Name +
                    "\t\tPresent:\t" + SelectedCourse.Course[item.Course].Group[item.Group].Present);
            */

            //DGV_Table.Rows.Clear();
            //DGV_Table.Columns.Clear();
            //  while(DGV_Table.Columns.Count< LB_Period.Items.Count)
            //   DGV_Table.Columns.Add()
            // if (DGV_Table.Columns.Count < 1)
            //  {
            for (int i = 0; i < LB_Period.Items.Count; i++)
            {
                if (DGV_Table.Columns.Count < LB_Period.Items.Count)
                    DGV_Table.Columns.Add(LB_Period.Items[i].ToString(), LB_Period.Items[i].ToString());
                else
                    DGV_Table.Columns[i].Name = DGV_Table.Columns[i].HeaderText = LB_Period.Items[i].ToString();

            }
            for (int i = 0; i < LB_Day.Items.Count; i++)
            {
                if (DGV_Table.Rows.Count < LB_Day.Items.Count)
                    DGV_Table.Rows.Add();
                DGV_Table.Rows[i].HeaderCell.Value = LB_Day.Items[i];
                for (int j = 0; j < LB_Period.Items.Count; j++)
                    DGV_Table[j, i].Value = "";
            }
            while (DGV_Table.Columns.Count > LB_Period.Items.Count) DGV_Table.Columns.RemoveAt(DGV_Table.Columns.Count - 1);
            while (DGV_Table.Rows.Count > LB_Day.Items.Count) DGV_Table.Rows.RemoveAt(DGV_Table.Rows.Count - 1);
            // }

            bool IsFound;
            foreach (Course_GroupIndexCls C_G in WT[WTID].AddedItems)
                foreach (SpacetimeCls ST in SelectedCourse.Course[C_G.Course].Group[C_G.Group].Spacetime)
                {
                    IsFound = false;
                    for (int i = 0; i < DGV_Table.Rows.Count; i++)
                    {
                        if (IsFound) break;
                        if (ST.Day == (DGV_Table.Rows[i].HeaderCell.Value ?? "").ToString())
                        {
                            IsFound = true;
                            DGV_Table[ST.Period, i].Value = DGV_Table[ST.Period, i].Value ?? "";
                            DGV_Table[ST.Period, i].Value = "";
                            DGV_Table[ST.Period, i].Value += SelectedCourse.Course[C_G.Course].Name + "-" +
                                SelectedCourse.Course[C_G.Course].Group[C_G.Group].Name + ":" +
                                    SelectedCourse.Course[C_G.Course].Group[C_G.Group].Present;
                        }

                    }
                    if (!IsFound)
                    {
                        MessageBox.Show("Error at Find Day:'" + ST.Day + "'");
                        return;
                    }
                }
            DGV_Table.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            DGV_Table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DGV_Table.AllowUserToResizeColumns = true;
            DGV_Table.Refresh();
            //comboBox1.Enabled = true;
        }
        void IncOrExc()
        {
            bool b = false;
            if ((DGV_RolesHeader[0, 0].Value??"").ToString() == Include)
                b = true;
            //DGV_RolesHeader[1, 0].Value = Any;
            for (int i = 2; i < DGV_RolesHeader.ColumnCount; i++)
            { DGV_RolesHeader[i, 0].ReadOnly = b; DGV_RolesHeader[i, 0].Selected = b; DGV_RolesHeader[i, 0].Value = Any; }// ((DataGridViewComboBoxCell)DGV_RolesHeader[i, 0]).FlatStyle = FlatStyle.Flat; }//   Style =DataGridViewComboBoxCell}
        }
        private void DGV_RolesHeader_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridViewComboBoxCell m = new DataGridViewComboBoxCell();
            //m.FlatStyle = FlatStyle.Flat;
            //if include then frozen all cells unless course name
            IncOrExc();
            //Copy All Rows From All_Table
            DataGridView NeededRows = new DataGridView();
            NeededRows.AllowUserToAddRows = false;
            foreach (DataGridViewColumn i in dataGridView1.Columns)
                NeededRows.Columns.Add(i.Name, i.HeaderText);
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                NeededRows.Rows.Add();
                for (int j = 0; j < dataGridView1.Rows[i].Cells.Count; j++)
                    NeededRows.Rows[i].Cells[j].Value = dataGridView1.Rows[i].Cells[j].Value;
            }
            NeededRows.Rows.RemoveAt(0);
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                if (DGV_RolesHeader[i + 1, 0].Value.ToString() == Any)
                    continue;
                for (int j = 0; j < NeededRows.Rows.Count; j++)
                    if ((NeededRows.Rows[j].Cells[i].Value ?? "").ToString() != (DGV_RolesHeader[i + 1, 0].Value ?? "").ToString())
                    {
                        NeededRows.Rows.RemoveAt(j);
                        j--;
                        continue;
                    }
            }
            LoadColumnsDataDISTINCT(NeededRows);
            RedDGV_RolesHeader();
        }

        private void DGV_RolesHeader_Click(object sender, EventArgs e)
        {
            IncOrExc();
        }

        private void Lb_Info_Click(object sender, EventArgs e)
        {
            LoadDGV_RolesHeader();
            //DGV_Roles_DoubleClick(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DGV_Roles.Rows.Clear();
            DGV_Roles.Rows.Add(Include, "AAD", Any, Any, Any, Any, Any);
            DGV_Roles.Rows.Add(Include, "AADL", Any, Any, Any, Any, Any);
            DGV_Roles.Rows.Add(Include, "CAL", Any, Any, Any, Any, Any);
            DGV_Roles.Rows.Add(Include, "CA", Any, Any, Any, Any, Any);
            DGV_Roles.Rows.Add(Include, "CAL2", Any, Any, Any, Any, Any);
            DGV_Roles.Rows.Add(Include, "DB2", Any, Any, Any, Any, Any);
            DGV_Roles.Rows.Add(Include, "DB2L", Any, Any, Any, Any, Any);
            DGV_Roles.Rows.Add(Include, "CTH", Any, Any, Any, Any, Any);
        }

        private void Btn_Up_Days_Click(object sender, EventArgs e)
        {
            if (LB_Day.SelectedIndex <= 0)
                return;

            string tmp = LB_Day.Items[LB_Day.SelectedIndex].ToString();
            LB_Day.Items[LB_Day.SelectedIndex] = LB_Day.Items[LB_Day.SelectedIndex - 1];
            LB_Day.Items[LB_Day.SelectedIndex - 1] = tmp;
            LB_Day.SelectedIndex--;
        }

        private void Btn_Dwn_Days_Click(object sender, EventArgs e)
        {
            if (LB_Day.SelectedIndex < 0)
                return;

            if (LB_Day.SelectedIndex + 1 == LB_Day.Items.Count)
                return;

            string tmp = LB_Day.Items[LB_Day.SelectedIndex].ToString();
            LB_Day.Items[LB_Day.SelectedIndex] = LB_Day.Items[LB_Day.SelectedIndex + 1];
            LB_Day.Items[LB_Day.SelectedIndex + 1] = tmp;
            LB_Day.SelectedIndex++;
        }

        private void Btn_Up_Period_Click(object sender, EventArgs e)
        {
            if (LB_Period.SelectedIndex <= 0)
                return;

            string tmp = LB_Period.Items[LB_Period.SelectedIndex].ToString();
            LB_Period.Items[LB_Period.SelectedIndex] = LB_Period.Items[LB_Period.SelectedIndex - 1];
            LB_Period.Items[LB_Period.SelectedIndex - 1] = tmp;
            LB_Period.SelectedIndex--;
        }

        private void Btn_Dwn_Period_Click(object sender, EventArgs e)
        {
            if (LB_Period.SelectedIndex < 0)
                return;

            if (LB_Period.SelectedIndex + 1 == LB_Period.Items.Count)
                return;

            string tmp = LB_Period.Items[LB_Period.SelectedIndex].ToString();
            LB_Period.Items[LB_Period.SelectedIndex] = LB_Period.Items[LB_Period.SelectedIndex + 1];
            LB_Period.Items[LB_Period.SelectedIndex + 1] = tmp;
            LB_Period.SelectedIndex++;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string tab = "\t\t\t";
            richTextBox2.Text = "";
            //Get All
            for (int i = 0; i < comboBox1.Items.Count; i++)
            {
                comboBox1.Select(i, 1);
                comboBox1_SelectedIndexChanged(null, null);

                //get column name
                richTextBox2.Text += "\r\n" + tab;
                for (int k = 0; k < DGV_Table.ColumnCount; k++)
                {
                    richTextBox2.Text += DGV_Table.Columns[k].HeaderText + tab;
                }

                richTextBox2.Text += "\r\n";

                //get data
                for (int j = 0; j < DGV_Table.RowCount; j++)
                {
                    richTextBox2.Text += DGV_Table.Rows[j].HeaderCell.Value + tab;
                    for (int k = 0; k < DGV_Table.ColumnCount; k++)
                    {
                        richTextBox2.Text += DGV_Table[k, j].Value + tab;
                    }
                    richTextBox2.Text += "\r\n";
                }
                richTextBox2.Text += "\r\n";
            }
            /*
            if(dataGridView1.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
               string jobId = dataGridView1.SelectedRows[0].Cells[0].Value + string.Empty;
               string userId = dataGridView1.SelectedRows[0].Cells[2].Value + string.Empty;

               txtJobId.Text = jobId;
               txtUserId.Text = userId;
            }
            */
        }



        //
    }
}
