using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dayli._18._02
{
    public static class ConvertException
    {
        private readonly static Dictionary<PositionalSystems, object[]> m_liberyDec = new Dictionary<PositionalSystems, object[]>
            {
                { PositionalSystems.Bin, new object[] { 0, 1 } },
                { PositionalSystems.Octa, new object[] { 0, 1, 2, 3, 4, 5, 6, 7 } },
                { PositionalSystems.Hex, new object[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, "A", "B", "C", "D", "E", "F" } },
                { PositionalSystems.Custom, new object[] { "A", "Э", "У", "Ъ", "Й", "Э" } }
            };
        public static string Convert(this int number, PositionalSystems systems)
        {
            if (!m_liberyDec.TryGetValue(systems, out object[] numbers))
            {
                throw new Exception("нет такой системы счисления");
            }
            List<object> result = new List<object>();
            int baseSystem = numbers.Length;
            while (number > 0)
            {
                result.Add(numbers[number % baseSystem]);
                number /= baseSystem;
            }
            result.Reverse();
            return string.Join("", result);

        }
    }
}
