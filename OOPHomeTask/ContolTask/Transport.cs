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

        public Transport(string name, int nameOfTransport)
        {
            Name = name;
            NumberOfTransport = nameOfTransport;
        }

        public abstract void Move();
    }
}
