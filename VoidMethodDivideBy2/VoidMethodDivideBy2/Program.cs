using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethodDivideBy2
{
    class Program
    {
        static void Main()
        {
            //1.0 Create a class. DONE
            //1.1 In that class, create a void method that outputs an integer. DONE
            //1.2 Have the method divide the data passed to it by 2. DONE

            //2. In the Main() method, instantiate that class.
            VoidMethod vd = new VoidMethod();
            //3.0 Have the user enter a number.
            Console.WriteLine("PLease enter a numer:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            //3.1 Call the method on that number.
            int result = vd.DivideAnInt(num1);
            //3.2 Display the output to the screen. It should be the entered number, divided by two.
            Console.WriteLine(result);
            //4. Create a method with output parameters. DONE
            //5. Overload a method. DONE
            //6. Declare a class to be static. DONE
        }
    }
}
