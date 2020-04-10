using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pr2txt
{
    class Role
    {
        public string Name;
        public string Column;
        public string Row;
        public bool UseDelRegx;
        public string DelReg;

        public Role()
        {

        }
        public Role(string Name, string Column, string Row, bool DelUseRegx = false, string DelReg = "")
        {
            this.Name = Name;
            this.Column = Column;
            this.Row = Row;
            this.UseDelRegx = DelUseRegx;
            this.DelReg = DelReg;
        }
    }
}
