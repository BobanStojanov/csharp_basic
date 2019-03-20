using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Songs.Enums;

namespace Songs.Classes
{
    public class Song
    {

        public string Title { get; set; }
        public double Length { get; set; }
        public Genre Genre { get; set; }


        public Song(string title, double length, Genre genre)
        {
            Title = title;
            Length = length;
            Genre = genre;
        }
    }
}
