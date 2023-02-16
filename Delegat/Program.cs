using Delegat;
using System;
using System.ComponentModel;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

//1.Напишите программу, в которой с помощью делегатов и анонимных методов (лямбдавыражений) создается экземпляр делегата, который вызывается без аргументов, а
//результатом возвращает текстовое значение с названием дня недели ("Понедельник",
//"Вторник" и так до "Воскресенья"). При каждом новом вызове экземпляра результатом
//возвращается название следующего дня недели. После "Воскресенья" результатом
//возвращается "Понедельник" и так далее.
//2. Напишите программу, содержащую статический метод с тремя действительными (тип
//double) аргументами.Результатом статического метода является ссылка на метод,
//вычисляющий квадратичный трехчлен с коэффициентами, определяемыми аргументами
//статического метода. Другими словами, если статический метод вызывается с числовыми
//аргументами a, b и с, то результатом является ссылка на метод, который для аргумента x
//типа double результатом вычисляет значение выражения a*x*x+b*x+c.


namespace MyApp
{
    internal class Program
    {
        public delegate void DayOfWeek();
        public delegate void Discriminant(params double[] values);
        static void Main(string[] args)
        {
            //int thisDay = 0;
            //DayOfWeek dayMessage = () =>
            //{
            //    switch (thisDay)
            //    {
            //        case 0:
            //            Console.WriteLine("Monday");
            //            break;
            //        case 1:
            //            Console.WriteLine("Tuesday");
            //            break;
            //        case 2:
            //            Console.WriteLine("Wednesday");
            //            break;
            //        case 3:
            //            Console.WriteLine("Thusday");
            //            break;
            //        case 4:
            //            Console.WriteLine("Friday");
            //            break;
            //        case 5:
            //            Console.WriteLine("Saturday");
            //            break;
            //        case 6:
            //            Console.WriteLine("Sunday");
            //            thisDay = 0;
            //            break;
            //    };
            //    thisDay++;
            //};
            //dayMessage();
            //dayMessage();
            //dayMessage();
            //dayMessage();
            //dayMessage();
            //dayMessage();
            //dayMessage();
            //dayMessage();
            //dayMessage();
            //Discriminant discrim = (double[] values) =>
            //{
            //    if (values.Length == 3)
            //    {
            //        double a = values[0];
            //        double b = values[1];
            //        double c = values[2];
            //        DiscriminantCalculate(a, b, c);
            //    }
            //};
            //discrim(5, 25, 7);
            //discrim(5);

            // дана строка
            // отсортировать слова в соответсвии с количеством гласных букв
            string text = "This wIll check over each node in the data and see if the rOwIndex is 0, when it is, it usEs the node object to sEt the selected attribute";
            string result = SortString(text);
            Console.WriteLine(result);
            result = SortStringReg(text);

        }
        public static void DiscriminantCalculate(double a, double b, double c)
        {
            double D = Math.Pow(b, 2) - 4 * a * c;
            if (D < 0) Console.WriteLine("Нет действительных корней");
            else if (D == 0)
            {
                double x = -(b / (2 * a));
                Console.WriteLine($"D = {D}, уравнение имеет один корень равный {x}");
            }
            else if (D > 1)
            {
                double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                double x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine($"D = {D}, X1 = {x1}, X2 = {x2}");
            }
        }
        public static string SortString(string text)
        {
            var array = text.Split(' ').ToList();
            string textResult = "";
            List<string> letter = new List<string> { "a", "e", "u", "i", "o", "y" };
            List<(int, string)> newList = new List<(int, string)>();
            for (int i = 0; i < array.Count; i++)
            {
                string textI = array[i];
                int length = 0;
                foreach (char item in textI)
                {
                    if (letter.Contains(item.ToString().ToLower()))
                    {
                        length++;
                    }
                }
                newList.Add((length, textI));
                length = 0;
            }
            newList.Sort((x, y) => x.Item1 - y.Item1);
            //for (int i = 0; i < newList.Count; i++)
            //{
            //    textResult += " " + newList[i];
            //}
            var title = newList.Select(text => text.Item2);
            foreach (var item in title)
            {
                textResult += " " + item;
            }
            return textResult;
        }
        public static string SortStringReg(string text)
        {
            Regex regex = new Regex(@"[^aeuoiyAEUIYO]");
            var result = text.Split(' ').ToList();
            result.Sort((x, y) => regex.Replace(x, "").Length - regex.Replace(y, "").Length);
            Console.WriteLine(string.Join(' ', result));
            return "";
        }
    }
}