using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHomeTask.Test
{
    internal class Ship : Transport, ISwim
    {
        public Ship(string name, string nameOfTransport) : base(name, nameOfTransport)
        {

        }
        public override void Move()
        {
            Console.WriteLine($"{Name} {NameOfTransport} is moving");
        }
        public void Otpliv()
        {
            Console.WriteLine($"{Name} {NameOfTransport} uplil");
        }

        public void Pripliv()
        {
            Console.WriteLine($"{Name} {NameOfTransport} priplil");
        }
    }
}
