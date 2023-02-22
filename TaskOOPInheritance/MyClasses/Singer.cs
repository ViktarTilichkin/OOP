using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOOPInheritance.MyClasses
{
    public class Singer : Worker
    {
        public int Years { get; set; }
        public string Birth { get; set; }
        public string Style { get; set; }
        public Singer(string name, string lastName, int years, string birth, string style) : base(name, lastName)
        {
            Years = years;
            Birth = birth;
            Style = style;
        }
        public void GetMoreInfo()
        {
            Console.WriteLine($"{Name} {Years} {Birth} {Style}");
        }
    }
}
