using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHomeTask.ControlTask
{
    public abstract class Transport
    {
        public string Name { get; set; }
        public int NumberOfTransport { get; set; }
        public int CountSeats { get; set; }

        public Transport(string name, int numberOfTransport, int countSeats)
        {
            Name = name;
            NumberOfTransport = numberOfTransport;
            CountSeats = countSeats;
        }

        public abstract void Move();
    }
}
