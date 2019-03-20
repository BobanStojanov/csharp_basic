
using Libraries.class_library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraries
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee Zlatko = new Employee { };
            Zlatko.FirstName = "Zlatko";
            Zlatko.LastName = "Gornjevski";
            Zlatko.Role = Role.Sales;

            Console.WriteLine(Zlatko.PrintInfo());

            Console.ReadLine();
        }
    }
}
