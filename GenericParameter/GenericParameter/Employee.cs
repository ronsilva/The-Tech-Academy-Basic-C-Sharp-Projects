using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericParameter
{
    public class Employee<T>
    {
        public Employee()
        {
            List<T> Things = new List<T>();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        public List<T> Things { get; set; }

    }
}
