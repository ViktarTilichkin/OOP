// 9. Реализуйте класс Сonversion, сдержащий метод ToDecimalNumber, преобразующий
// все числа 2 системы счисления в 10, метод ToHexadecimalNumber, преобразующий
// все числа 2 системы счисления в 16, метод ToOctalNumber, преобразующий все
// числа 2 системы счисления в 8

namespace Myclasses.ConversionBinary;

public class ConversionBinary
{
    public bool ToDecimalNumber(object number, out int numberResult)
    {
        string? numbers = number.ToString();
        numbers.Trim();
        bool result = true;
        string text = "";
        numberResult = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i].Equals('0'))
            {
                text += numbers[i];
            }
            else if (numbers[i].Equals('1'))
            {
                text += numbers[i];
            }
            else
            {
                result = false;
                break;
            }
        }
        if (result)
        {
            for (int j = text.Length - 1; j > -1; j--)
            {
                int num = Convert.ToInt32(text[j].ToString());
                int num2 = (int)Math.Pow(2, j + 1);
                numberResult += num * num2;
            }
        }
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