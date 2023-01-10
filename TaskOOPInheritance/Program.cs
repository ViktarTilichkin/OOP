using MyClasses.Car;
using MyClasses.Transport;
using Figurs;
using Incapsulation;

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
            Tiles plitka = new Tiles("Krasivoe" , 0.5, 0.5 , 25);
            Console.WriteLine(plitka.GetData());
            Console.WriteLine(plitka.GetCountTiles(44.2));
        }
    }
}