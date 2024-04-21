using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Type_HW_0421.Models
{
    internal class ZooCage<T,U>
    {
        public T Animal { get; set; }
        public U Food { get; set; }
    }
}
