namespace SchoolAdmin
{

    internal class Program
    {
        public static void DemoStudents()
        {

            Student said = new Student("Said Aziz", new DateTime(2000, 06, 01));
            Student mieke = new Student("Mieke Vermeulen", new DateTime(1998, 01, 01));

            Course databanken = new Course("Databanken");
            Course programmeren = new Course("Programmeren");
            Course webtechnologie = new Course("Webtechnologie");
            Course communicatie = new Course("Communicatie");
            said.RegisterCourseResult(communicatie, 12);
            said.RegisterCourseResult(programmeren, null);
            said.RegisterCourseResult(webtechnologie, 13);

            mieke.RegisterCourseResult(communicatie, 13);
            mieke.RegisterCourseResult(programmeren, 16);
            mieke.RegisterCourseResult(databanken, 13);


            said.ShowOverview();
            mieke.ShowOverview();



        }
        public static void DemoCourses()
        {
            Student said = new Student("Said Aziz", new DateTime(2000, 06, 01));
            Student mieke = new Student("Mieke Vermeulen", new DateTime(1998, 01, 01));
            List<Student> studenten = new List<Student>() { said, mieke };
            Course databanken = new Course("Databanken");
            Course programmeren = new Course("Programmeren", studenten, 3);
            Course webtechnologie = new Course("Webtechnologie");
            Course communicatie = new Course("Communicatie", studenten, 6);

            databanken.Students.Add(mieke);
            webtechnologie.Students.Add(said);

            said.RegisterCourseResult(communicatie, 12);
            said.RegisterCourseResult(programmeren, null);
            said.RegisterCourseResult(webtechnologie, 13);

            mieke.RegisterCourseResult(communicatie, 13);
            mieke.RegisterCourseResult(programmeren, 16);
            mieke.RegisterCourseResult(databanken, 14);
            databanken.ShowOverview();
            programmeren.ShowOverview();
            webtechnologie.ShowOverview();
            communicatie.ShowOverview();
        }
        public static void DemoAdministrativePersonnel()
        {
            var taken = new Dictionary<string, byte>();
            taken.Add("roostering", 10);
            taken.Add("correspondentie", 10);
            taken.Add("animatie", 10);
            AdministrativePersonnel ahmed = new AdministrativePersonnel("Ahmed Azzaoui", new DateTime(1988, 2, 4), taken);
            ahmed.Seniority = 4;
            foreach (var personeel in AdministrativePersonnel.AllAdministrativePersonnel)
            {
                Console.WriteLine(personeel.GenerateNameCard());
            }
            Console.WriteLine(ahmed.CalculateSalary());
            Console.WriteLine(ahmed.DetermineWorkLoad());

        }
        public static void DemoLecturers()
        {
            var tasks = new Dictionary<string, byte>();
            var economie = new Course("Economie");
            var statistiek = new Course("Statistiek");
            var analytischeMeetkunde = new Course("Analytische meetkunde");
            var anna = new Lecturer("Anna Bolzano", new DateTime(1975, 6, 12), tasks);
            anna.Courses.Add(economie, 3);
            anna.Courses.Add(statistiek, 3);
            anna.Courses.Add(analytischeMeetkunde, 4);
            anna.Seniority = 9;
            foreach (var personeel in Lecturer.AllLecturers)
            {
                Console.WriteLine(personeel.GenerateNameCard());
            }
            Console.WriteLine(anna.CalculateSalary());
            Console.WriteLine(anna.DetermineWorkLoad());
        }
        public static void DemoStudyProgram()
        {/*
            Course communicatie = new Course("Communicatie");
            Course programmeren = new Course("Programmeren");
            Course databanken = new Course("Databanken");
            List<Course> courses = new List<Course>() { communicatie, programmeren, databanken };
            StudyProgram programmerenProgram = new StudyProgram("Programmeren");
            StudyProgram snbProgram = new StudyProgram("Systeem- en netwerkbeheer");
            programmerenProgram.Courses = courses;
            snbProgram.Courses = courses;
            programmerenProgram.ShowOverview();
            snbProgram.ShowOverview();
        }*/
            static void Main(string[] args)
            {

                do
                {
                    Console.WriteLine("Maak een keuze:" +
                        "\n1.Demostudents" +
                        "\n2 DemoCourse" +
                        "\n4 DemonstreerStudieProgramma uitvoeren");
                    int usermenuChoice = Convert.ToInt32(Console.ReadLine());
                    switch (usermenuChoice)
                    {
                        case 1:
                            DemoStudents();
                            break;
                        case 2:
                            DemoCourses();
                            break;
                        case 4:
                            DemoStudyProgram();
                            break;
                        case 5:
                            DemoAdministrativePersonnel();
                            break;
                        case 6:
                            DemoLecturers();
                            break;

                    }
                } while (true);

            }
        }
    }
}