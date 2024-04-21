using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Type_HW_0421.Models
{
    internal class Wolf:Animal
    {

        public bool IsPrideLeader { get; set; }
        public int AttackDamage { get; set; }

        public void Hunt<T>(T animal) where T : Animal
        {
            animal._HP -= AttackDamage;
        }
    }
}
