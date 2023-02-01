using System;
using TaskApplicatioLinq.Extensions;
using TaskApplicatioLinq.Enums;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string test = "555asdasd554";
            // Console.WriteLine(test.ToInt());
            object test = "5";
            Console.WriteLine(test.TryToConvert(out string result));
            Console.WriteLine(result);
            Console.WriteLine(FileTypes.pdf.FileTypeMessage());
        }
    }
}