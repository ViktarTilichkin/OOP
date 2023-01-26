using System;
using ClassData;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var array = new CustomClass<string>(5);
            array.Show();
            array.AddValue("hello");
            array.AddValue("world");
            array.AddValue("and");
            array.Show();
            array.RemoveByIndex(0);
            array.RemoveByValue("and");
            Console.WriteLine(array.SearchIndex("world"));
            array.Show();
        }
    }
}