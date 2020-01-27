using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace תרגיל_בגרות_תשעח
{
    class TwoItems
    {
        private int num1;
        private int num2;
        public TwoItems(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
        public override string ToString()
        {
            return "[" + this.num1 + "," + this.num2 + "]";
        }
    }
}
