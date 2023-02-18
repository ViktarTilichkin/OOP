using Dayli._18._02;
using System.ComponentModel;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>();
            users.Add(new User("viktor", 1, "122"));
            users.Add(new User("dima", 2, "123"));
            users.Add(new User("viktor", 3, "124"));
            users.Add(new User("dima", 4, "125"));
            users.Add(new User("stas", 5, "126"));
            users.Add(new User("dima", 6, "127"));
            users.Add(new User("neartem", 7, "128"));
            // из листа в словарь, ключь это имя , значение - кллекция пользователей содержит это имя
            Dictionary<string, List<User>> map = new Dictionary<string, List<User>>();
            for (int i = 0; i < users.Count; i++)
            {
                User user = users[i];
                //if (map.TryGetValue(user.Name, out List<User> value))
                //{
                //    value.Add(user);
                //    continue;
                //}
                //List<User> temp = new List<User>();
                //temp.Add(user);
                //map.Add(user.Name, temp);
                // ---------------
                //if (map.ContainsKey(user.Name))
                //{
                //    map[user.Name].Add(user);
                //}
                //else
                //{
                //    map.Add(user.Name, new List<User>() { user });
                //}
                // ---------------
                if (!map.TryGetValue(user.Name, out _))
                {
                    map.Add(user.Name, new List<User>());
                }
                map[user.Name].Add(user);
                // ---------------
                if (!map.TryGetValue(user.Name, out List<User> values))
                {
                    values = new List<User>();
                    map.Add(user.Name, values);
                }
                values.Add(user);
            }
            var groucollection = users.GroupBy(user => user.Name).ToDictionary(x => x.Key, x => x.ToList());
            //foreach (var key in map.Keys)
            //{
            //    string text = string.Join("; ", map[key]);
            //    Console.WriteLine($"Key: {key} | Value: {text}");
            //}

            //Task1 matrix = new Task1(5, 2);
            //matrix.InitMatrix();
            //Console.WriteLine(matrix);
            //Console.WriteLine();
            //matrix.Revers();
            //Console.WriteLine(matrix);
            int num = 125;
            Console.WriteLine(num.Convert(PositionalSystems.Bin));
            Console.WriteLine(num.Convert(PositionalSystems.Octa));
            Console.WriteLine(num.Convert(PositionalSystems.Hex));
            Console.WriteLine(num.Convert(PositionalSystems.Custom));
        }
    }
}