using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Type_HW_0421.Models
{
    internal class Grass:Food
    {
        private int v1;
        private string v2;

        public Grass(int v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public string Name { get; set; }
    }
}
