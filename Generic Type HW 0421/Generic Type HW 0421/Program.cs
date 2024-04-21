using Generic_Type_HW_0421.Models;
using System.Reflection;

namespace Generic_Type_HW_0421
{
    internal class Program
    {
        public static object Gender { get; private set; }

        static void Main(string[] args)
        {
          List<int> list = new List<int>();
            Wolf wolf = new(12, "wa", 100, Gender.male, true, 20);
            Elephant elephant = new(34, "eksssa", 300, Gender.female, 150, true);
            Meat meat = new(50, Meat.Type.Beef);
            Grass grass = new(10, "ot");

        }
    }
}
