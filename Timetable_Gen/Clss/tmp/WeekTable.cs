using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Timetable_Gen.Clss.tmp.Flds
{
    class WeekTable
    {
        public List<Course_GroupIndexCls> AddedItems;
        public WeekTable()
        {
            AddedItems = new List<Course_GroupIndexCls>();
        }

        public WeekTable Copy()
        {
            WeekTable wt = new WeekTable();
            for (int i = 0; i < AddedItems.Count; i++)
                wt.AddedItems.Add(new Course_GroupIndexCls(AddedItems[i].Course, AddedItems[i].Group));
            return wt;
        }

        public bool IsEmpty(string Day,string Period,ref AllCourseCls AC)
        {
            for (int i = 0; i < AddedItems.Count; i++)
                foreach (SpacetimeCls ST in AC.Course[AddedItems[i].Course].Group[AddedItems[i].Group].Spacetime)
                    if (ST.Day == Day)
                        if (ST.Period == Period)
                            return false;
            return true;
        }

        public bool IsEmpty(int Course, int Group, ref AllCourseCls AC)
        {
            foreach (SpacetimeCls ST in AC.Course[Course].Group[Group].Spacetime)
                if (!IsEmpty(ST.Day, ST.Period, ref AC))
                    return false;
            return true;
        }

        public bool TryAdd(int Course, int Group, ref AllCourseCls AC)
        {
            if (!IsEmpty(Course, Group, ref AC))
                return false;
            AddedItems.Add(new Course_GroupIndexCls(Course, Group));
            return true;
        }
    }
}
