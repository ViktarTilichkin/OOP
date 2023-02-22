using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOOPInheritance.MyClasses
{
    public class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public Person(string name, string address, string phone)
        {
            Name = name;
            Address = address;
            Phone = phone;
        }
        public override string ToString()
        {
            return $"Name: {Name}  home address: {Address} Phone: {Phone}";
        }
    }
}
