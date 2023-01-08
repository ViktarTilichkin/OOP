using MyClasses.Car;
using MyClasses.Transport;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Transport obj = new Transport(20, "BIGCAR");
            // obj.Moving();
            // obj.Stopping();
            Car obj1 = new Car("brichka", 66);
            // obj1.Moving();
            // obj1.Stopping();
            // obj1.Drift();
            Car obj2 = new Car("kek", 22);
            Transport[] array = new Transport[3] {obj, obj2, obj1};
            
            foreach(Transport item in array)
            {
                if (item is Car car)
                {
                    Console.WriteLine("this is car");
                    car.Drift();
                }
                if (item is Transport)
                {
                    Console.WriteLine("this is transport");
                }
                item.Moving();
                item.Stopping();
            }
        }
    }
}