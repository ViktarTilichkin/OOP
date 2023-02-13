using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegat
{
    internal class WordFile : ICustomFile
    {
        public byte[] data;
        public void Create(string name)
        {
            data = new byte[name.Length];
            string path = "C:/Main/user/" + name + ".docs";
            Console.WriteLine($"docs файл создан, путь {path}");
            Random rnd = new Random();
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = (byte)rnd.Next(0, 255);
            }
        }

        public double GetSize()
        {
            return data.Sum(x => x) / 8.0;
        }
    }
}
