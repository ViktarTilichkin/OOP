using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHomeTask.ControlTask
{
    public class Bus : Transport, IDrive
    {
        public Bus(string name, int numberOfTransport, int countSeats) : base(name, numberOfTransport, countSeats)
        {

        }
        public override void Move()
        {
            Console.WriteLine($" {Name} {NumberOfTransport} is moving");
        }
        public void Otehal()
        {
            Console.WriteLine($" {Name} {NumberOfTransport} otehal");
        }

        public void Priehal()
        {
            Console.WriteLine($"{Name} {NumberOfTransport} Priehal");
        }
        public override string ToString()
        {
            return $"{Name} {NumberOfTransport}";
        }
    }
}
