using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethodClass_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            VoidMethod instance1 = new VoidMethod();
            instance1.DoACoupleOfThings(5, 60);
            instance1.DoACoupleOfThings(num1: 5, num2: 60);
        }
    }
}
