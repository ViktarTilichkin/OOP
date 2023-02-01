using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 1. Написать метод раширения, который преобразует тип string в тип int с проверкой строки на
// наличие только чисел


namespace TaskApplicatioLinq.Extensions
{
    public static class StringExtension
    {
        public static int ToInt(this string str)
        {
            string result = "";
            foreach (char c in str)
            {
                if (char.IsDigit(c))
                {
                    result += c;
                }
            }
            return string.IsNullOrEmpty(result) ? 0 : int.Parse(result);
        }

    }
}
