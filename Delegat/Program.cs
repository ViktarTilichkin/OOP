using Delegat;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MyApp // Note: actual namespace depends on the project name.
{
    //internal class Program
    //{
    //delegate int CalculateValues(int num1, int num2, int num3);
    //static void Main(string[] args)
    //{
    //    CalculateValues method = new InnerProgram1().Sum;
    //    Console.WriteLine(method(5, 2, 4));
    //    method = InnerProgram1.Multiplication;
    //    Console.WriteLine(method(5, 2, 4));
    //    Test testing = new Test();
    //    method = testing.Custom;
    //    Console.WriteLine(method(5, 2, 4));
    //    Console.ReadKey();
    //}
    //public class InnerProgram1
    //{
    //    public int Sum(int num1, int num2, int num3)
    //    {
    //        return num1 + num2 + num3;
    //    }
    //    public static int Multiplication(int num1, int num2, int num3)
    //    {
    //        return num1 * num2 * num3;
    //    }
    //    public int Custom(int num1, int num2, int num3)
    //    {
    //        return (num1 + num2 * num3);
    //    }
    //}

    //public delegate void CalculateValues(double x);
    //delegate void UserDecorator(ref User user);
    //static void Main(string[] args)
    //{
    //CalculateValues method = Mult2;
    //method += Mult3;
    //method += Sqr;
    //method(5);
    //Console.WriteLine("-----");
    //method -= Mult2;
    //method(5);
    //Console.WriteLine("-----");
    //method -= Mult3;
    //method(5);
    //User kek = null;
    //UserDecorator customUser = AddAge;
    //customUser += AddName;
    //customUser += AddId;
    //customUser(ref kek);
    //Console.WriteLine(kek);
    //Console.ReadKey();
    //CalculateValues method = delegate (double value)
    //{
    //    Console.WriteLine((value + value) / 3);

    //};
    //method += Mult3;
    //method += Mult2;
    //Test(method);

    //method = (double value) =>
    //{
    //    Console.WriteLine((value + value) / 3);
    //};
    //Test(method);
    //Console.ReadKey();
    //}

    //public static void Test(CalculateValues method)
    //{
    //    Console.WriteLine("введите число");
    //    double x = Convert.ToDouble(Console.ReadLine());
    //    method(x);
    //}
    //public static void CreateUser(ref User user)
    //{
    //    user = new User();
    //}
    //public static void AddId(ref User user)
    //{
    //    if (user == null) CreateUser(ref user);
    //    user.Id = 5;
    //}
    //public static void AddName(ref User user)
    //{
    //    if (user == null) CreateUser(ref user);
    //    user.Name = "cucumber";
    //}
    //public static void AddAge(ref User user)
    //{
    //    if (user == null) CreateUser(ref user);
    //    user.Age = 66;
    //}
    //public static void Mult2(double x)
    //{
    //    Console.WriteLine($"Mult2 {x * 2}");
    //}
    //public static void Mult3(double x)
    //{
    //    Console.WriteLine($"Mult3 {x * 3}");
    //}
    //public static void Sqr(double x)
    //{
    //    Console.WriteLine($"Sqr {x * x}");
    //}

    //}
    internal class Program
    {
        public delegate bool CalculateValues(bool num1);
        static void Main(string[] args)
        {

            //List<int> lsit = new List<int>();
            //lsit.Add(1);
            //lsit.Add(2);
            //lsit.Add(3);
            //lsit.Add(4);
            //lsit.Add(5);
            //lsit.Add(6);
            //lsit.Add(7);
            //Filter<int> method = delegate (int value)
            //{
            //    return value % 2 == 0;

            //};
            //List<int> newlist = lsit.FilterList(method);
            ////Console.ReadKey();
            //List<User> list = new List<User>();
            //Random rnd = new Random();
            //for (int i = 0; i < 10; i++)
            //{
            //    User user = new User();
            //    user.Id = i + 1;
            //    user.Name = $"{user.Id} + Name";
            //    user.Age = rnd.Next(10, 25);
            //    list.Add(user);
            //}
            //Filter<User> filt = (User user) => user.Id % 3 == 0;
            //List<User> newlist2 = list.FilterList(filt);
            //foreach (var item in newlist2)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadKey();
            //ICustomFile customfile = null;/*new PDFFile();*/
            ////customfile.Create("cucumber");
            ////Console.WriteLine(customfile.GetSize());
            ////customfile = new WordFile();
            ////customfile.Create("pamidor");
            ////Console.WriteLine(customfile.GetSize());
            ////customfile = new SvgFile();
            ////customfile.Create("svg");
            ////Console.WriteLine(customfile.GetSize());

            //switch (Console.ReadLine())
            //{
            //    case "1":
            //        customfile = new PDFFile();
            //        break;
            //    case "2":
            //        customfile = new WordFile();
            //        break;
            //    default:
            //        customfile = new SvgFile();
            //        break;
            //}
            //customfile.Create("pamidor");
            //Console.WriteLine(customfile.GetSize());
            //Console.ReadKey();

            ICustomFile customfile = Console.ReadLine() switch
            { 
                "1" => new PDFFile(),
                "2" => new WordFile(),
                _  => new SvgFile(),
            };
            customfile.Create("pamidor");
            Console.WriteLine(customfile.GetSize());
            Console.ReadKey();
        }
    }
}