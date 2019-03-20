using Songs.Classes;
using Songs.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Songs;

namespace Vezba1
{
    class Program
    {
        static void Main(string[] args)
        {

            Class1 class1 = new Class1();
            List<Person> CreateFans = new List<Person>();

            Person Jerry = new Person(1, "Jerry", "Tompson", 78, Genre.Rock);
            Person Stefan = new Person(2, "Stefan", "Stefanoski", 28, Genre.Techno);
            Person Maria = new Person(3, "Maria", "Campbel", 43, Genre.Classical);
            Person Jane = new Person(4, "Jane", "Doe", 28, Genre.Techno);
            CreateFans.Add(Jerry);
            CreateFans.Add(Stefan);
            CreateFans.Add(Maria);
            CreateFans.Add(Jane);

            Console.WriteLine(CreateFans[0].FavoriteMusicType);

            Console.WriteLine(class1.song1.Title);

            Console.ReadLine();


            


        }

    }
}
