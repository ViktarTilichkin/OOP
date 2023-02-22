using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOOPInheritance.MyClasses
{
    public class Worker
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public Worker(string name, string lastName)
        {
            Name = name;
            LastName = lastName;
        }
        public void GetFullName()
        {
            Console.WriteLine($"{Name} {LastName}");
        }
    }
}
