using MyClasses.Car;
using MyClasses.Transport;
using Figurs;
using Incapsulation;
using PaymentSystems;
using Abstract.Db;
using Abstract;
using MyClasses.ProductionWorker;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // Transport obj = new Transport(20, "BIGCAR");
            // obj.Moving();
            // obj.Stopping();
            // Car obj1 = new Car("brichka", 66);
            // obj1.Moving();
            // obj1.Stopping();
            // obj1.Drift();
            // Car obj2 = new Car("kek", 22);
            // Transport[] array = new Transport[3] {obj, obj2, obj1};

            // foreach(Transport item in array)
            // {
            //     if (item is Car car)
            //     {
            //         Console.WriteLine("this is car");
            //         car.Drift();
            //     }
            //     if (item is Transport)
            //     {
            //         Console.WriteLine("this is transport");
            //     }
            //     item.Moving();
            //     item.Stopping();
            // }
            // Figur figura = new Figur("null");
            // figura.Square();
            // Figur rectangle = new Rectangle("pr9mougolnik", 5, 10);
            // rectangle.Square();
            // Triangle treugolnik = new Triangle("treugolnik", 5, 5, 5);
            // treugolnik.Square();
            // Circle mixail = new Circle("mixail", 10);
            // mixail.Square();
            // Figur[] arrayFigur = new Figur[3]
            // {
            //     new Rectangle("pr9mougolnik", 6, 10),
            //     new Triangle("treugolnik", 6, 6, 6),
            //     new Circle("mixail", 15)
            // };
            // int index = 0;
            // while(index != arrayFigur.Length)
            // {
            //     arrayFigur[index].Square();
            //     Console.WriteLine(arrayFigur[index]);
            //     index ++;
            // }
            // Tiles plitka = new Tiles("Krasivoe", 0.5, 0.5, 25);
            // Console.WriteLine(plitka.GetData());
            // Console.WriteLine(plitka.GetCountTiles(44.2));
            // Children van9 = new Children();
            // Console.WriteLine(van9.GetChildren());
            // van9.SetChildren("Van9", "Ivanov", 9);
            // Console.WriteLine(van9.GetChildren());
            // Matrix mat1 = new Matrix(2, 5);
            // mat1.SetData();
            // mat1.ReverseData();
            // Counter cn = new Counter(99);
            // cn.Incriment();
            // Console.WriteLine(cn);
            // cn.Incriment();
            // Console.WriteLine(cn);
            // cn.Incriment();
            // Console.WriteLine(cn);
            // PaymentTerminal terminal = new PaymentTerminal("terminal");
            // Visa dima = new Visa("001", 1);
            // terminal.SetMoneyByPaymentSystem(10, dima);
            // dima.SetMoney(100);
            // terminal.SetMoneyByPaymentSystem(10, dima);
            // Console.WriteLine(dima);
            // Console.WriteLine();
            // Console.WriteLine(dima.GetHistory());
            // Console.WriteLine();
            // Console.WriteLine(terminal);
            // Console.WriteLine();
            // UnionPay artem = new UnionPay("002", 1);
            // artem.SetMoney(15000);
            // terminal.SetMoneyByPaymentSystem(15000, artem);
            // terminal.SetMoneyByPaymentSystem(10000, artem);
            // Console.WriteLine(artem);
            // Console.WriteLine();
            // Console.WriteLine(artem.GetHistory());
            // Console.WriteLine();
            // Console.WriteLine(terminal);
            // Server new1 = new Server(1, "Viktor" , "Nameee" , "1A234");
            // Console.WriteLine(new1.GetUser());
            // Data new2 = new Data();
            // Console.WriteLine(new2.IsValidEmail("a@ba@ma.com"));
            // Console.WriteLine(new2.IsValidPwd("aaAA11"));
            // ServerDb array = new ServerDb();
            // array.CreateUser("name" , "SurName" , "2222");
            // array.CreateUser("name1" , "SurName2" , "3333");
            // array.ShowUsers();
            ProductionWorker name = new ProductionWorker(2, 10, "viktor", 1);
            Console.WriteLine(name);
        }
    }
}
