using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static MyApp.Program;
//Написать метод обобщения, которыйм производит фильтрацию данных. В качестве
//входных параметров коллекция (List) данных обобщенного типа и делигат, по котолрому
//будет производиться фильтрация данных.
namespace Delegat
{
    public delegate bool Filter<T>(T item);
    public static class ListExtension
    {

        public static List<T> FilterList<T>(this List<T> data, Filter<T> method)
        {
            List<T> list = new List<T>();
            for (int i = 0; i < data.Count; i++)
            {
                if (method(data[i]))
                {
                    list.Add(data[i]);
                }
            }
            return list;
        }
    }
}
