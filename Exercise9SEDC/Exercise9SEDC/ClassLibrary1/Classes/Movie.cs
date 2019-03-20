using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.Enums;

namespace ClassLibrary1.Classes
{
    public class Movie
    {

        public string Title { get; set; }
        public Genre Genre { get; set; }
        public int Rating { get; set; }
        public double TicketPrice { get; set; }


        public Movie(string title, Genre genre, int rating, double ticketPrice)
        {
            Title = title;
            Genre = genre;
            Rating = rating;
            TicketPrice = 5* Rating;
            try
            {
                if(rating <= 5 && rating >=1)
                {
                    Console.WriteLine($"Ur rating is: {rating}");
                    
                }  else
                {
                    throw new Exception("Enter a number from 1 to 5");
                   
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }


    }  
}
