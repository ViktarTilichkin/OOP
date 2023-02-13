using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegat
{
    internal class PDFFile : ICustomFile
    {
        private string path;
        public void Create(string name)
        {
            path = "C:/User/Main/" + name + ".pdf";
            Console.WriteLine($"Пдф файл создан, путь {path}");
        }

        public double GetSize()
        {
            Random rnd = new Random();
            double size = rnd.Next(1, 1000000);
            return size / path.Length;
        }
    }
}
