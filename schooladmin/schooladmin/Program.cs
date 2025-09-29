namespace schooladmin
{
    internal class Program
    {
        public static void ReadTextFormatStudent()
        {

        }
        public static void DemoStudents()
        {

            Student said = new Student("Said Aziz", new DateTime(2000, 06, 01));
            Student mieke = new Student("Mieke Vermeulen", new DateTime(1998, 01, 01));
            Course databanken = new Course("Databanken");
            Course webtechnologie = new Course("webtechnologie");
            Course programmeren = new Course("Programmeren");
            Course communicatie = new Course("communicatie");

            said.RegisterCourseResult(communicatie.Title, 12);
            said.RegisterCourseResult(programmeren.Title, null);
            said.RegisterCourseResult(webtechnologie.Title, 13);

            Console.WriteLine(said.GenerateNameCard());
            Console.WriteLine(said.DetermineWorkload());
            Console.WriteLine(mieke.GenerateNameCard());
            Console.WriteLine(mieke.DetermineWorkload());
        }
        public static void DemoCourses()
        {
            Student said = new Student("Said Aziz", new DateTime(2000, 06, 01));
            Student mieke = new Student("Mieke Vermeulen", new DateTime(1998, 01, 01));
            List<Student> StudentsDatabanken = new List<Student>();
            List<Student> Studentscommunicatie = new List<Student>();
            List<Student> Studentsprogrammeren = new List<Student>();
            List<Student> Studentswebtechnologie = new List<Student>();
            StudentsDatabanken.Add(mieke);
            Studentscommunicatie.Add(said);
            Studentscommunicatie.Add(mieke);
            Studentsprogrammeren.Add(said);
            Studentsprogrammeren.Add(mieke);
            Studentswebtechnologie.Add(said);
            Course databanken = new Course("databanken",StudentsDatabanken,9);
            Course communicatie = new Course("communicatie", Studentscommunicatie,6);
            Course programmeren = new Course("programmeren", Studentsprogrammeren,9);
            Course webtechnologie = new Course("webtechnologie", Studentswebtechnologie,9);

       

            communicatie.ShowOverview();
            programmeren.ShowOverview();
            webtechnologie.ShowOverview();
            databanken.ShowOverview();
           
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Wat wil je doen?" +
                "\n1. Demonstreerstudenten uitvoeren" +
                "\n2. Demonstreercursusen uitvoeren");
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
                    break;
            }
        }

    }
}
