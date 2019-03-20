using ClassLibrary1.Classes;
using ClassLibrary1.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9SEDC
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine();
            Console.WriteLine("Got to end");

          

            Movie movie1 = new Movie("Scary Movie", Genre.Comedy, 8, 2.5);
            Movie movie2 = new Movie("American Pie", Genre.Comedy, 4, 2.5);
            Movie movie3 = new Movie("Saw", Genre.Horror, 4, 2.5);
            Movie movie4 = new Movie("The Shining", Genre.Horror, 4, 2.5);
            Movie movie5 = new Movie("Rambo", Genre.Action, 4, 2.5);
            Movie movie6 = new Movie("The Terminator", Genre.Action, 4, 2.5);
            Movie movie7 = new Movie("Forrest Gump", Genre.Drama, 4, 2.5);
            Movie movie8 = new Movie("12 Angru Men", Genre.Drama, 4, 2.5);
            Movie movie9 = new Movie("Passengers", Genre.SciFi, 4, 2.5);
            Movie movie10 = new Movie("Interstellar", Genre.SciFi, 4, 2.5);
            List<Movie> MovieSet1 = new List<Movie>() { movie1, movie2, movie3, movie4, movie5, movie6, movie7, movie8, movie9, movie10 };
            Movie movie11 = new Movie("Airplane", Genre.Comedy, 4, 2.5);
            Movie movie12 = new Movie("Johnny English", Genre.Comedy, 4, 2.5);
            Movie movie13 = new Movie("The Ring", Genre.Horror, 4, 2.5);
            Movie movie14 = new Movie("Sinister", Genre.Horror, 4, 2.5);
            Movie movie15 = new Movie("RoboCop", Genre.Action, 4, 2.5);
            Movie movie16 = new Movie("Judge Dredd", Genre.Action, 4, 2.5);
            Movie movie17 = new Movie("The Social Network", Genre.Drama, 4, 2.5);
            Movie movie18 = new Movie("The Shawshank Redemption", Genre.Drama, 4, 2.5);
            Movie movie19 = new Movie("Inception", Genre.SciFi, 4, 2.5);
            Movie movie20 = new Movie("Avatar", Genre.SciFi, 4, 2.5);
            List<Movie> MovieSet2 = new List<Movie>() { movie11, movie12, movie13, movie14, movie15, movie16, movie17, movie18, movie19, movie20 };


            Cinema cinema1 = new Cinema("Cineplex");
            cinema1.Halls = new List<int>() { 1, 2, 3, 4 };
            cinema1.ListOfMovies = MovieSet1;
            Cinema cinema2 = new Cinema("Milenium");
            cinema2.Halls = new List<int>() { 1, 2 };
            cinema2.ListOfMovies = MovieSet2;

            Console.ReadLine();
        }

           
        //    try
        //    {
        //        Console.WriteLine(DivideTwoNumbers());
        //    }
          
        //    catch (FormatException e)
        //    {
        //        Console.WriteLine("Format Exception: You entered a character" + " which is not a number");        
        //    }
        //    catch (DivideByZeroException e)
        //    {
        //        Console.WriteLine("Divide by zero exception: You tried divide with 0 ");
        //    }
           
        //    catch (Exception e)
        //    {
        //        Console.WriteLine("This must be always the last catch: Exception");
        //    }

        //    Console.ReadLine();
        //}

        //public static int DivideTwoNumbers()
        //{
        //    Console.WriteLine("Enter a number:");
        //    int first = int.Parse(Console.ReadLine());

        //    Console.WriteLine("Enter second number");
        //    int second = int.Parse(Console.ReadLine());

        //    if (first < 0)
        //    {
        //        throw new Exception("You entered a negative number!");
        //    }

            
        //    return first / second;
        //}
    }
}
