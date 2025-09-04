using System.Security.Cryptography.X509Certificates;

namespace SchoolAdmin
{
    internal class Program
    {
        public static void DemoStudents()
        {
            Student s1 = new Student("Said Aziz",new DateTime(2000, 06, 01));
            Student s2 = new Student("Mieke Vermeulen",new DateTime(1998, 01, 01));
            s1.RegisterForCourse("Communicatie", 12);
            s1.RegisterForCourse("Programmeren",15);
            s1.RegisterForCourse("Webtechnologie", 13);
            s2.RegisterForCourse("Communicatie", 13);
            s2.RegisterForCourse("Programmeren", 16);
            s2.RegisterForCourse("Webtechnologie", 14); ;
      

            s1.ShowOverview();
            s2.ShowOverview();
        }
        public static void DemoCourses()
        {
            Course communicatie = new Course();
            Course programmeren = new Course();
            Course webtechnologie = new Course();
            Course databanken = new Course();
            communicatie.Title = "communicatie";
            programmeren.Title = "programmeren";
            webtechnologie.Title = "webtechnologie ";
            databanken.Title = "databanken ";
            Student s1 = new Student("Said Aziz", new DateTime(2000, 06, 01));
            Student s2 = new Student("Mieke Vermeulen", new DateTime(1998, 01, 01));
            s1.Name = "Said Aziz".Trim();
            s2.Name = "Mieke Vermeulen".Trim();
            communicatie.Students.Add(s1);
            communicatie.Students.Add(s2);
            programmeren.Students.Add(s1);
            programmeren.Students.Add(s2);
            webtechnologie.Students.Add(s1);
            databanken.Students.Add(s2);

            communicatie.ShowOverview();
            programmeren.ShowOverview();
            webtechnologie.ShowOverview();
            databanken.ShowOverview();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Wat wil je doen?" +
                "\n1. DemonstreerStudenten uitvoeren" +
                "\n2. DemonsteerCursusen uitvoeren");
            int number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case 1:
                    DemoStudents();
                    break;
                case 2:
                    DemoCourses();
                  
                    
                   
                        break;
                default:
                    Console.WriteLine("Onbekende keuze");
                    break;
            }
           
        }
    }
}
