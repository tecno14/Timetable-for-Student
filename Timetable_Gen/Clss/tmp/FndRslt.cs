using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Timetable_Gen.Clss.tmp.Flds;

namespace Timetable_Gen.Clss.tmp
{
    class FndRslt
    {
        DataGridView AllCourseTable;
        DataGridView AllRoles;
        DataGridView DGVIncude;
        DataGridView DGVExclude;
        AllCourseCls AllCourse;
        public AllCourseCls SelectedCourse;
        List<WeekTable> WeekTableList;

        public const string Include = "Include";
        public const string Exclude = "exclude";
        public string Then ="Then", Course= "Course", Group = "Group", Present = "Present", Day = "Day", Period = "Period", Room = "Room";
        public int CourseC, GroupC, PresentC, DayC, PeriodC, RoomC;
        public int CourseR, GroupR, PresentR, DayR, PeriodR, RoomR, ThenR;
        public const string Any = "\"Any\"";
        public FndRslt(ref DataGridView AllCourseTable,ref DataGridView AllRoles)
        {
            this.AllCourseTable = AllCourseTable;
            this.AllRoles = AllRoles;
        }

        public List<WeekTable> Run(out AllCourseCls SelectedCourseOut)
        {
            SelectedCourseOut = null;
            //chec tmp req columns [Course Group   Present Day Period  Room]
            CourseC = GroupC = PresentC = DayC = PeriodC = RoomC =
                CourseR = GroupR = PresentR = DayR = PeriodR = RoomR = ThenR = -1;
            string tmp;
            for (int i=0;i<AllCourseTable.Columns.Count;i++)
            {
                tmp = AllCourseTable[i, 0].Value.ToString();
                if (tmp == Course)
                    CourseC = i;
                else if (tmp == Group)
                    GroupC = i;
                else if (tmp == Present)
                    PresentC = i;
                else if (tmp == Day)
                    DayC = i;
                else if (tmp == Period)
                    PeriodC = i;
                else if (tmp == Room)
                    RoomC = i;
            }
            for (int i = 0; i < AllRoles.Columns.Count; i++)
            {
                tmp = AllRoles.Columns[i].HeaderText.ToString();
                if (tmp == Then)
                    ThenR = i;
                else if (tmp == Course)
                    CourseR = i;
                else if (tmp == Group)
                    GroupR = i;
                else if (tmp == Present)
                    PresentR = i;
                else if (tmp == Day)
                    DayR = i;
                else if (tmp == Period)
                    PeriodR = i;
                else if (tmp == Room)
                    RoomR = i;
            }

            if (
                (CourseC == -1) || (GroupC == -1) || (PresentC == -1) || (DayC == -1) || (PeriodC == -1) || (RoomC == -1) ||
                (CourseR == -1) || (GroupR == -1) || (PresentR == -1) || (DayR == -1) || (PeriodR == -1) || (RoomR == -1) || (ThenR == -1)
                )
            {
                MessageBox.Show("Error\r\nCheack : [Course, Group, Present, Day, Period, Room]");
                return null;
            }
            //split roles into (include/exclute)
            //DGVIncude.Rows.Clear();
            //DGVIncude.Columns.Clear();
            //DGVExclude.Rows.Clear();
            //DGVExclude.Columns.Clear();
            DGVIncude = new DataGridView();
            DGVExclude = new DataGridView();
            DGVIncude.AllowUserToAddRows = DGVExclude.AllowUserToAddRows = false;
            bool t=AllRoles.AllowUserToAddRows;
            AllRoles.AllowUserToAddRows = false;
            for (int i = 0; i < AllRoles.Columns.Count; i++)
            {
                DGVIncude.Columns.Add(AllRoles.Columns[i].Name, AllRoles.Columns[i].HeaderText);
                DGVExclude.Columns.Add(AllRoles.Columns[i].Name, AllRoles.Columns[i].HeaderText);
            }
            for (int i = 0; i < AllRoles.Rows.Count ; i++)
            {
                List<string> tmpRow = new List<string>();
                for (int k = 0; k < AllRoles.Rows[i].Cells.Count; k++)
                {
                    tmpRow.Add((AllRoles.Rows[i].Cells[k].Value ?? "").ToString());
                }
                if (AllRoles[ThenR, i].Value.ToString() == Include)
                    DGVIncude.Rows.Add(tmpRow.ToArray());
                else
                    DGVExclude.Rows.Add(tmpRow.ToArray());
            }
            AllRoles.AllowUserToAddRows = t;
            //build full table
            AllCourse = new AllCourseCls();
            for (int i = 1; i < AllCourseTable.Rows.Count; i++)//Row
            {
                Debug.WriteLine("Start: " + i);
                DataGridViewRow r = AllCourseTable.Rows[i];
                AllCourse.AddRow(r.Cells[CourseC].Value, r.Cells[GroupC].Value, r.Cells[PresentC].Value,
                    r.Cells[DayC].Value, r.Cells[PeriodC].Value, r.Cells[RoomC].Value);
                Debug.WriteLine(" -DoneL" + i);
            }
            //delet all exc* from table
            for (int i = 0; i < DGVExclude.Rows.Count; i++)//R
            {
                string value;
                int CourseIndex, GroupIndex;

                value =( DGVExclude.Rows[i].Cells[CourseR].Value ?? "").ToString();
                if (value != Any)
                { AllCourse.IsCourseIn(value, out CourseIndex); AllCourse.Course.RemoveAt(CourseIndex); }

                value = (DGVExclude.Rows[i].Cells[GroupR].Value ?? "").ToString();
                if (value != Any) while (AllCourse.IsGroupIn(value, out CourseIndex, out GroupIndex)) AllCourse.Course[CourseIndex].Group.RemoveAt(GroupIndex);

                value = (DGVExclude.Rows[i].Cells[PresentR].Value ?? "").ToString();
                if (value != Any) while (AllCourse.IsPresentIn(value, out CourseIndex, out GroupIndex)) AllCourse.Course[CourseIndex].Group.RemoveAt(GroupIndex);

                value = (DGVExclude.Rows[i].Cells[DayR].Value ?? "").ToString();
                if (value != Any) while (AllCourse.IsDayIn(value, out CourseIndex, out GroupIndex)) AllCourse.Course[CourseIndex].Group.RemoveAt(GroupIndex);

                value = (DGVExclude.Rows[i].Cells[PeriodR].Value ?? "").ToString();
            if (value != Any) while (AllCourse.IsPeriodIn(value, out CourseIndex, out GroupIndex)) AllCourse.Course[CourseIndex].Group.RemoveAt(GroupIndex);
            }
            //get just inc* from table 
            SelectedCourse = new AllCourseCls();
            for (int i = 0; i < DGVIncude.Rows.Count; i++)//R
            {
                string value;
                int CourseIndex = -1;// GroupIndex = -1;

                value = (DGVIncude.Rows[i].Cells[CourseR].Value ?? "").ToString();
                if (value != Any)
                { AllCourse.IsCourseIn(value, out CourseIndex); SelectedCourse.Course.Add(AllCourse.Course[CourseIndex]); }

            }

            //check if bosibe for here
            for (int i = 0; i < SelectedCourse.Course.Count; i++)
            {
                if(SelectedCourse.Course[i].Group.Count==0)
                {
                    MessageBox.Show("there is no posible Programs\r\nCourse:" + SelectedCourse.Course[i].Name);
                    return null;
                }
            }

            //sort Selected Course for group count
            SelectedCourse.SortCourses();
            //Find All Timetable
            WeekTableList = new List<WeekTable>();
            WeekTable tmpWT = new WeekTable();
            //WeekTableList.Add(new WeekTable());
            Find(tmpWT, 0);
            SelectedCourseOut = SelectedCourse;
            return WeekTableList;
        }
        // MessageBox.Show("No WeekTable Found\r\nCourse:" + SelectedCourse.Course[course].Name);
        void Find(WeekTable WT, int courseID)
        {
            if (courseID == SelectedCourse.Course.Count)//success
            {
                WeekTableList.Add(WT);
                return;
            }
            WeekTable tWT;
            for (int i = 0; i < SelectedCourse.Course[courseID].Group.Count; i++)
            {
                tWT = WT.Copy();
                if (tWT.TryAdd(courseID, i, ref SelectedCourse))
                    Find(tWT, courseID + 1);
            }
            
            //Find(WT.Copy(), courseID + 1, 0);

            //if (!WT.TryAdd(courseID, group, ref SelectedCourse))
              //  return;
            
            //if (SelectedCourse.Course[courseID].Group.Count < group)
              //  Find(WT.Copy(), courseID, group + 1);

        }
       /* void Find(WeekTable WT, int course, int group)
        {
            
        }*/

    }
}
