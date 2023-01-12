
using ValidatorEmail;
using Myclasses.ServerGetAll;
using Myclasses.ServerById;
using Myclasses.ServerPost;
using Myclasses.ServerPut;
using Myclasses.ServerDelete;
using Myclasses.Sort;
using Myclasses.ConversionDecimal;
using Myclasses.ConversionBinary;
using Myclasses.ConversionHexaDecimal;

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
            ServerDelete obj4 = new ServerDelete();
            obj4.Controller(3);
            int[] num = {5,4,7,3,8,2};
            Console.WriteLine(string.Join(", " , num));
            Sort obj5 = new Sort();
            obj5.SortData(out int[] result, num);
            Console.WriteLine(string.Join(", ", result));
            ConversionDecimal obj6 = new ConversionDecimal();
            Console.WriteLine(obj6.ToBinaryNumber(395));
            Console.WriteLine(obj6.ToHexadecimalNumber(395));
            Console.WriteLine(obj6.ToOctalNumber(395));
            ConversionBinary obj7 = new ConversionBinary();
            obj7.ToDecimalNumber("1010" , out int res);
            Console.WriteLine(res);
            Console.WriteLine(obj7.ToHexadecimalNumber("1010"));
            Console.WriteLine(obj7.ToOctalNumber("1010"));
            ConversionHexaDecimal obj8 = new ConversionHexaDecimal();
            Console.WriteLine(obj8.ToDecimalNumber("A"));
            Console.WriteLine(obj8.ToBinaryNumber("A"));
            Console.WriteLine(obj8.ToOctalNumber("A"));
        }
    }
}