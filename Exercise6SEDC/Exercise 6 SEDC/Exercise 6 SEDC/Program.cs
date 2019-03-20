using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6_SEDC
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            RepetitionFunc();

           
        }
        public static void RepetitionFunc()
        {
            string checker;
            do
            {
                decimal mainNumber = decimal.Parse(Number());
                NumberStats(mainNumber);

                Console.WriteLine("Sakate li da proverite nov broj? (odberete Y za DA ili X da napustite)");
                checker = Console.ReadLine();
            } while (checker.ToUpper() == "Y");

            if (checker.ToUpper() == "X")
            {
                Console.WriteLine("Ja zavrsivte programata!");
                Console.ReadLine();
            } else
            {
                Console.WriteLine("Vnesovte pogresen karakter");
                Console.ReadLine();
            }
        }
        public static void NumberStats( decimal MainNum)
        {
            Console.WriteLine(PosNeg(MainNum));
            Console.WriteLine(OddEven(MainNum));
            Console.WriteLine(DecInt(MainNum));
            Console.ReadLine();

        }

        public static string Number()
        {
            Console.WriteLine("Vnesete eden broj:");
            return Console.ReadLine();
        }
        public static string PosNeg ( decimal num1)
        {
            
            if (num1 < 0)
            {
                return "The number is negative!";
            }
            else if (num1 > 0)
            {
                return "The number is positive!";
            } else
            {
                return "The number is 0.";
            }

        }
        public static string OddEven(decimal num1)
        {
            if(num1 % 2 == 0)
            {
                return "The number is Even";
            } else
            {
                return "The number is Odd";
            }
                
        }
        public static string DecInt(decimal num1)
        {
            if (num1 % 1 > 0)
            {
                return "The number is Decimal";
            } else
            {
                return "The number is Integer";
            }
        }
    }
}
