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
            Student s1 = new Student("Said Aziz", new DateTime(2000, 06, 01));
            Student s2 = new Student("Mieke Vermeulen", new DateTime(1998, 01, 01));
            List<Student> studenten = new List<Student>();
            studenten.Add(s1);
            studenten.Add(s2);

            Course communicatie = new Course("communicatie",studenten,6);
       
            Course programmeren = new Course("programmeren",studenten);
            Course webtechnologie = new Course("webtechnologie");
            Course databanken = new Course("databanken");
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
