using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

// 6. Написать метод расширения сложения для List<int> четных элементов.

// 8. Написать метод расширения подсчёта количества вхождений элемента в коллекции List

//9. * Написать метод расширения для бинарной сортировки коллекции List<T>

//10. *Написать метод расширения добавления элемента в позицию в соответствии с
//сортировкой в коллекцию List<T>

namespace TaskApplicatioExtension.Extensions
{
    public static class ListExtension
    {
        public static int SumEvenElemets(this List<int> list)
        {
            if (list.Count == 0) return 0;
            int sum = 0;
            for (int i = 0; i < list.Count; i += 2)
            {
                sum += list[i];
            }
            return sum;
        }
        public static int CountEntryElement<T>(this List<T> list, T value)
        {
            int count = 0;
            foreach (var item in list)
            {
                if (item.Equals(value))
                {
                    count++;
                }
            }
            return count;
        }
        public static List<T> BinarySort<T>(this List<T> list)
        {
            if (list.Count == 0) return null;
            for (int i = 0; i < list.Count - 1; i++)
            {
                // доедлать бинарную сорьтировку массив делитсья на два и сортируеться относительно центра. затем опять на два и опять 

            }
            return null;
        }
    }
}
