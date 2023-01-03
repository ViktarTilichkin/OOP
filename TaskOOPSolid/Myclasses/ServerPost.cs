// Реализуйте класс ServerPost. Обязательными методами считаются методы
// Middleware, Controller, Service, Repository. Цепочка взаимодействия между методами
// следующая:
// Controller -> (Middleware) -> Service -> Repository, где:
// Middleware – метод валидатор
// Controller – метод, принимающий данные. Принимает данные клиента
// Service – метод проверки на то что с Repository вернулось значение
// Repository – метод, симулирующая БД. Хранит массив данных. Взаимодействие с
// этим массивом осуществляется только в Repository. Массив находится в
// приложении
// Задание:
// на вход подается параметры name, age
// Необходимо добавить в массив БД объект только в том случае, если нет совпадений
// по name. Если совпадения нет, то в объект клиента добавить ключ Id с последним
// возможным уникальным Id БД, таким образом, чтобы в БД был запушен объект вида
// {“Id": 6, Name : "Test", Age : 1}
// Если совпадение есть – ошибка. Добавить проверки 

using Myclasses.UserClass;

namespace Myclasses.ServerPost;
public class ServerPost
{
    private User[] Users;

    public ServerPost()
    {
        Users = new User[5];
        Users[0] = new User(1, "Yesenia", 22);
        Users[1] = new User(2, "Hanna", 22);
        Users[2] = new User(3, "Stanislau", 25);
        Users[3] = new User(4, "German", 18);
        Users[4] = new User(5, "Maria", 27);
    }

    public User Controller()
    {

    }
    private bool Middleware()
    {

    }
    private User Service()
    {

    }
    private User Repository()
    {

    }
}