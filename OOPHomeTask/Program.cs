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
            var array = new CustomClass<string>(5);
            array.Show();
            array.AddValue("hello");
            array.AddValue("world");
            array.AddValue("and");
            array.Show();
            array.RemoveByIndex(0);
            array.RemoveByValue("and");
            Console.WriteLine(array.SearchIndex("world"));
            array.Show();
            List<int> array = new List<int>(20);
            System.Console.WriteLine($"Capacity={array.Capacity} countItem={array.Count}");
            array.Add(1);
            System.Console.WriteLine($"Capacity={array.Capacity} countItem={array.Count}");
            array.Add(1);
            array.Add(11);
            array.Add(1123);
            array.Add(41);
            array.Add(16);
            System.Console.WriteLine($"Capacity={array.Capacity} countItem={array.Count}");
            array.Add(1333);
            array.Add(1);
            array.Add(112);
            array.Add(98);
            array.Add(123);
            array.Add(112);
            array.Add(1231);
            array.Add(8);
            array.Add(6);
            array.Add(13);
            array.Add(163);
            array.Add(5);
            array.Add(67);
            array.Add(9);
            array.Add(78);
            System.Console.WriteLine($"Capacity={array.Capacity} countItem={array.Count}");
            Console.WriteLine(array.FirstOrDefault(x => x > 1));
            Console.WriteLine(array.FindIndex(x => x > 4));
            for (int i = 0; i < array.Count; i++)
            {
                if (array[i] == 5)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine(string.Join("; ", array));
            array.Sort();
            Console.WriteLine(string.Join("; ", array));
            Console.WriteLine("firstordefault");
            Func<int, bool> serchItem = x => x > 22;
            int result2 = array.FirstOrDefault(serchItem);
            int result = array.FirstOrDefault(item => item > 10);
            Console.WriteLine($"firstordefault {result}");
            Func<int, int, int> ourDel = (x, y) => x + y;
            Console.WriteLine(ourDel(1, 2));
            Console.WriteLine("Hello");

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