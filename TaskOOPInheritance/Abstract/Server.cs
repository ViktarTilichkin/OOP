namespace Abstract;

// 2. Реализовать абстрактный класс User. Класс содержит в себе следующие поля:
// user_id, name, surname, pwd/
// Реализовать класс, который наследуются от абстрактного класса. Назовём этот
// класс Server. Сервер принимает в конструкторе все свойства объявленные в
// абстрактном классе: user_id, name, surname, pwd. Также сервер содержит
// функцию getUser являющуюся геттером. Ваша задача при вызове функции класса
// сервер получить данные переданые в конструкторе

public class Server : User
{
    public Server(int id, string name, string surName, string pwd)
    {
        UserId = id;
        Name = name;
        Surname = surName;
        Pwd = pwd;
    }
    public User GetUser()
    {
        return this;
    }
}