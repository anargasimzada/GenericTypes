using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Types_CW_2104.Models
{
    internal class Group
    {
        static int _count = 1;
        public int Id { get; set; }
        public string Name { get; set; }
        public Group(string name)
        {
            Name = name;
            Id = _count++;
        }
    }
}
