namespace schooladmin
{
    internal class Program
    {
        static void Main(string[] args)
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
            

            Console.WriteLine($"said {said.Name} geboren {said.Birthday.ToString("d")} met studentnummer {Student.StudentCounter++}; Said volgt {said.Courses[0]} en {said.Courses[1]}");
            Console.WriteLine($"mieke {mieke.Name} geboren {mieke.Birthday.ToString("d")} met studentnummer {Student.StudentCounter++}; Mieke volgt {mieke.Courses[0]}");
        }

    }
}
