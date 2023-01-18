// See https://aka.ms/new-console-template for more information
using TaskIntro.MyClasses;

namespace TaskIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Singer name = new Singer();
            // name.GetAutograph();

            // Fibonacci number = new Fibonacci(-1);
            // number.PrintFib();

            // MathCalculation num = new MathCalculation(5, 6, 8, 9, 2, -2, 52, 614, -888, -8, -9);
            // num.SumPositivenumbers();
            
            // Validator obj = new Validator();
            // Console.WriteLine(obj.IsDate("1.11.1650"));
            // Console.WriteLine(obj.IsUrl("www.tut.by"));
            // Console.WriteLine(obj.IsPhone("+375292546364"));
            WordString text = new WordString("23myName");
            Console.WriteLine(text.UpperFirst("23myName"));
            Console.WriteLine(text.ReverseString("23myName"));
        }
    }
}