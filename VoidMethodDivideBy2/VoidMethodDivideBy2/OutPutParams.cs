using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethodDivideBy2
{
    public static class OutPutParams
    {
        public int Mutilying(int num1, int num2)
        {
            int total = num1 * num2;
            Console.WriteLine(total);
        }
        public int MutilyingTimes3(int num1, int num2, int num3)
        {
            int total = (num1 * num2) * num3;
            Console.WriteLine(total);
        }


    }
}
