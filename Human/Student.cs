using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    public class Student : Person
    {
        public void Study()
        {
            Console.WriteLine("I'm student. I'm study");

        }
        public void ShowAge()
        {
            Console.WriteLine($"I'm {Age} years old");
        }
    }
}
 