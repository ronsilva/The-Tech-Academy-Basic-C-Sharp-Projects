using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading_Project
{
    public class MathOp
    {
        public int IntMathOp(int integer)
        {
            int result = integer + 7;
            return result;
        }
        public int IntMathOp(decimal deci)
        {
            decimal dResult = deci * 7;
            int result = Convert.ToInt32(dResult);
            return result;
        }
        public int IntMathOp(string line)
        {
            int result = 0;
            int tempResult = 0;
            
            try
            {
                int sToInt = Convert.ToInt32(line);
                tempResult = sToInt / 4;
            }
            catch (Exception ex)
            {
                Console.WriteLine("*****************************");
                Console.WriteLine(ex);
                Console.WriteLine("*****************************");
            }
            finally
            {
                int number;
                if (int.TryParse(line, out number))
                {
                    result = tempResult;
                }
                else
                {
                    Console.WriteLine("Sorry! Couldn't do that.");
                }
            }
            return result;
        }
    }
}
