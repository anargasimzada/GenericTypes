using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Type_HW_0421.Models
{
    internal abstract class Animal
    {
		private int _AvgLifeTime;
		public string _Breed;
		public int _HP;

        public int AvgLifeTime
		{
			get { return _AvgLifeTime; }
			set { if (value > 0) { _AvgLifeTime = value; } }
		}
		enum Gender
		{
			Male,Female
		}




	}
}
