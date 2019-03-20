using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3_SEDC
{
    class Program
    {
        static void Main(string[] args)
        {
            string sign = "";
            do
            {

                Console.WriteLine("Vnesete + za sobiranje ili - za odzemanje");

                sign = Console.ReadLine();

                if (sign == "+")
                {
                    Console.WriteLine("Vasiot rezulatat e:" + sum());
                    Console.ReadLine();
                }
                else if (sign == "-")
                {
                    Console.WriteLine("Vasiot rezultat e :" + sub());
                    Console.ReadLine();
                }
            } while (sign != "+" || sign != "-");
          
        }
        
        public static int sum()
        {
            Console.WriteLine("Vnesete eden broj za sobiranje");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Vnesete vtor broj za sobiranje");
            int b = int.Parse(Console.ReadLine());
            int suma = a + b;
            return suma;
        }
        public static int sub()
        {
            Console.WriteLine("Vnesete eden broj za odzemanje");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Vnesete vtor broj za odzemanje");
            int b = int.Parse(Console.ReadLine());
            int subtract = a - b;
            return subtract;

        }
    }
}
