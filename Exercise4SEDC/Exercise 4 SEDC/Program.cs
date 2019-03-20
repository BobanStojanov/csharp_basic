using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4_SEDC
{
    class Program
    {
        static void Main(string[] args)
        {

            #region

            DateTime today = DateTime.Now;
            Console.WriteLine(today);

            DateTime before3Months = DateTime.Now.AddMonths(-3);
            Console.WriteLine(before3Months);

            DateTime after3Months = DateTime.Now.AddMonths(3);
            Console.WriteLine(after3Months);

            DateTime example = DateTime.Now.AddHours(10);
            Console.WriteLine(example);

            DayOfWeek example2 = DateTime.Now.DayOfWeek;
            Console.WriteLine(example2);
            #endregion
            Console.ReadLine();

            Console.WriteLine(check());
            Console.WriteLine(fair());
            Console.WriteLine(newLine());

            

            Console.WriteLine("Vnesete broj na karakteri:");
            int n = int.Parse(Console.ReadLine());

            string subStr = hello().Substring(0, n);
            Console.WriteLine(subStr);
            Console.WriteLine("The length of the new string is: " + subStr.Length);
            Console.ReadLine();
        }

        public static string hello()
        {
            return "Hello from SEDC Codeacademy v7.0";
        }

        public static string check()
        {
            return "Check your C:\\ drive";
        }
        public static string fair()
        {
            return "We will have \"fair\" elections";
        }
        public static string newLine()
        {
            return "The \\n sign means: new line"; 
        }

        
    }
}
