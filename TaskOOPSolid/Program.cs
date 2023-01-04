
using ValidatorEmail;
using Myclasses.ServerGetAll;
using Myclasses.ServerById;
using Myclasses.ServerPost;
using Myclasses.ServerPut;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServerGetAll obj = new ServerGetAll();
            Console.WriteLine(string.Join(" \n ", obj.Controller().ToList()));
            // foreach (var item in obj.Controller())
            // {
            //     Console.WriteLine(item);
            // }
            ServerById obj1 = new ServerById();
            Console.WriteLine(obj1.Controller(2));
            ServerPost obj2 = new ServerPost();
            obj2.Controller("halle", 32);
            ServerPut obj3 = new ServerPut();
            obj3.Controller(2, "antoni",22);
        }
    }
}