using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary
{
    public class Game
    {
        public int Id { get; set; }
        public string Titel { get; set; }
        public double Rating { get; set; }


        // Altid have en default constructor
        public Game()
        {
        }

        public Game(int id, string titel, double rating)
        {
            Id = id;
            Titel = titel;
            Rating = rating;
        }

        public override string ToString()
        {

            return $"{nameof(Id)}: {Id}, {nameof(Titel)}: {Titel}, {nameof(Rating)}: {Rating}";
        }
    }
}
