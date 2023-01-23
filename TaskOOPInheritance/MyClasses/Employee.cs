namespace MyClasses.Employee;

// 1. Классы Employee и ProductionWorker. Напишите класс Ernployee (Сотрудник),
// который содержит атрибуты приведенных ниже данных:
// • имя сотрудника;+
// • номер сотрудника.+
// Затем напишите класс ProductionWorker (Рабочий), который является подклассом
// класса Ernployee. Класс ProductionWorker должен содержать атрибуты
// приведенных ниже данных:
// • номер смены (целое число, к примеру, 1, 2 или 3);+
// • ставка почасовой оплаты труда.+
// Рабочий день разделен на две смены: дневную и вечернюю. Атрибут смены будет
// содержать целочисленное значение, представляющее смену, в которую
// сотрудник работает. Дневная смена является сменой 1, вечерняя смена –
// сменой 2.+
// Напишите соответствующие методыполучатели и методы-модификаторы для
// каждого класса.
// После того как эти классы будут написаны, напишите программу, которая создает
// объект класса ProductionWorker и предлагает пользователю ввести данные по
// каждому атрибуту данных этого объекта. Сохраните данные в объекте и
// примените в этом объекте методы получатели, чтобы получить эти данные и
// вывести их на экран. 

public class Employee
{
    public string Name { get; set; }
    public int Id { get; set; }

    public Employee(string name, int id)
    {
        Name = name;
        Id = id;
    }
    public virtual void SetName(string name)
    {
        if (!string.IsNullOrEmpty(name))
        {
            Name = name;
            Console.WriteLine("succesful");
        }
        else
        {
            Console.WriteLine("error input");
        }
    }
    public virtual void SetId(int id)
    {
        if (id > 0)
        {
            Id = id;
            Console.WriteLine("succesful");
        }
        else
        {
            Console.WriteLine("error input");
        }
    }

    public override string ToString()
    {
        return $" Id : {Id} Name: {Name}";
    }
}