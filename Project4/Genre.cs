using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4
{
   public class Genre
    {
        public Genre(string code, string name, string description)
        {

            Code = code;
            Name = name;
            Description = description;
        }

        public Genre()
        {

        }


        public string Code { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
