using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHomeTask.Test
{
    internal abstract class Transport
    {
        public string Name { get; set; }
        public string NameOfTransport { get; set; }

        public Transport(string name, string nameOfTransport)
        {
            Name = name;
            NameOfTransport = nameOfTransport;
        }

        public abstract void Move();
    }
}
