using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Timetable_Gen.Clss.tmp.Flds
{
    class RoomCls
    {
        public int Id { get; }

        private static int i = 0;

        public string Name { get; set; }

        public RoomCls(string name)
        {
            this.Id = ++i;
            this.Name = Name;
        }
    }
}
