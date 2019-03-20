using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libraries.class_library;

namespace Vezbi_Exercise_7_SEDC
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee Zlatko = new Employee("Boban", "Stojanov");
            

            Console.WriteLine(Zlatko.PrintInfo());

            Console.ReadLine();
        }
    }
}
