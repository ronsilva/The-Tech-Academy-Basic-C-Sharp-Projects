using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstVarProject
{
    class GoodNumber
    {
        private int _goodNumber;

        public GoodNumber(string goodFor) : this(goodFor, 5) { }
        public GoodNumber(string goodFor, int goodNumber)
        {
            GoodFor = goodFor;
            Number = goodNumber;
        }
        public string GoodFor { get; set; }
        public int Number { get; set; }
    }
}
