using DayliApp.Modules;
using System;
using System.Text.Json;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Money dollar = new Money()
            {
                Code = 177,
                Name = "dollar",
                Symbol = "$",
                LastUpdate = DateTime.Now
            };

            Money byn = new Money()
            { Code = 667 };
            byn.Name = "Belarusian ruble";
            byn.Symbol = "Br";
            

            Console.WriteLine(dollar);
            Console.WriteLine(byn);
            Console.WriteLine("----JsonSerializer.Serialize----");
            string jsondollar = JsonSerializer.Serialize(dollar);
            Console.WriteLine(jsondollar);
            string jsonbyn = JsonSerializer.Serialize(byn);
            Console.WriteLine(jsonbyn);
            Console.WriteLine("----JsonSerializer.Serialize----");
            Money newDollar = JsonSerializer.Deserialize<Money>(jsondollar);
            Console.WriteLine(newDollar);
            Money newByn = JsonSerializer.Deserialize<Money>(jsonbyn);
            Console.WriteLine(newByn);
            Console.WriteLine("----Custome----");
            var serializeoptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            };
            string json = "{\"name\":\"dollar\",\"symbol\":\"$\"}";
            try
            {
                Money test = JsonSerializer.Deserialize<Money>(json, serializeoptions);
                Console.WriteLine(test);    
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex);
            }
            List<Money> money = new List<Money>();
            money.Add(dollar);
            money.Add(byn);
            string testSerialize = JsonSerializer.Serialize(money);
            Console.WriteLine(testSerialize);
            var moneytest = JsonSerializer.Deserialize<List<Money>>(testSerialize);
            //moneytest.ForEach(itemInmoney => Console.WriteLine(itemInmoney));
            for(int i = 0; i < money.Count; i++) 
            {
                Console.WriteLine(moneytest[i]);
            }
        }   
    }
}