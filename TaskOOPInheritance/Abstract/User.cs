namespace Abstract;

// 2. Реализовать абстрактный класс User. Класс содержит в себе следующие поля:
// user_id, name, surname, pwd/
// Реализовать класс, который наследуются от абстрактного класса. Назовём этот
// класс Server. Сервер принимает в конструкторе все свойства объявленные в
// абстрактном классе: user_id, name, surname, pwd. Также сервер содержит
// функцию getUser являющуюся геттером. Ваша задача при вызове функции класса
// сервер получить данные переданые в конструкторе

public abstract class User
{

    public int UserId { get; set; }
    public string Name { get; set; } = "";
    public string Surname { get; set; } = "";
    public string Pwd { get; set; } = "";

    public override string ToString()
    {
        return $"Id {UserId} Name {Name} Surname {Surname} Pass {Pwd}";
    }
}