using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class PrabhData : EntertainData
    {
        public override string EntertainGenre()
        {
            return Genre;
        }

        public override string MusicOrMovie()
        {
            return Type;
        }

        public string Title { get; set; }
        public string Rating { get; set; }
        public string Genre { get; set; }
        public string Type { get; set; }


        //Constructors
        public PrabhData() { }

        public PrabhData(string title, string rating)
        {
            Title = title;
            Rating = rating;
        }
        public PrabhData(string title, string rating, string genre, string type)
        {
            Title = title;
            Rating = rating;
            Genre = genre;
            Type = type;
        }

        public override string ToString()
        {
            //	MusicOrMovie / EntertainGenre created by EntertainName: Title has a rating of Rating
            return MusicOrMovie() + "/" + EntertainGenre() + " created by " + EntertainName() + ": " + Title + " has a rating of " + Rating + "\n";
        }
    }
}
