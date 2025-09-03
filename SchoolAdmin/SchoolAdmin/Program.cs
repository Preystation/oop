namespace SchoolAdmin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Student s2 = new Student();
            s1.Name = "Said Aziz";
            s2.Name = " Mieke Vermeulen";
            s1.Courses.Add("Programmeren ");
            s1.Courses.Add("Databanken ");
            s2.Courses.Add("Communicatie ");
            s1.Birthdate = new DateTime(2000, 06, 01);
            s2.Birthdate = new DateTime(1998, 01, 01);
            s1.StudentCounter++;
            s2.StudentCounter++;
            Console.WriteLine($"Said: {s1.Name}, geboren {s1.Birthdate.ToString("d")} met studentennummber {s1.StudentCounter}; Said volgt {s1.Courses[0]} en {s1.Courses[1]} ");
            Console.WriteLine($"Mieke: {s2.Name}, geboren {s2.Birthdate.ToString("d")} met studentennummber {s2.StudentCounter}; Said volgt {s2.Courses[0]}");

        }
    }
}
