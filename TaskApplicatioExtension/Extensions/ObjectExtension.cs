using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 2. Написать метод расширения типа object, который возращает true, если можно
// преобразовать в указанный тип данных и преобразованное значение, в противном случае
// false. Метод должен называться TryToConvert()

namespace TaskApplicatioLinq.Extensions
{
    public static class ObjectExtension
    {
        public static bool TryToConvert<T>(this object obj, out T result)
        {
            if (obj is T temp)
            {
                result = temp;
                return true;
            }
            result = default;
            return false;
        }
    }
}
