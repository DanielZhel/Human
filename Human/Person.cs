using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    public class Person
    { 
        public int Age { get; set; }

        public void Great()
        {
            Console.WriteLine("Hello");

        }
        public void SetAge(int age)
        {
             Age = age;
        }
    }
}
