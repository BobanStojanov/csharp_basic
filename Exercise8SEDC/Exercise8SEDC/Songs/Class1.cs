using Songs.Classes;
using Songs.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Songs
{
    public class Class1
    {

        public List<Person> CreateFans = new List<Person>();

        public Person Jerry = new Person(1, "Jerry", "Tompson", 78, Genre.Rock);
        public Person Stefan = new Person(2, "Stefan", "Stefanoski", 28, Genre.Techno);
        public Person Maria = new Person(3, "Maria", "Campbel", 43, Genre.Classical);
        public Person Jane = new Person(4, "Jane", "Doe", 28, Genre.Techno);


       


        public Song song1 = new Song("Bohemian Rhapsody", 367, Genre.Rock);
        public Song song2 = new Song("Stairway To Heaven", 480, Genre.Rock);
        public Song song3 = new Song("Riders On The Storm", 430, Genre.Rock);
        public Song song4 = new Song("Not Fade Away", 108, Genre.Rock);
        public Song song5 = new Song("Breaking Glass", 111, Genre.Rock);
        public Song song6 = new Song("Welcome To The Jungle", 275, Genre.Rock);
        public Song song7 = new Song("Walk Of Life", 266, Genre.Rock);
        public Song song8 = new Song("Smoke on the Water", 340, Genre.Rock);
        public Song song9 = new Song("93 'til Infinity", 209, Genre.Techno);
        public Song song10 = new Song("Fight the Power", 321, Genre.Techno);
        public Song song11 = new Song("The Message", 363, Genre.Techno);
        public Song song12 = new Song("Butterfly Effect", 213, Genre.Techno);
        public Song song13 = new Song("No Fear", 182, Genre.Techno);
        public Song song14 = new Song("Hereditary", 340, Genre.Techno);
        public Song song15 = new Song("Bounce Back", 226, Genre.Techno);
        public Song song16 = new Song("The Four Seasons", 2520, Genre.Classical);
        public Song song17 = new Song("Canon in D major", 376, Genre.Classical);
        public Song song18 = new Song("Swan Lake", 461, Genre.Classical);
        public Song song19 = new Song("Symphony No. 5", 425, Genre.Classical);
        public Song song20 = new Song("Ride of the Valkyries", 608, Genre.Classical);
        public Song song21 = new Song("The Magic Flute", 458, Genre.Classical);
        public Song song22 = new Song("Carmen Suite No.1", 721, Genre.Classical);
        public Song song23 = new Song("Planet E", 420, Genre.Techno);
        public Song song24 = new Song("Phasor", 368, Genre.Techno);
        public Song song25 = new Song("Counting Comets", 242, Genre.Techno);
        public Song song26 = new Song("Cold Summer", 358, Genre.Techno);
        public Song song27 = new Song("Destroyer", 359, Genre.Techno);
        public Song song28 = new Song("Phalanx", 307, Genre.Techno);
        public Song song29 = new Song("Vision", 693, Genre.Techno);
        public Song song30 = new Song("Chain Reaction", 181, Genre.Techno);

        List<Song> Songs = new List<Song>();
    }
}
