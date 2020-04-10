using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Timetable_Gen.Clss.tmp.Flds
{
    class AllCourseCls
    {
        public List<CourseCls> Course;

        public AllCourseCls()
        {
            Course = new List<CourseCls>();
        }
        public void SortCourses()
        {
            List<CourseCls> tmpCourse = new List<CourseCls>();
            int size = 1;
            while (tmpCourse.Count < Course.Count)
            {
                for (int i = 0; i < Course.Count; i++)
                {
                    if (Course[i].Group.Count == size)
                        tmpCourse.Add(Course[i]);
                }
                size++;
            }
            Course = tmpCourse;
        }
        /*public void AddCourse(CourseCls NewCourse)
        {
            Course.Add(NewCourse);
            /*
            int CourseId = GetCourseIndex(NewCourse.Name);
            int GroupId;
            for (int i = 0; i < NewCourse.Group.Count; i++)
            {
                GroupId = Course[CourseId].GetGroupIndex(NewCourse.Group[i].Name);
                Course[CourseId].Group[GroupId].Present = NewCourse.Group[i].Present;
            }
            Course[CourseId].GetGroupIndex(NewCourse.)
            int GroupId = this.Course[CourseId].GetGroupIndex(Group.ToString());
            this.Course[CourseId].Group[GroupId].Present = Present.ToString();
            this.Course[CourseId].Group[GroupId].GetSpacetimeIndex(Day.ToString(), Period.ToString(), Room.ToString());
            
             * .....* /
        }*/
        public void AddRow(object Course, object Group, object Present, object Day, object Period, object Room)
        {
            if (Course == null)
                return;
            int CourseId = GetCourseIndex(Course.ToString());
            int GroupId = this.Course[CourseId].GetGroupIndex(Group.ToString());
            this.Course[CourseId].Group[GroupId].Present = Present.ToString();
            this.Course[CourseId].Group[GroupId].GetSpacetimeIndex(Day.ToString(), Period.ToString(), Room.ToString());
        }
        //isGroupIn
        public int GetCourseIndex(string s)
        {
            if (IsCourseIn(s, out int index))
                return index;
            Course.Add(new CourseCls() { Name = s });
            return Course.Count - 1;
        }
        public bool IsCourseIn(string s, out int CourseIndex)//,out int GroupIndex)
        {
            CourseIndex = -1;
            for (int i = 0; i < Course.Count; i++)
                if (Course[i].Name == s)
                { CourseIndex = i; return true; }
            return false;
        }
        public bool IsGroupIn(string s, out int CourseIndex, out int Groupindex)
        {
            CourseIndex = -1;
            Groupindex = -1;
            for (int i = 0; i < Course.Count; i++)
                if (Course[i].IsGroupIn(s, out Groupindex))
                { CourseIndex = i; return true; }
            return false;
        }
        public bool IsPresentIn(string s, out int CourseIndex, out int Groupindex)
        {
            CourseIndex = -1;
            Groupindex = -1;
            for (int i = 0; i < Course.Count; i++)
                if (Course[i].IsPresentIn(s, out Groupindex))
                { CourseIndex = i; return true; }
            return false;
        }
        public bool IsDayIn(string s, out int CourseIndex, out int Groupindex)
        {
            CourseIndex = -1;
            Groupindex = -1;
            for (int i = 0; i < Course.Count; i++)
                if (Course[i].IsDayIn(s, out Groupindex))
                { CourseIndex = i; return true; }
            return false;
        }
        public bool IsPeriodIn(string s, out int CourseIndex, out int Groupindex)
        {
            CourseIndex = -1;
            Groupindex = -1;
            for (int i = 0; i < Course.Count; i++)
                if (Course[i].IsPeriodIn(s, out Groupindex))
                { CourseIndex = i; return true; }
            return false;
        }
    }
}
