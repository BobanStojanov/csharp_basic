using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.Enums;

namespace ClassLibrary1.Classes
{
    public class Cinema
    {

        public string Name { get; set; }
        public List<int> Halls { get; set; }
        public List<Movie> ListOfMovies { get; set; }

        public Cinema(string name)
        {
            Name = name;
        }

        public static string MoviePlaying(Movie movie)
        {
            return $"Now is playing {movie.Title}";
        }
    }
}
