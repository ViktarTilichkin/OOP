namespace TaskIntro.MyClasses
{
    public class WordString
    {
        // Реализуйте класс WordString, который будет иметь следующие методы: метод
        // ReverseString(), переворачивающий строку, метод UpperFirst(), возвращающий
        // строку, где первая буква заглавная и метод UpperEvery(), который делает
        // заглавной первую букву каждого слова этой строки.
        private string Text;
        public WordString()
        {
            Text = "Hello, World!";
        }
        public WordString(string text)
        {
            Text = text;
        }
        public string ReverseString(string text)
        {
            string result = "";
            for (int i = text.Length - 1; i >= 0; i--)
            {
                result += text[i];
            }
            return result;
        }
        public string UpperFirst(string text)
        {
            string result = "";
            bool firstLetter = true;
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsLetter(text[i]) && firstLetter)
                {
                    result += char.ToUpper(text[i]);
                    firstLetter = false;
                }
                else
                {
                    result += text[i];
                }
            }
            return result;
        }
        public string UpperEvery(string text)
        {
            string result = "";
            bool firstLetter = true;
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsLetter(text[i]) && firstLetter)
                {
                    result += char.ToUpper(text[i]);
                    firstLetter = false;
                }
                else if (!char.IsLetter(text[i]))
                {

                    result += text[i];
                    firstLetter = true;

                }
                else
                {
                    result += text[i];
                }
            }
            return result;
        }
    }
}