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
        public bool IsUrl()
        {

        }
        public bool IsDate()
        {

        }
        public bool IsPhone()
        {

        }
    }
}