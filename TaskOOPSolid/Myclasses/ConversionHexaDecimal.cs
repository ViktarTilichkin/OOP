// 10. Реализуйте класс Сonversion, сдержащий метод ToDecimalNumber, преобразующий
// все числа 16 системы счисления в 10, метод ToBinaryNumber, преобразующий все
// числа 16 системы счисления в 2,

namespace Myclasses.ConversionHexaDecimal;

public class ConversionHexaDecimal
{
    public string ToDecimalNumber(string num)
    {
        num = new string(num.Reverse().ToArray());
        string[] text = new string[num.Length];
        int numberResult = 0;
        object[] arrayConv = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, "A", "B", "C", "D", "E", "F" };
        for (int i = 0; i < num.Length; i++)
        {
            for (int j = 0; j < arrayConv.Length; j++)
            {
                if (num[i].ToString() == arrayConv[j].ToString())
                {
                    text[i] += j;
                }
            }
        }
        for (int j = 0; j < text.Length; j++)
        {
            int numtemp = Convert.ToInt32(text[j].ToString());
            int num2 = (int)Math.Pow(16, j);
            numberResult += numtemp * num2;
        }
        return numberResult.ToString();
    }
    public string ToBinaryNumber(string number)
    {
        int num = Convert.ToInt32(ToDecimalNumber(number));
        string result = "";
        object[] arrayConv = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, "A", "B", "C", "D", "E", "F" };
        while (num >= 1)
        {
            result += arrayConv[num % 2];
            num = num / 2;
        }
        return new string(result.Reverse().ToArray());
    }
    public string ToOctalNumber(string number)
    {
        int num = Convert.ToInt32(ToDecimalNumber(number));
        string result = "";
        object[] arrayConv = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, "A", "B", "C", "D", "E", "F" };
        while (num >= 1)
        {
            result += arrayConv[num % 8];
            num = num / 8;
        }
        return new string(result.Reverse().ToArray());
    }
}