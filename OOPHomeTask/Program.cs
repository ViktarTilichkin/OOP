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
            array.RemoveById(4);
            array.Show();
        }
    }
}