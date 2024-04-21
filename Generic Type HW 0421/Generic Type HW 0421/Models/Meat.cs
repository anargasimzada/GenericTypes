using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Type_HW_0421.Models
{
    internal class Meat:Food
    {
        private int v;
        private object beef;

        public Meat(int v, object beef)
        {
            this.v = v;
            this.beef = beef;
        }

        enum Type
        {

        }
    }
}
