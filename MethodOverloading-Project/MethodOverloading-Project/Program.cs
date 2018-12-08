using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading_Project
{
    class Program
    {
        static void Main()
        {
            //1.0 Create a class. DONE 
            //1.1 In that class, create a method that will take in an integer, do a math operation to it and then return the answer as an integer. DONE
            //2.0 In the Main() method of the console app, instantiate the class. DONE 
            MathOp mo = new MathOp();
            //2.1 and call the one method, passing in an integer, such as 12.
            int result = mo.IntMathOp(12);
            // 2.2 Then display the result to the screen.
            Console.WriteLine(result);
            //3. Add a second method to the class, with the same name, that will take in a decimal, do a different math operation to it and then return the answer as an integer. DONE
            //4. In the Main() method of the console app, instantiate the class and call the second method, passing in a decimal. Display the result to the screen. DONE
            MathOp mo2 = new MathOp();
            int mo2Result = mo2.IntMathOp(12.50m);
            Console.WriteLine(mo2Result);
            //5. Add a third method to the class, with the same name, that will take in a string, convert it to an integer if possible, do a different math operation to it and then return the answer as an integer. DONE
            //6. In the Main() method of the console app, instantiate the class and call the third method, passing in a string that equates to an integer.Display the result to the screen. DONE
            MathOp mo3 = new MathOp();
            int line = mo3.IntMathOp("20");
            Console.WriteLine(line);
            Console.ReadLine();
        }
    }
}
