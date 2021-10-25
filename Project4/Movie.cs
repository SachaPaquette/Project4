using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4
{
   public class Movie
    {

        public Movie(int id, string title, int year, string length, double rating, string path)
        {
           
            Title = title;
            Year = year;
            Length = length;
            Rating = rating;
            Path = path;
        }
        public Movie()
        {

        }

        public Movie(int id, string genre, string title, int year, string length, string director, double rating, string path)
        {
            Genre = genre;
            Title = title;
            Year = year;
            Length = length;
            Director = director;
            Rating = rating;
            Path = path;
        }

        public int Id { get; set; }
        public string Genre { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }

        public string Length { get; set; }
        public string Director { get; set; }
        public double Rating { get; set; }
        public string Path { get; set; }
    }
}
