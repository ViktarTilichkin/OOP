namespace TaskIntro.MyClasses
{
    public class Singer
    {
        // Реализуйте класс Singer, который будет иметь следующие свойства: name,
        // surname. Также класс должен иметь метод GetАutograph (), который будет
        // выводить “{Name} {Surname), с наилучшими пожеланиями”.
        private string Name;
        private string Surname;
        public Singer() : this("name", "sername")
        {
        }
        public Singer(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public void GetAutograph()
        {
            Console.WriteLine($"{Name} {Surname}, с наилучшими пожеланиями");
        }
    }
}