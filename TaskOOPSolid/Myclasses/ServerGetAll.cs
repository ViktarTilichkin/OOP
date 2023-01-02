// Реализуйте класс ServerGetAll. Обязательными методами считаются методы
// Controller, Service, Repository. Цепочка взаимодействия между методами
// следующая:
// Controller -> Service -> Repository, где:
// Controller – метод, принимающий данные. Принимает данные клиента
// Service – метод проверки на то что с Repository вернулось значение
// Repository – метод, симулирующая БД. Хранит массив данных. Взаимодействие с
// этим массивом осуществляется только в Repository. Массив находится в
// приложении
// Задание:
// Необходимо вывести в консоль весь массив
using Myclasses.User;

namespace Myclasses.ServerGetAll;

public class ServerGetAll
{
    private User[] Users;

    public ServerGetAll()
    {
        Users = new User[4];
        Users[0] = new User(1, "Yesenia", 22);
        Users[1] = new User(2, "Hanna", 22);
        Users[2] = new User(3, "Stanislau", 25);
        Users[3] = new User(4, "German", 18);
        Users[4] = new User(5, "Maria", 27);

    }
    public User[]? Controller()
    {
        return Service();
    }

    private User[]? Service()
    {
        User[] temp = Repository();
        if (temp == null)
        {
            Console.WriteLine("error");
        }
        return temp;
    }
    private User[] Repository()
    {
        return Users;
    }
}