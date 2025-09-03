using System.Security.Cryptography.X509Certificates;

namespace SchoolAdmin
{
    internal class Program
    {
        public static void DemoStudents()
        {
            Student s1 = new Student();
            Student s2 = new Student();
            s1.Name = "Said Aziz".Trim();
            s2.Name = "Mieke Vermeulen".Trim();
            s1.Courses.Add("Programmeren ");
            s1.Courses.Add("Databanken ");
            s2.Courses.Add("Communicatie ");
            s1.Birthdate = new DateTime(2000, 06, 01);
            s2.Birthdate = new DateTime(1998, 01, 01);
            s1.StudentCounter++;
            s2.StudentCounter++;
            s1.GenerateNameCard();
            Console.WriteLine(s1.DetermineWorkLoad());
            s2.GenerateNameCard();
            Console.WriteLine(s2.DetermineWorkLoad());
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Wat wil je doen?" +
                "\n1. DemonstreerStudenten uitvoeren");
            int number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case 1:
                    DemoStudents();
                    break;
                default:
                    Console.WriteLine("Onbekende keuze");
                    break;
            }
           
        }
    }
}
