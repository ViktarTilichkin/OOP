// 10. Реализуйте класс Сonversion, сдержащий метод ToDecimalNumber, преобразующий
// все числа 16 системы счисления в 10, метод ToBinaryNumber, преобразующий все
// числа 16 системы счисления в 2,

namespace Myclasses.ConversionHexaDecimal;

public class ConversionHexaDecimal
{
    public string ToDecimalNumber(int num)
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
    public string ToBinaryNumber(int num)
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
        object[] arrayConv = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, "A", "B", "C", "D", "E", "F" };
        while (num >= 1)
        {
            result += arrayConv[num % 16];
            num = num / 16;   
        }
        return new string(result.Reverse().ToArray());
    }
}