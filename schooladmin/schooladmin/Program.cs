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
            said.Courses.Add("Programmeren");
            said.Courses.Add("Databanken");

            mieke.Name = "Mieke Vermeulen";
            mieke.Birthday = new DateTime(1998, 01, 01);
            mieke.Courses.Add("Communicatie");


            Console.WriteLine(said.GenerateNameCard());
            Console.WriteLine(said.DetermineWorkload());
            Console.WriteLine(mieke.GenerateNameCard());
            Console.WriteLine(mieke.DetermineWorkload());
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Wat wil je doen?" +
                "\n1. Demonstreerstudenten uitvoeren");
            int number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case 1:
                    DemoStudents();
                    break;

                default:
                    break;
            }
        }

    }
}
