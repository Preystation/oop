namespace schooladmin
{
    internal class Program
    {
        public static void DemoStudents()
        {

            Student said = new Student("Said Aziz", new DateTime(2000, 06, 01));
            Student mieke = new Student("Mieke Vermeulen", new DateTime(1998, 01, 01));
      

            Console.WriteLine(said.GenerateNameCard());
            Console.WriteLine(said.DetermineWorkload());
            Console.WriteLine(mieke.GenerateNameCard());
            Console.WriteLine(mieke.DetermineWorkload());
        }
        public static void DemoCourses()
        {
            Student said = new Student("Said Aziz", new DateTime(2000, 06, 01));
            Student mieke = new Student("Mieke Vermeulen", new DateTime(1998, 01, 01));
            Course databanken = new Course("Databanken");
            Course communicatie = new Course("communicatie");
            Course programmeren = new Course("programmeren");
            Course webtechnologie = new Course("webtechnologie");
            programmeren.Students.Add(said);
            communicatie.Students.Add(said);
            webtechnologie.Students.Add(said);

            programmeren.Students.Add(mieke);
            communicatie.Students.Add(mieke);
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
