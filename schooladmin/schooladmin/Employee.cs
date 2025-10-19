using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin
{
    internal abstract class Employee:Person
    {
        public byte Seniority;
        public ImmutableDictionary<string, byte> Tasks
        {
            get
            {
                return tasks.ToImmutableDictionary<string, byte>();
            }
        }

        private Dictionary<string, byte> tasks = new Dictionary<string, byte>();
        private List<Employee> allEmployees = new List<Employee>();
        public ImmutableList<Employee> AllEmployees
        {
            get
            {
                return allEmployees.ToImmutableList<Employee>();
            }
        }
        public Employee(string name, DateTime birthDate, Dictionary<string, byte> tasks) : base(name, birthDate)
        {
            if(tasks is not null)
            {
                foreach(var item in tasks)
                {
                    tasks.Add(item.Key, item.Value);
                }
            }
            allEmployees.Add(this);
        }
        public abstract uint CalculateSalary();
    }
}
