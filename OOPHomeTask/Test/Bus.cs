using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHomeTask.Test
{
    public class Bus : Transport, IDrive
    {
        public Bus(string name, string nameOfTransport) : base(name, nameOfTransport)
        {

        }
        public override void Move()
        {
            Console.WriteLine($" {Name} {NameOfTransport} is moving");
        }
        public void Otehal()
        {
            Console.WriteLine($" {Name} {NameOfTransport} otehal");
        }

        public void Priehal()
        {
            Console.WriteLine($"{Name} {NameOfTransport} Priehal");
        }
        public override string ToString()
        {
            return $"{Name} {NameOfTransport}";
        }
    }
}
