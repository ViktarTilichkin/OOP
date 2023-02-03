using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOPHomeTask.ControlTask
{
    public class Plane : Transport, IFly
    {
        public Plane(string name, int nameOfTransport) : base(name, nameOfTransport)
        {

        }
        public override void Move()
        {
            Console.WriteLine($" {Name} {NumberOfTransport} is moving");
        }
        public void Vzlet()
        {
            Console.WriteLine($" {Name} {NumberOfTransport} vzletel");
        }

        public void Posadka()
        {
            Console.WriteLine($"{Name} {NumberOfTransport} sel");
        }
        public override string ToString()
        {
            return $"{Name} {NumberOfTransport}";
        }
    }
}

