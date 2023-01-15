// 7. Реализуйте класс ServerDelete. Обязательными методами считаются методы
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
// на вход подается параметр id
// Необходимо осуществить удаление по Id. Если совпадения нет – ошибка. Добавить
// проверки

using Myclasses.UserClass;

namespace Myclasses.ServerDelete;
public class ServerDelete
{
    private User[] Users;

    public ServerDelete()
    {
        Users = new User[5];
        Users[0] = new User(1, "Yesenia", 22);
        Users[1] = new User(2, "Hanna", 22);
        Users[2] = new User(3, "Stanislau", 25);
        Users[3] = new User(4, "German", 18);
        Users[4] = new User(5, "Maria", 27);
    }

    public void Controller(int id)
    {
        if (Middleware(id))
        {
            Console.WriteLine(Service(id));
        }

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
        Console.WriteLine("change succesful");
        return temp;
    }
    private User? Repository(int id)
    {
        for (int i = 0; i < Users.Length; i++)
        {
            if (Users[i].Id == id)
            {
                Users[i] = null;
                return Users[i];
            }
        }
        return null;
    }
}