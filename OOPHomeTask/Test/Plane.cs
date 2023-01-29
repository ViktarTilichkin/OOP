using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOPHomeTask.Test
{
    public class Plane : Transport, IFly
    {
        public Plane(string name, string nameOfTransport) : base(name, nameOfTransport)
        {

        }
        public override void Move()
        {
            Console.WriteLine($" {Name} {NameOfTransport} is moving");
        }
        public void Vzlet()
        {
            Console.WriteLine($" {Name} {NameOfTransport} vzletel");
        }

        public void Posadka()
        {
            Console.WriteLine($"{Name} {NameOfTransport} sel");
        }
        public override string ToString()
        {
            return $"{Name} {NameOfTransport}";
        }
    }
}

