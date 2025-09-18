namespace schooladmin
{
    internal class Program
    {
        public static void DemoStudents()
        {

            Student said = new Student();
            Student mieke = new Student();
            said.Name = "Said Aziz";
            said.Birthday = new DateTime(2000, 06, 01);
            said.RegisterCourseResult("Programmeren",15);
            said.RegisterCourseResult("Communicatie",12);
            said.RegisterCourseResult("webtechnologie",13);

        
            mieke.Name = "Mieke Vermeulen";
            mieke.Birthday = new DateTime(1998, 01, 01);
            mieke.RegisterCourseResult("Programmeren", 16);
            mieke.RegisterCourseResult("Databanken", 14);
            mieke.RegisterCourseResult("webtechnologie",15);

            said.ShowOverview();
            mieke.ShowOverview();
        }
        public static void DemoCourses()
        {
            Student said = new Student();
            Student mieke = new Student();
            said.Name = "Said Aziz";
            mieke.Name = "Mieke Vermeulen";
            Course databanken = new Course();
            Course communicatie = new Course();
            Course programmeren = new Course();
            Course webtechnologie = new Course();
            databanken.Title = "Databanken";
            communicatie.Title = "communicatie";
            programmeren.Title = "programmeren";
            webtechnologie.Title = "webtechnologie";
            communicatie.Students.Add(mieke);
            communicatie.Students.Add(said);
            programmeren.Students.Add(mieke);
            programmeren.Students.Add(said);
            webtechnologie.Students.Add(said);
            databanken.Students.Add(mieke);

            communicatie.ShowOverview();
            programmeren.ShowOverview();
            webtechnologie.ShowOverview();
            databanken.ShowOverview();
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Wat wil je doen?" +
                "\n1. Demonstreerstudenten uitvoeren" +
                "\n2. DemonstreerCursussen uitvoeren");
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
