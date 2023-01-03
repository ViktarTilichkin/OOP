// Реализуйте класс ServerById. Обязательными методами считаются методы
// Middleware, Controller, Service, Repository. Цепочка взаимодействия между
// методами следующая:
// Controller -> (Middleware) -> Service -> Repository, где:
// Middleware – метод валидатор
// Controller – метод, принимающий данные. Принимает данные клиента
// Service – метод проверки на то что с Repository вернулось значение
// Repository – метод, симулирующая БД. Хранит массив данных. Взаимодействие с
// этим массивом осуществляется только в Repository. Массив находится в
// приложении
// Задание:
// на вход подается параметр id
// Необходимо вывести в консоль найденный элемент массива по id если таковой
// имеется. В противном случае бросить исключение. Добавить проверки 

using Myclasses.UserClass;

namespace Myclasses.ServerById;

public class ServerById
{
    private User[] Users;

    public ServerById()
    {
        Users = new User[5];
        Users[0] = new User(1, "Yesenia", 22);
        Users[1] = new User(2, "Hanna", 22);
        Users[2] = new User(3, "Stanislau", 25);
        Users[3] = new User(4, "German", 18);
        Users[4] = new User(5, "Maria", 27);
    }
    public User? Controller(int id)
    {
        if (Middleware(id))
        {
            return Service(id);
        }
        Console.WriteLine("error");
        return null;
    }
    private bool Middleware(int id)
    {
        if (id > 0)
        {
            return true;
        }
        return false;
    }
    private User? Service(int id)
    {
        User? temp = Repository(id);
        if (temp == null)
        {
            Console.WriteLine("error");
        }
        return temp;
    }
    private User? Repository(int id)
    {
        for (int i = 0; i < Users.Length; i++)
        {
            if (Users[i].Id == id)
            {
                return Users[i];
            }
        }
        return null;
    }
}
