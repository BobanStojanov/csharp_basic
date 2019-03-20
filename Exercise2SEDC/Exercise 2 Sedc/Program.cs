using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2_Sedc
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter one number:");
            //string inputNumber = Console.ReadLine();
            //int parsedNumber = int.Parse(inputNumber);
            //for(int i = 1; i<=parsedNumber; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("Enter second number:");
            //string inputSecNumber = Console.ReadLine();
            //int parsedSecNumber = int.Parse(inputSecNumber);
            //for(int a = 1; parsedSecNumber >=a; parsedSecNumber--)
            //{
            //    Console.WriteLine(parsedSecNumber);

            //}

            //Console.WriteLine("Enter third number:");
            //string inputThiNumber = Console.ReadLine();
            //int parsedThiNumber = int.Parse(inputThiNumber);
            //for (int i = 2; i <= parsedThiNumber; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("Enter fourth number:");
            //string inputForNumber = Console.ReadLine();
            //int parsedForNumber = int.Parse(inputForNumber);
            //for (int i = 1; i <= parsedForNumber; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //Console.WriteLine("Enter fifth number:");
            //string inputFifNumber = Console.ReadLine();
            //int parsedFifNumber = int.Parse(inputFifNumber);
            //for (int i = 1; i <= parsedFifNumber; i++)
            //{
            //    if (i < 100)
            //    {
            //        if (i % 3 == 0 || i % 7 == 0)
            //        {
            //            continue;
            //        }
            //        else
            //        {
            //            Console.WriteLine(i);
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("The number limit is 100");
            //        break;
            //    }
            //}

            int[] myIntArray = new int[3];

            myIntArray[0] = 5;
            myIntArray[1] = 10;
            myIntArray[2] = 15;

            foreach (var a in myIntArray)
            {
                Console.WriteLine(a);
            }

            string[] myWordArray = new string[5];

            myWordArray[0] = "first";
            myWordArray[1] = "second";
            myWordArray[2] = "third";
            myWordArray[3] = "fourth";
            myWordArray[4] = "fifth";

            double[] myDecimalArray = new double[5];

            char[] myCharArray = new char[5];

            myCharArray[0] = 'a';
            myCharArray[1] = 'b';
            myCharArray[2] = 'c';
            myCharArray[3] = 'd';
            myCharArray[4] = 'e';

            bool[] myBoolArray = new bool[5] { true, true, false, true, false };
            
            
           
        
            int[][] myArray = { new int[2] { 2, 3 }, new int[1] { 4 } };

            




            Console.ReadLine();
            


        }
    }
}
