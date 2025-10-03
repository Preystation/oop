namespace SchoolAdmin
{
    internal class Program
    {
        public static void DemoStudents()
        {
            Student said = new Student();
            said.Name = " Said Aziz";
            Student mieke = new Student();
            mieke.Name = "Mieke Vermeulen";
            Console.WriteLine(said.GenerateNameCard());
            Console.WriteLine(mieke.GenerateNameCard());
        }
        static void Main(string[] args)
        {
            Student said = new Student();
            said.Name = " Said Aziz";
            said.Birthdate = new DateTime(2000, 06, 01);
            said.Courses.Add("Programmeren");
            said.Courses.Add("Databanken");

            Student mieke = new Student();
            mieke.Name = "Mieke Vermeulen";
            mieke.Birthdate = new DateTime(1998, 01, 01);
            mieke.Courses.Add("Communicatie");

            int studentnumber = Student.StudentCounter;

            Console.WriteLine($"{said.Name}, geboren {said.Birthdate.ToString("d")} met studentnummer {studentnumber++}; Said volgt {said.Courses[0]} en {said.Courses[1]}");
            Console.WriteLine($"{mieke.Name}, geboren {mieke.Birthdate.ToString("d")} met studentnummer {studentnumber++}; Mieke volgt {mieke.Courses[0]}");

            Console.WriteLine("Wat wil je doen?");
            int userCoice = Convert.ToInt32(Console.ReadLine());
            switch (userCoice)
            {
                case 1:
                    DemoStudents();
                    break;

                default:
                    Console.WriteLine("Keuze is niet herkent");
                    break;
            }
        
        
        }
    }
}
