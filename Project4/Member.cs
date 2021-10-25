using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4
{
    public class Member
    {
        public Member(int id, string name, DateTime doB, int typeId)
        {
            Id = id;
            Name = name;
            DoB = doB;
            TypeId = typeId;
        }

        public Member()
        {

        }
        public int Id {get; set;}
        public string Name { get; set; }
        public DateTime DoB { get; set; }
        public int TypeId { get; set; }
    }
}
