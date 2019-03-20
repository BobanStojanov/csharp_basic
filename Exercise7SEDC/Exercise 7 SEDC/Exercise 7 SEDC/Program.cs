using Exercise_7_SEDC.Class;
using Exercise_7_SEDC.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercise_7_SEDC
{
    class Program
    {
        static void Main(string[] args)
        {

            Programmer Programmer1 = new Programmer(Title.Junior, "C#", 1, "Jonce", 29);

            Console.WriteLine(Programmer1);

            Console.ReadLine();
        }
    }
}
