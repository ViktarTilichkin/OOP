// Определить класс Children, который содержит такие поля (члены класса):
// закрытые – имя ребенка, фамилию и возраст , публичные – методы ввода данных
// и отображения их на экран. Объявить два объекта класса, внести данные и
// показать их.

namespace Incapsulation;

public class Children
{
    private string FirstName = "defaultFirstName";
    private string LastName = "defaultLasname";
    private int Age = 0;

    public void SetChildren(string firstname, string lastname, int age)
    {
        FirstName = firstname;
        LastName = lastname;
        Age = age;
    }
    public string GetChildren()
    {
        return $"Name: {FirstName} {LastName} Age: {Age}";
    }
}   