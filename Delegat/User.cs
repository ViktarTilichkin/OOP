using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegat
{
    public class User
    {
        public int Id { get; set; } = default;
        public string Name { get; set; } = "default";
        public int Age { get; set; }  = default;
        public override string ToString()
        {
            return $"{Id} {Name} {Age}";
        }

    }
}
