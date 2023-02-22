using Dayli._18._02;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<User> users = new List<User>();
            //users.Add(new User("viktor", 1, "122"));
            //users.Add(new User("dima", 2, "123"));
            //users.Add(new User("viktor", 3, "124"));
            //users.Add(new User("dima", 4, "125"));
            //users.Add(new User("stas", 5, "126"));
            //users.Add(new User("dima", 6, "127"));
            //users.Add(new User("neartem", 7, "128"));
            //// из листа в словарь, ключь это имя , значение - кллекция пользователей содержит это имя
            //Dictionary<string, List<User>> map = new Dictionary<string, List<User>>();
            //for (int i = 0; i < users.Count; i++)
            //{
            //    User user = users[i];

            //    if (!map.TryGetValue(user.Name, out _))
            //    {
            //        map.Add(user.Name, new List<User>());
            //    }
            //    map[user.Name].Add(user);
            //    // ---------------
            //    if (!map.TryGetValue(user.Name, out List<User> values))
            //    {
            //        values = new List<User>();
            //        map.Add(user.Name, values);
            //    }
            //    values.Add(user);
            //}
            //var groucollection = users.GroupBy(user => user.Name).ToDictionary(x => x.Key, x => x.ToList());
            //int num = 125;
            //Console.WriteLine(num.Convert(PositionalSystems.Bin));
            //Console.WriteLine(num.Convert(PositionalSystems.Octa));
            //Console.WriteLine(num.Convert(PositionalSystems.Hex));
            //Console.WriteLine(num.Convert(PositionalSystems.Custom));
            // Напишите программу, которая находит сумму всех элементов массива целых чисел.
            //List<double> list = new List<double>();
            //Random rnd = new Random();
            //for (int i = 0; i < 10; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        list.Add((rnd.Next(1, 50) / rnd.Next(1, 180)));
            //    }
            //    list.Add(rnd.Next(1, 50));
            //}
            //List<int> list = new List<int>();
            //Random rnd = new Random();
            //for (int i = 0; i < 10; i++)
            //{
            //    list.Add(rnd.Next(-100, -1));
            //}
            //Console.WriteLine(string.Join(", ", list));
            //int result = 0;
            //for (int i = 0; i < list.Count; i++)
            //{
            //    result += list[i];
            //}
            //Console.WriteLine(result);
            // Напишите программу, которая находит наибольший и наименьший элементы массива целых чисел.
            //(int?, int?) value = MinMaxValue(list);
            //Console.WriteLine(value.Item1);
            //Console.WriteLine(value.Item2);



            // Напишите программу, которая считывает строку с консоли и определяет, является ли она палиндромом(т.е.читается одинаково слева направо и справа налево).

            string text = Console.ReadLine();
            if (!string.IsNullOrEmpty(text))
            {
                text = text.Trim().ToLower();
                //string text2 = string.Join("", text.Reverse());
                //Console.WriteLine(text2);
                //for (int i = text.Length - 1; i > -1; i--)
                //{
                //    text2 += text[i];
                //}
                //if (text.Equals(text2))
                //{
                //    Console.WriteLine("true");
                //}
                //else
                //{
                //    Console.WriteLine("false");
                //}
                Console.WriteLine(text.Equals(string.Join("", text.Reverse())));

            }
        }
        public static (int?, int?) MinMaxValue(List<int> list)
        {
            try
            {
                int minValue = list[0];
                int maxValue = list[0];
                for (int i = 1; i < list.Count; i++)
                {
                    if (minValue > list[i]) minValue = list[i];
                    if (maxValue < list[i]) maxValue = list[i];
                }
                return (minValue, maxValue);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return (null, null);
            }

        }
    }
}