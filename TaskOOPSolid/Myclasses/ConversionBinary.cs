// 9. Реализуйте класс Сonversion, сдержащий метод ToDecimalNumber, преобразующий
// все числа 2 системы счисления в 10, метод ToHexadecimalNumber, преобразующий
// все числа 2 системы счисления в 16, метод ToOctalNumber, преобразующий все
// числа 2 системы счисления в 8

namespace Myclasses.ConversionBinary;

public class ConversionBinary
{
    public bool ToDecimalNumber(string numbers, out int numberResult)
    {
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
            text = new string(text.Reverse().ToArray());
            for (int j = 0; j < text.Length; j++)
            {
                int num = Convert.ToInt32(text[j].ToString());
                int num2 = (int)Math.Pow(2, j);
                numberResult += num * num2;
            }
        }
        return result;
    }
    public string ToHexadecimalNumber(string num)
    {
        ToDecimalNumber(num, out int number);
        string result = "";
        object[] arrayConv = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, "A", "B", "C", "D", "E", "F" };
        while (number >= 1)
        {
            result += arrayConv[number % 16];
            number = number / 16;
        }
        return new string(result.Reverse().ToArray());
    }
    public string ToOctalNumber(string num)
    {
        ToDecimalNumber(num, out int number);
        string result = "";
        while (number >= 1)
        {
            result += number % 8;
            number = number / 8;
        }
        return new string(result.Reverse().ToArray());
    }
}