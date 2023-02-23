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

            //string text = Console.ReadLine();
            //if (!string.IsNullOrEmpty(text))
            //{
            //    text = text.Trim().ToLower();
            //    //string text2 = string.Join("", text.Reverse());
            //    //Console.WriteLine(text2);
            //    //for (int i = text.Length - 1; i > -1; i--)
            //    //{
            //    //    text2 += text[i];
            //    //}
            //    //if (text.Equals(text2))
            //    //{
            //    //    Console.WriteLine("true");
            //    //}
            //    //else
            //    //{
            //    //    Console.WriteLine("false");
            //    //}
            //    Console.WriteLine(text.Equals(string.Join("", text.Reverse())));

            //}

            //Console.Write("Введите число A: ");
            //string valueA = Console.ReadLine();
            //Console.Write("Введите число B: ");
            //string valueB = Console.ReadLine();
            //if (!int.TryParse(valueA, out int numberA) || !int.TryParse(valueB, out int numberB)) throw new Exception("input error");
            //int result = NOK(numberA, numberB);
            //Console.WriteLine(result);
            //Console.WriteLine("Summ 1000 3 || 5");
            //Console.WriteLine(Summ1000());

            // Создайте метод расширения для определения среднего значения интервала массива/коллекции чисел.
            // Пользователь должен вводить индексы начала и конца интервала для подсчёта среднего значения.
            //Console.Write("введите длину массива: ");
            //string input1 = Console.ReadLine();
            //if (!int.TryParse(input1, out int value)) throw new Exception("error");
            //int[] array = new int[value];
            //Random rnd = new Random();
            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = rnd.Next(0, 10);
            //}
            //Console.Write("введите индекс старта: ");
            //string input2 = Console.ReadLine();
            //Console.Write("введите индекс конца: ");
            //string input3 = Console.ReadLine();
            //if (!int.TryParse(input2, out int numberA) || !int.TryParse(input3, out int numberB)) throw new Exception("error");
            //double result = array.Avaredge(numberA, numberB);
            //Console.WriteLine(string.Join(", ", array));
            //Console.WriteLine(result);

            // Напишите программу, которая запрашивает у пользователя число и затем проверяет,
            // является ли оно палиндромом(то есть числом, которое читается одинаково как справа налево, так и слева направо).
            //Console.Write("введите число: ");
            //string input1 = Console.ReadLine().Trim();
            //if (!int.TryParse(input1, out _)) throw new Exception("hello");
            //////string num = input1.Trim();
            //string numRev = string.Join("", input1.Reverse());
            //Console.WriteLine(input1 == numRev);


            // совмещение массивов 
            //Console.Write("введите длину массива 1: ");
            //string input1 = Console.ReadLine();
            //if (!int.TryParse(input1, out int value)) throw new Exception("error");
            //int[] array = new int[value];
            //Random rnd = new Random();
            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = rnd.Next(0, 10);
            //}
            //Console.Write("введите длину массива 2: ");
            //string input2 = Console.ReadLine();
            //if (!int.TryParse(input2, out int value2)) throw new Exception("error");
            //int[] array2 = new int[value2];
            //for (int i = 0; i < array2.Length; i++)
            //{
            //    array2[i] = rnd.Next(0, 10);
            //}
            //Console.WriteLine(string.Join(", ", array));
            //Console.WriteLine(string.Join(", ", array2));
            //List<int> result = UniqArray(array, array2);
            //Console.WriteLine(string.Join(", ", result));

            // простое число 

            string input = Console.ReadLine();
            int.TryParse(input, out int num);
            Console.WriteLine(SimpleNum(num));
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

        // Напишите метод для нахождения наименьшего общего кратного двух чисел. Пользователь должен вводить два числа, а программа должна выводить на экран их наименьшее общее кратное.

        public static int NOK(int valueA, int valueB)
        {
            int Valuemax = valueA > valueB ? valueA : valueB;
            int count = 1;
            int resultnum = Valuemax;
            while (true)
            {
                if (resultnum % valueA == 0 && resultnum % valueB == 0)
                {
                    break;
                }
                resultnum = Valuemax * count;
                count++;
            }
            return resultnum;
        }

        // Создайте приложение для нахождения суммы всех чисел от 1 до 1000, кратных 3 или 5.

        public static int Summ1000()
        {
            int result = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0) result += i;
            }
            return result;
        }

        // Создайте метод расширения для определения среднего значения интервала массива/коллекции чисел.
        // Пользователь должен вводить индексы начала и конца интервала для подсчёта среднего значения. 
        // написана задача в convert.cs


        // Напишите функцию, которая принимает на вход два массива целых чисел и возвращает новый массив, содержащий элементы обоих массивов без повторений.

        public static List<int> UniqArray(int[] array, int[] array2)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (result.Contains(array[i])) continue;
                result.Add(array[i]);
            }
            for (int i = 0; i < array2.Length; i++)
            {
                if (result.Contains(array2[i])) continue;
                result.Add(array2[i]);
            }
            return result;
        }

        // Создайте приложение для проверки, является ли заданное число простым. Пользователь должен вводить число,
        // а программа должна выводить на экран сообщение о том, является ли оно простым.

        public static bool SimpleNum(int num)
        {
            for (int i = 2; i < num / 2; i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }
    }
}