using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegat
{
    internal class SvgFile : ICustomFile
    {
        public void Create(string name)
        {
            string path = "C:/Main/user/" + name + ".svg";
            Console.WriteLine($"Svg файл создан, путь {path}");
        }

        public double GetSize()
        {
            return DateTime.Now.Ticks / new Random().Next(1, 100);
        }
    }
}
