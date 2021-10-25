using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4
{
   public class Genre
    {
        public Genre(int code, string name, string description)
        {

            Code = code;
            Name = name;
            Description = description;
        }

        public Genre()
        {

        }


        public int Code { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
