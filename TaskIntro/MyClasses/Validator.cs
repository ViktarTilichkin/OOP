namespace TaskIntro.MyClasses
{
    public class Validator
    {
        //         Реализуйте класс Validator. У него будет метод IsEmail параметром принимает
        // строку и проверяет, является ли она корректным емейлом или нет. Если является
        // - возвращает true, если не является - то false.
        // Дополнить 5 задание. Добавить метод IsURL для проверки на url.
        // Дополнить 5 задание. Добавить метод IsDate для проверки на дату.
        // Дополнить 5 задание. Добавить метод IsPhone для проверки на номер телефона

        // private string Text = "hello Validator";

        public bool IsEmail(string text)
        {
            text.Trim();
            string[] result = text.Split("@");
            if (result.Length == 2)
            {
                string[] result1 = result[1].Split(".");
                if (result1.Length == 2 && result1[1] != string.Empty)
                {
                    return true;
                }
            }
            return false;
        }
        public bool IsUrl(string url)
        {
            url.Trim();
            string[] result = url.Split(".");
            if (result.Length == 3)
            {
                if (result[0].Equals("www"))
                {
                    return true;
                }
            }
            return false;
        }
        public bool IsDate(string date)
        {
            date.Trim();
            int coutnIndex = 0;
            string temp = "";
            string temp2 = "";
            string temp3 = "";
            for (int i = 0; i < date.Length; i++)
            {
                if (int.TryParse(date[i].ToString(), out _))
                {
                    temp += date[i];
                    coutnIndex++;
                    continue;
                }
                coutnIndex++;
                break;
            }
            for (int i = coutnIndex; i < date.Length; i++)
            {
                if (int.TryParse(date[i].ToString(), out _))
                {
                    temp2 += date[i];
                    coutnIndex++;
                    continue;
                }
                coutnIndex++;
                break;
            }
            for (int i = coutnIndex; i < date.Length; i++)
            {
                if (int.TryParse(date[i].ToString(), out _))
                {
                    temp3 += date[i];
                    coutnIndex++;
                    continue;
                }
                coutnIndex++;
                break;
            }
            int.TryParse(temp, out int num1);
            int.TryParse(temp2, out int num2);
            int.TryParse(temp3, out int num3);
            if (num2 > 0 && num2 < 13)
            {
                if ((num3 > 0 && num3 < 31) || (num1 > 0 && num1 < 31))
                {
                    return true;
                }
                return false;
            }
            return false;
        }
        public bool IsPhone(string number)
        {
            if (number.StartsWith("+375") && number.Length == 13)
            {
                return true;
            }
            return false;
        }
    }
}