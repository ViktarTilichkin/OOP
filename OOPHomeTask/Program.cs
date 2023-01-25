using System;
using ClassData;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DbUser array = new DbUser(5);
            array.AddUser(4, "viktor", 25);
            array.Show();
            array.AddUser(2, "viktor123", 25);
            array.AddUser(3, "vikto21312r123", 25);
            array.Show();
            array.RemoveById(4);
            array.RemoveByValue("viktor123");
            Console.WriteLine(array.Search("vikto21312r123"));
            array.Show();
        }
    }
}