using System;

namespace StruckNumber
{
    class Program
    {
        static void Main()
        {
            //1.Create a struct called Number and give it the property "Amount" and have it be of data type decimal. DONE

            //2. In the Main() method, create an object of data type Number and assign an amount to it.

            Number num = new Number();
            num.Amount = 5;

            //3. Print this amount to the console.

            Console.Write(num.Amount);
            Console.ReadLine();
        }
    }
}
