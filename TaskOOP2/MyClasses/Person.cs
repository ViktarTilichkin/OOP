// Создать класс Person, который содержит:
// Свойства FullName, Age;+
// методы Move() и Talk(), в которых просто вывести на консоль
// сообщение -"Такой-то {Person} говорит".+
// Добавьте два конструктора - Person() и Person(fullName, age).
// Создайте два объекта этого класса. Один объект
// инициализируется конструктором Person(), другой -
// Person(fullName, age).
namespace TaskOOP2.MyClasses;

public class Person
{
    public string FullName { get; set; } = "O kurva";
    public string Age { get; set; } = "18";

    public Person()
    {

    }
    public Person(string name, string age)
    {
        FullName = name;
        Age = age;
    }
    public void Move()
    {
        Console.WriteLine($"{FullName} go");
    }
    public void Talk()
    {
        Console.WriteLine($"{FullName} say");
    }
    public override string ToString()
    {
        return string.Join(", ", FullName, Age);
    }
}