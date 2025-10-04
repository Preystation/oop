using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schooladmin
{
    internal class StudyProgram
    {
        private string name;
        public string Name{ get { return name; } }
       private List<Course> courses = new List<Course>();
        public List<Course> Courses
        {
            get
            {
                return courses;
            }
            set
            {
                courses = value;
            }
        }
        public StudyProgram(string name)
        {

        }
        public void ShowOverview()
        {
            Console.WriteLine($"{name}");
            foreach( Course item in Courses)
            {
                Console.WriteLine($"{item.Title}");
            }
        }
        public static void DemostudyProgram()
        {
            Course communicatie = new Course("Communicatie");
            Course programmeren = new Course("Programmeren");
            Course databanken = new Course("Databanken");
            List<Course> courses = new List<Course>() { communicatie, programmeren, databanken };
            StudyProgram programmerenProgram = new StudyProgram("Programmeren");
            StudyProgram snbProgram = new StudyProgram("Systeem- en netwerkbeheer");
            programmerenProgram.Courses = courses;
            snbProgram.Courses = courses;
            //we willen hieronder Databanken schrappen uit het programma SNB
            snbProgram.Courses.Remove(databanken);
            programmerenProgram.ShowOverview();
            snbProgram.ShowOverview();
        }
    }
}
