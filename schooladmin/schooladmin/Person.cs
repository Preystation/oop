using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin
{
    internal abstract class Person
    {
        private uint id;
        private string name;
        private DateTime birthdate;
        private int age;
        private static List<Person> allPersons = new List<Person>();
        private static uint nexId = 1;
        public uint Id
        {
            get
            {
                return id;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public DateTime Birthdate
        {
            get
            {
                return birthdate;
            }
        }
        public int Age
        {
            get
            {
                int age = DateTime.Now.Year - Birthdate.Year;
                return age;
            }
        }
        public static ImmutableList<Person> AllPersons
        {
            get
            {
                return AllPersons.ToImmutableList<Person>();
            }
        }
        public Person(string name,DateTime birthdate)
        {
            id = nexId++;
            this.Name = name;
            this.birthdate = birthdate;
            AllPersons.Add(this);

        }
        public abstract double DetermineWorkLoad();
        public abstract string GenerateNameCard();
    }
}
