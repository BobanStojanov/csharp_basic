using System;
using Exercise_5_SEDC.Classes;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5_SEDC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter ur name");
            string hName = Console.ReadLine();

            Console.WriteLine("Enter ur nickname");
            string hnickName = Console.ReadLine();

            Console.WriteLine("Enter ur lastname");
            string hlastName = Console.ReadLine();

            Console.WriteLine("Enter ur street");
            string hstreet = Console.ReadLine();

            Console.WriteLine("Enter ur number of street");
            string hNumber = Console.ReadLine();
            int jNumber = int.Parse(hNumber);

            Console.WriteLine("Enter ur postal code");
            string hPostalCode = Console.ReadLine();
            int jPostalCode = int.Parse(hPostalCode);

            Console.WriteLine("Enter ur city");
            string hCity = Console.ReadLine();

            Console.WriteLine("Enter ur age");
            string hAge = Console.ReadLine();
            int jAge = int.Parse(hAge);


            Address_Class Address1 = new Address_Class(hstreet, jNumber, jPostalCode, hCity);
            Human me = new Human(hName, hnickName, hlastName, Address1, jAge);

            Console.WriteLine(me.GetPersonStats());
            //me.Name = "Boban";
            //me.LastName = "Stojanov";
            //me.Age = 29;


            //Human student1 = new Human("Daniel", "Dani", "Cvetkovski", 21);


            //student1.Name = "Daniel";
            //student1.LastName = "Cvetanovski";
            //student1.Age = 21;


            //Console.WriteLine(me.Age);           
            //Console.WriteLine(me.Name);
            //Console.WriteLine(me.LastName);


            //Console.WriteLine(me.GetPersonStats());
            //Console.WriteLine(student1.GetPersonStats());

            

            //Console.WriteLine("Enter dog name:");
            //string dogName = Console.ReadLine();

            //Console.WriteLine("Enter dog race:");
            //string dogRace = Console.ReadLine();

            //Console.WriteLine("Enter dog color:");
            //string dogColor = Console.ReadLine();

            //Dog myDog = new Dog(dogName, dogRace, dogColor);

            //Console.WriteLine("Choose what dog wanna do: \n 1 = If u want to eat. \n 2 = If u wanna play. \n 3 = If u want to chase his tail.");
            //string funk = Console.ReadLine();

            //if(funk == "1")
            //{
            //    Console.WriteLine(myDog.Eat());
            //} else if (funk == "2")
            //{
            //    Console.WriteLine(myDog.Play());
            //} else if(funk == "3")
            //{
            //    Console.WriteLine(myDog.ChaseTail());
            //} else
            //{
            //    Console.WriteLine("Invalid choosen function");
            //}
            

            

            Console.ReadLine();
        }
    }

    class Human
    {
        public Human(string name, string nickName, string lastName, Address_Class Address, int age)
        {
            this.Name = name;
            this.nickName = nickName;
            this.LastName = lastName;
            this.Address = Address;
            this.Age = age;
        }

        public string Name { get; set; }
        public string nickName { get; set; }
        public string LastName { get; set; }
        public Address_Class Address { get; set; }
        public int Age { get; set; }
        public string GetPersonStats()
        {
            return $"Hi this student name is {this.Name} called {this.nickName} with lastname {this.LastName} and i have {this.Age} years and with address {this.Address.City}.";
        }
    }

    class Dog
    {
        public Dog(string name, string race, string color)
        {
            this.Name = name;
            this.Race = race;
            this.Color = color;
        }
        public string Name { get; set; }
        public string Race { get; set; }
        public string Color { get; set; }
        public string Eat()
        {
            return $"The dog {this.Name} witch is {this.Race} and with color {this.Color} is now eating.";
        }
        public string Play()
        {
            return $"The dog {this.Name} witch is {this.Race} and with color {this.Color} is now playing.";
        }
        public string ChaseTail()
        {
            return $"The dog {this.Name} witch is {this.Race} and with color {this.Color} is now chasing its tail.";
        }
    }
}
