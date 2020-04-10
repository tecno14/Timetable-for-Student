using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Timetable_Gen.Clss.tmp.Flds
{
    class CourseCls
    {
        public string Name;
        public List<GroupCls> Group;

        public CourseCls()
        {
            Group = new List<GroupCls>();
        }
        public int GetGroupIndex(string s)
        {
            if (IsGroupIn(s, out int index))
                return index;
            Group.Add(new GroupCls() { Name = s });
            return Group.Count - 1;
        }
        public bool IsGroupIn(string s, out int GroupIndex)//,out int GroupIndex)
        {
            GroupIndex = -1;
            for (int i = 0; i < Group.Count; i++)
                if (Group[i].Name == s)
                { GroupIndex = i; return true; }
            return false;
        }
        public bool IsPresentIn(string s, out int GroupIndex)
        {
            GroupIndex = -1;
            for (int i = 0; i < Group.Count; i++)
                if (Group[i].IsPresentIn(s))
                { GroupIndex = i; return true; }
            return false;
        }
        public bool IsDayIn(string s, out int GroupIndex)
        {
            GroupIndex = -1;
            for (int i = 0; i < Group.Count; i++)
                if (Group[i].IsDayIn(s))
                { GroupIndex = i; return true; }
            return false;
        }
        public bool IsPeriodIn(string s, out int GroupIndex)
        {
            GroupIndex = -1;
            for (int i = 0; i < Group.Count; i++)
                if (Group[i].IsPeriodIn(s))
                { GroupIndex = i; return true; }
            return false;
        }

    }
}
