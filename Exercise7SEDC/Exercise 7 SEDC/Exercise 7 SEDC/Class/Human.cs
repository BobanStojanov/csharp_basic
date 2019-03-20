using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7_SEDC.Class
{
    public class Human
    {

        public string Name { get; set; }
        public int Age { get; set; }


        public Human(string Name, int Age) 
        {
            Console.WriteLine("Constructor with properties");
            Name = Name;
            Age = Age; 
       
        }

        public Human()
        {
            Console.WriteLine("Human Default constructor called");
        }

        public virtual string PrintInfo()
        {
            return $"I am {Name} and i have {Age} years.";
        }
    }
}
