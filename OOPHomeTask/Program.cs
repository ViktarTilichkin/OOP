using System;
using System.Collections.Generic;
using ClassData;
using OOPHomeTask.ControlTask;

//1.Проработать все методы и свойства (с учётом LINQ) коллекции List.В качестве
//типов объектов коллекции можно использовать любой класс из предыдущих
//занятий.
//2. Проработать все методы и свойства (с учётом LINQ) коллекции LinkedList.В
//качестве типов объектов коллекции можно использовать любой класс из
//предыдущих занятий.
//3. Проработать все методы и свойства (с учётом LINQ) коллекции Stack.В качестве
//типов объектов коллекции можно использовать любой класс из предыдущих
//занятий.
//4. Проработать все методы и свойства (с учётом LINQ) коллекции Dictionary.В
//качестве ключей использовать int, в качестве значений объектов коллекции
//можно использовать любой класс из предыдущих занятий.
//5. Заменить массивы во всех задачах предыдущих занятий на List или LinkedList

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var array = new CustomClass<string>(5);
            //array.Show();
            //array.AddValue("hello");
            //array.AddValue("world");
            //array.AddValue("and");
            //array.Show();
            //array.RemoveByIndex(0);
            //array.RemoveByValue("and");
            //Console.WriteLine(array.SearchIndex("world"));
            //array.Show();
            //List<int> arrayS = new List<int>(20);
            //Console.WriteLine(arrayS.FirstOrDefault(x => x > 1));
            //Console.WriteLine(arrayS.FindIndex(x => x > 4));
            //for (int i = 0; i < arrayS.Count; i++)
            //{
            //    if (arrayS[i] == 5)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine(string.Join("; ", array));
            //arrayS.Sort();
            //Console.WriteLine(string.Join("; ", array));
            //Console.WriteLine("firstordefault");
            //Func<int, bool> serchItem = x => x > 22;
            //int result2 = arrayS.FirstOrDefault(serchItem);
            //int result = arrayS.FirstOrDefault(item => item > 10);
            //Console.WriteLine($"firstordefault {result}");
            //Func<int, int, int> ourDel = (x, y) => x + y;
            //Console.WriteLine(ourDel(1, 2));
            //Console.WriteLine("Hello");

            //List<int> list = new List<int>();
            //Random random = new Random();
            //for(int i = 0; i <20; i++)
            //{
            //    list.Add(i);
            //}
            //LinkedList<int> linkedlist = new LinkedList<int>();
            //for (int i = 0; i < 20; i++)
            //{
            //    linkedlist.AddLast(i);
            //}
            //Stack<int> stack = new Stack<int>();
            //for (int i = 0; i < 20; i++)
            //{
            //    stack.Push(i);
            //}
            //Dictionary<int,string> dictionary = new Dictionary<int,string>();
            //for (int i = 0; i < 20; i++)
            //{
            //    int value = random.Next(0, 500);
            //    string text = $"Hello {i} element";
            //    dictionary.Add(i,text);
            //}
            //foreach(int item in list)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();
            //foreach (int item in linkedlist)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();
            //foreach (int item in stack)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();
            //foreach (var item in dictionary)
            //{
            //    Console.WriteLine(item);
            //}


            TransportSystemCity minsk = new TransportSystemCity();
            Plane aeroflot = new Plane("vesna", 777, 25);
            Bus avtobus = new Bus("Икарус", 91, 10);
            Ship lodka = new Ship("Теплоход Заря", 5, 10);
            minsk.SetInAirport(aeroflot);
            minsk.SetInBusStation(avtobus);
            minsk.SetInPort(lodka);
            Console.WriteLine("----BuyPlaneTicket---");
            Console.WriteLine(minsk.BuyPlaneTicket(777, 20));
            Console.WriteLine("----BuyBusTicket-----");
            Console.WriteLine(minsk.BuyBusTicket(91, 15));
            Console.WriteLine("----BuyShipTicket----");
            Console.WriteLine(minsk.BuyShipTicket(8, 10));














        }
    }
}

//Список методов расширения LINQ
//• Select - определяет проекцию выбранных значений
//• Where - определяет фильтр выборки
//• OrderBy - упорядочивает элементы по возрастанию
//• OrderByDescending - упорядочивает элементы по убыванию
//• ThenBy - задает дополнительные критерии для упорядочивания элементов возрастанию
//• ThenByDescending - задает дополнительные критерии для упорядочивания элементов по
//  убыванию
//• Join - соединяет две коллекции по определенному признаку
//• Aggregate - применяет к элементам последовательности агрегатную функцию, которая
//  сводит их к одному объекту
//• GroupBy - группирует элементы по ключу
//• ToLookup - группирует элементы по ключу, при этом все элементы добавляются в словарь
//• GroupJoin - выполняет одновременно соединение коллекций и группировку элементов по
//  ключу
//• Reverse - располагает элементы в обратном порядке
//• All - определяет, все ли элементы коллекции удовлятворяют определенному условию
//• Any - определяет, удовлетворяет хотя бы один элемент коллекции определенному условию
//• Contains - определяет, содержит ли коллекция определенный элемент
//• Distinct - удаляет дублирующиеся элементы из коллекции
//• Except - возвращает разность двух коллекцию, то есть те элементы, которые создаются только
//в одной коллекции
//• Union - объединяет две однородные коллекции
//  Intersect - возвращает пересечение двух коллекций, то есть те элементы, которые встречаются
//  в обоих коллекциях
//• Count - подсчитывает количество элементов коллекции, которые удовлетворяют
//  определенному условию
//• Sum - подсчитывает сумму числовых значений в коллекции
//• Average - подсчитывает cреднее значение числовых значений в коллекции
//• Min - находит минимальное значение
//• Max - находит максимальное значение
//• Take - выбирает определенное количество элементов
//• Skip - пропускает определенное количество элементов
//• Concat - объединяет две коллекции
//• TakeWhile - возвращает цепочку элементов последовательности, до тех пор, пока условие
//  истинно
//• SkipWhile - пропускает элементы в последовательности, пока они удовлетворяют заданному
//  условию, и затем возвращает оставшиеся элементы
//• Zip - объединяет две коллекции в соответствии с определенным условием
//• First - выбирает первый элемент коллекции
//• FirstOrDefault - выбирает первый элемент коллекции или возвращает значение по
//  умолчанию
//• Single - выбирает единственный элемент коллекции, если коллекция содержит больше или
//  меньше одного элемента, то генерируется исключение
//• ElementAt - выбирает элемент последовательности по определенному индексу
//  SingleOrDefault - выбирает единственный элемент коллекции. Если коллекция пуста,
//  возвращает значение по умолчанию. Если в коллекции больше одного элемента, генерирует
//  исключение
//• ElementAt - выбирает элемент последовательности по определенному индексу
//• ElementAtOrDefault - выбирает элемент коллекции по определенному индексу или
//  возвращает значение по умолчанию, если индекс вне допустимого диапазона
//• Last - выбирает последний элемент коллекции
//• LastOrDefault - выбирает последний элемент коллекции или возвращает значение по
//  умолчанию