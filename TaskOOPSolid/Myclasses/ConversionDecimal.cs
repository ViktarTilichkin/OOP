// 8. Реализуйте класс Сonversion, сдержащий метод ToBinaryNumber, преобразующий
// все числа 10 системы счисления в 2, метод ToHexadecimalNumber, преобразующий
// все числа 10 системы счисления в 16, метод ToOctalNumber, преобразующий все
// числа 10 системы счисления в 8

namespace Myclasses.ConversionDecimal;

public class ConversionDecimal
{
    public string ToBinaryNumber(int num)
    {
        string temp = "";
        while (num != 0)
        {
            if (num % 2 == 0)
            {
                temp += "0";
            }
            else
            {
                temp += "1";
            }
            num = num / 2;
        }
        return new string(temp.Reverse().ToArray());
    }
    public string ToHexadecimalNumber(int num)
    {
        string result = "";
        object[] arrayConv = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, "A", "B", "C", "D", "E", "F" };
        while (num >= 1)
        {
            result += arrayConv[num % 16];
            num = num / 16;
        }
        return new string(result.Reverse().ToArray());
    }
    public string ToOctalNumber(int num)
    {
        string result = "";
        while (num >= 1)
        {
            result += num % 8;
            num = num / 8;
        }
        return new string(result.Reverse().ToArray());
    }
}