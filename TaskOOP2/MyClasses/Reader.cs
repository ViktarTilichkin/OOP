// Определить класс Reader, хранящий такую информацию о+
// пользователе библиотеки:+
// ФИО,+
// номер читательского билета,+
// факультет,+
// дата рождения,+
// телефон.+
// Методы TakeBook(), ReturnBook().
// Cоздается массив объектов данного класса.
// Перегрузить методы TakeBook (), ReturnBook ():
// - TakeBook, который будет принимать количество взятых книг.
// Выводит на консоль сообщение "XXX взял Y книги".
// - TakeBook, который будет принимать переменное количество
// названий книг. Выводит на консоль сообщение "XXX взял книги:
// BooK1, BooK2, BooK3".
// - TakeBook, который будет принимать переменное количество
// объектов класса Book (создать новый класс, содержащий имя и
// автора книги). Выводит на консоль сообщение " XXX взял книги:
// BooK1, BooK2, BooK3".
// Аналогичным образом перегрузить метод ReturnBook (). Выводит
// на консоль сообщение "XXX вернул книги: BooK1, BooK2, BooK3".
// Или " XXX вернул Y книги".

namespace TaskOOP2.MyClasses;

public class Reader
{
    public string Name { get; set; } = "name";
    public int NumberCard { get; set; } = 0000;
    public string Facultet { get; set; } = "Grifendor";
    public string BirdhDay { get; set; } = "DD/MM/YYYY";
    public string NumPhone { get; set; } = "+375-YY-XXX-XX-XX";
    public Reader()
    {

    }
    public Reader(string name)
    {
        Name = name;
    }

    public void TakeBook(int countBook)
    {
        Console.WriteLine($"{Name} взял книг: {countBook} шт.");
    }
    public void ReturnBook(int countBook)
    {
        Console.WriteLine($"{Name} вернул книг: {countBook} шт.");
    }
    public override string ToString()
    {   
        return string.Join(", ", Name, Facultet);
    }
}