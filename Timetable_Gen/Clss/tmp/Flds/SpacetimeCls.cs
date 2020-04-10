using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Timetable_Gen.Clss.tmp.Flds
{
    class SpacetimeCls
    {
        public string Day;
        public string Period;
        public string Room;

        public SpacetimeCls()
        {

        }
       
        public bool IsDayIn(string s)
        {
            return (Day == s);
        }
        public bool IsPeriodIn(string s)
        {
            return (Period == s);
        }

        //public int Id { get; }
        //private static int i = 0;
        /*
        public DayCls Day;
        public PeriodCls Period;
        public RoomCls Room;

        public SpacetimeCls(DayCls day, PeriodCls period, RoomCls room)
        {
            Day = day;
            Period = period;
            Room = room;
        }
        */
    }
}
