using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Types_CW_2104.Models
{
    internal class Student
    {
        static int _count = 1;
        public int Id { get; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int Credits { get; set; }
        public Group Group { get; set; }
        public Student(string name,string surname,int age,int credits,Group group)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Credits = credits;
            Group = group;
            Id = _count++;
        }


    }
}
