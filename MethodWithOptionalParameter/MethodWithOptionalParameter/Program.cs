using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodWithOptionalParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            MOWOpParam mo = new MOWOpParam();
            Console.WriteLine("Please enter a number: ");
            int num1  = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int total = mo.MOMath(num1, num2);
            Console.WriteLine("Your total is: {0}. which is also your second number: {1}", total, num2 );
            Console.ReadLine();

        }
    }
}
