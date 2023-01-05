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
        string result = (string)temp.ToCharArray().Reverse();
        return result;
    }
    public string ToHexadecimalNumber(int num)
    {
        string result = "";
        return result;
    }
    public int ToOctalNumber(int num)
    {
        int result = num;
        return result;
    }
}