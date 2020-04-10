using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Timetable_Gen.Clss.tmp.Flds
{
    class GroupCls
    {
        public string Name;
        public string Present;
        public List<SpacetimeCls> Spacetime;

        public GroupCls()
        {
            Spacetime = new List<SpacetimeCls>();
        }
        public int GetSpacetimeIndex(string DayT, string PeriodT, string RoomT)
        {
            if (IsSpacetimeIn(DayT, PeriodT, RoomT, out int index))
                return index;
            Spacetime.Add(new SpacetimeCls() { Day = DayT, Period = PeriodT, Room = RoomT });
            return Spacetime.Count - 1;
        }
        public bool IsSpacetimeIn(string Day, string Period, string Room, out int STIndex)
        {
            STIndex = -1;
            for (int i = 0; i < Spacetime.Count; i++)
                if ((Spacetime[i].Day == Day) && (Spacetime[i].Period == Period))
                { Spacetime[i].Room = Room;  STIndex = i; return true; }
            return false;
        }
        public bool IsPresentIn(string s)
        {
            return (Present == s);
        }
        public bool IsDayIn(string s)
        {
            foreach (SpacetimeCls i in Spacetime)
                if (i.IsDayIn(s))
                    return true;
            return false;
        }
        public bool IsPeriodIn(string s)
        {
            foreach (SpacetimeCls i in Spacetime)
                if (i.IsPeriodIn(s))
                    return true;
            return false;
        }
    }
}
