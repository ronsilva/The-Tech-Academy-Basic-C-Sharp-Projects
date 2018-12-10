using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodWithOptionalParameter
{
    public class MOWOpParam
    {
        public int MOMath(int num1, int num2 = 0)
        {
            int total = (num1 * num2) / num1;
            return total;
        }
    }
}
