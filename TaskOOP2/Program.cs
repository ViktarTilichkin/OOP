// See https://aka.ms/new-console-template for more information

using TaskOOP2.MyClasses;

namespace TaskOOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Phone phone1 = new Phone();
            // Phone phone2 = new Phone();
            // phone2.Number = "+375-29-111-11-11";
            // phone2.Model = "Samsung";
            // phone2.Weight = "1000";
            // Phone phone3 = new Phone()
            // {
            //     Model = "Iphone",
            //     Weight = "100",
            //     Number = "+375-29-777-77-77"
            // };

 
            Phone phone1 = new Phone();
            Console.WriteLine(phone1);
            phone1.ReceiveCall("LoL");
            Console.WriteLine(phone1.GetNumber());
            Console.WriteLine();

            Phone phone2 = new Phone("+375-29-111-11-11", "Samsung");
            Console.WriteLine(phone2);
            phone2.ReceiveCall("Kek");
            Console.WriteLine(phone2.GetNumber());
            Console.WriteLine();

            Phone phone3 = new Phone(model: "Iphone", weight: "100", number: "+375-29-777-77-77");
            Console.WriteLine(phone3);
            phone3.ReceiveCall("Cucumber Rick", "+375-29-FFF-FF-FF");
            Console.WriteLine(phone3.GetNumber());
            Console.WriteLine();
            Phone.SendMessage("hello", "+375-29-27-77-77", "+375-29-77277-77", "+375-29-7733377-77");

            Person andersen = new Person();
            andersen.Talk();
            Person bill = new Person("Bill" , "101");
            bill.Move();
            Console.WriteLine(andersen);
            Console.WriteLine(bill);

            Matrix matrix = new Matrix(4,5);
            matrix.InitMatrix();
            matrix.Print();
            Console.WriteLine();
            Matrix matrix1 = new Matrix(4,5);
            matrix1.InitMatrix();
            matrix.SummMatrix(matrix1);
            matrix.MiltMatrix(matrix1);
            matrix.MatrixMultNum(10);

            Reader[] readers = new Reader[5];
            for (int i = 0; i < readers.Length; i++)
            {
                readers[i] = new Reader() { Name = "readers" + i }; // readers[i].Name = "readers" + i;
                Console.WriteLine(readers[i]);
                Random rnd = new Random();
                readers[i].TakeBook(rnd.Next(0,10));
            }


        }
    }
}

