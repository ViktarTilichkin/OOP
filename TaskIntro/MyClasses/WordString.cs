namespace TaskIntro.MyClasses
{
    public class WordString
    {
        //         Реализуйте класс WordString, который будет иметь следующие методы: метод
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
        // public string ReverseString()
        // {
        //     return;
        // }
        // public string UpperFirst()
        // {
        //     return;
        // }
        // public string UpperEvery()
        // {
        //     return;
        // }
    }
}