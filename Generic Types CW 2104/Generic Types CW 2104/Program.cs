using Generic_Types_CW_2104.Models;

namespace Generic_Types_CW_2104
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Group ab106 = new Group("ab106");
            Group af104 = new Group("af104");
            Group az222 = new("az222");

            List<Student> students = new List<Student>();
            students.Add(new Student("Anar", "Qasimzada", 20, 100, ab106));
            students.Add(new Student("Nurlan", "Abbasov", 20, 150, af104));
            students.Add(new Student("Nurvin", "Qasimzada", 19, 300, ab106));
            students.Add(new Student("Ayxan", "Demirov", 20, 170, az222));



            //students.FindAll(s => s.Group == ab106).ForEach(s => Console.WriteLine(s.Id + " " + s.Name));
            //students.FindAll(s => s.Group == af104).ForEach(s => Console.WriteLine(s.Id + " " + s.Name));
            //students.FindAll(s => s.Group ==az222).ForEach(s => Console.WriteLine(s.Id + " " + s.Name));
            //students.FindAll(S => S.Group == af104).ForEach(s => Console.WriteLine(s.Id + " " + s.Name));

            students.FindAll(s=> s.Credits<300).ForEach(s=>Console.WriteLine(s.Id+" "+s.Name));
            students.ForEach(s => Console.WriteLine(s.Name + " " + s.Surname));
            students.FindAll(s => s.Name.ToLower().Contains("b")).ForEach(s=> Console.WriteLine(s.Id+" "+s.Name));
            foreach (Student s in students.OrderBy(s => s.Credits))
            {
                Console.WriteLine(s.Id  + " " + s.Name);
            }
            students.FindAll(s => s.Age < 18).ForEach(s => Console.WriteLine(s.Id + " " + s.Name));

        }
    }
}
