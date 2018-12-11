using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassProject
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            base.SayName();
        }
        public void Quit(Employee employee)
        {
            Console.WriteLine("Employee has quit!");
        }
    }
}
