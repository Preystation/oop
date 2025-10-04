namespace SchoolAdmin
{
    internal class Program
    {
        public static void ReadTextFormatStydent()
        {

        }
        public static void DemoStudents()
        {
            Student said = new Student("Said Aziz", new DateTime(2000, 06, 01));
            said.Name = " Said Aziz";
            Student mieke = new Student("Mieke Vermeulen", new DateTime(1998, 01, 01));
            mieke.Name = "Mieke Vermeulen";
            said.RegisterCourseResult("Webtechnoligie", 12);
            said.RegisterCourseResult("Programmeren", 15);
            said.RegisterCourseResult("Webtechnoligie", 13);

            said.ShowOverview();
           mieke.ShowOverview();
        }

        public static void DemoCourses()
        {
            Student said = new Student("Said Aziz", new DateTime(2000, 06, 01));
            Student mieke = new Student("Mieke Vermeulen", new DateTime(1998, 01, 01));
            List<Student> studentenDatabanken = new List<Student>() { mieke };
            List<Student> studentenCommunicatie = new List<Student>() { said, mieke };
            List<Student> studentenProgrammeren = new List<Student>() { said, mieke };
            List<Student> studentenWebtechnologie = new List<Student>() { said };

            Course databanken = new Course("Databanken",studentenDatabanken);
            Course programmeren = new Course("Programmeren", studentenProgrammeren,3);
            Course webtechnologie = new Course("Webtechnoligie", studentenWebtechnologie);
            Course communicatie = new Course("Communicatie", studentenCommunicatie,6);
            
            // communicatie.Students.Add(said);
            ///communicatie.Students.Add(mieke);
            // programmeren.Students.Add(said);
            //  programmeren.Students.Add(mieke);
            // webtechnologie.Students.Add(said);
            // databanken.Students.Add(mieke);
            communicatie.ShowOverview();
            programmeren.ShowOverview();
            webtechnologie.ShowOverview();
            databanken.ShowOverview();

        }
        static void Main(string[] args)
        {
            Student said = new Student("Said Aziz", new DateTime(2000, 06, 01));
            
            
            said.RegisterCourseResult("Webtechnoligie", 12);
            said.RegisterCourseResult("Programmeren",15);
            said.RegisterCourseResult("Webtechnoligie",13);

            Student mieke = new Student("Mieke Vermeulen", new DateTime(1998, 01, 01));
            mieke.RegisterCourseResult("Communicatie",13);
            mieke.RegisterCourseResult("Programmeren", 16);
            mieke.RegisterCourseResult("Databanken", 14);
            int studentnumber = Student.StudentCounter;

           // Console.WriteLine($"{said.Name}, geboren {said.Birthdate.ToString("d")} met studentnummer {studentnumber++}; Said volgt {said.Courses[0]} en {said.Courses[1]}");
           // Console.WriteLine($"{mieke.Name}, geboren {mieke.Birthdate.ToString("d")} met studentnummer {studentnumber++}; Mieke volgt {mieke.Courses[0]}");

            Console.WriteLine("Wat wil je doen?");
            int userCoice = Convert.ToInt32(Console.ReadLine());
            switch (userCoice)
            {
                case 1:
                    DemoStudents();
                    break;
                case 2:
                    DemoCourses();
                    break;
                case 3:

                    ReadTextFormatStydent();
                    break;
                default:
                    Console.WriteLine("Keuze is niet herkent");
                    break;
            }
        
        
        }
    }
}
