using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Sedc
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            double y;
            x = 10;
            y = 20;
            int a;
            int b;
            a = 30;
            b = 40;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(a);
            Console.WriteLine(b);
           

            string name;
            string surename;

            name = "Boban ";
            surename = "Stojanov";

            string first;
            string second;
            first = "9";
            second = "3";
            string res = first + second;

            Console.WriteLine(name + surename);
            Console.WriteLine(res);
            

            int num1;
            string num2;
            num1 = 2;
            num2 = "5";
            string sum;
            sum = num1 + num2;

            Console.WriteLine(sum);

            int n;
            int m;
            n = 102;
            m = 5;

            int sumOfsms = n / m;

            Console.WriteLine(sumOfsms);

            double d = 8;
            double s = 5;
            double branch = 12;
            Console.WriteLine("Vnesete broj na drva:");
            string brojNaDrva = Console.ReadLine();
            double parse = double.Parse(brojNaDrva);
            Console.WriteLine("Imate vneseno " + brojNaDrva + " drva. Ke ti treba " + Math.Round((d * branch * parse) / s) + " korpi da gi soberes site jabolka.");
            Console.ReadLine();

            Console.WriteLine("Vnesete dva broja");
            string zum1 = Console.ReadLine();
            string zum2 = Console.ReadLine();
            double num1Parsed = double.Parse(zum1);
            double num2Parsed = double.Parse(zum2);
            if (num1Parsed > num2Parsed) 
            {
                Console.WriteLine(zum1 + " is bigger then " + zum2);
            } else if (num2Parsed > num1Parsed)
            {
                Console.WriteLine(num2Parsed + " is bigger then " + num1Parsed);
            } else
            {
                Console.WriteLine("They are equal");
                
            }
            if(num1Parsed % 2 == 0)
            {
                Console.WriteLine(zum1 + " is even number ");
            } else
            {
                Console.WriteLine(zum1 + " is Odd number ");
            }
            if(num2Parsed % 2 == 0)
            {
                Console.WriteLine(zum2 + " is even number ");
            } else
            {
                Console.WriteLine(zum2 + " is Odd number ");
            }
            Console.ReadLine();


        }
    }
}
