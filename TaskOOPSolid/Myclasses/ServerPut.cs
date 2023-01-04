// 6. Реализуйте класс ServerPut. Обязательными методами считаются методы
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
// на вход подается параметры id, name, age
// Необходимо найти Id клиента в массиве БД. Если совпадение есть, произвести
// обновление значений для соответствующих ключей.
// Если совпадения по Id нет – ошибка. Добавить проверки 
using Myclasses.UserClass;

namespace Myclasses.ServerPut;
public class ServerPut
{
    private User[] Users;

    public ServerPut()
    {
        Users = new User[5];
        Users[0] = new User(1, "Yesenia", 22);
        Users[1] = new User(2, "Hanna", 22);
        Users[2] = new User(3, "Stanislau", 25);
        Users[3] = new User(4, "German", 18);
        Users[4] = new User(5, "Maria", 27);
    }

    public void Controller(int id, string name, int age)
    {   
        if(Middleware(id, name,age))
        {
            Service(id, name,age);
        }
        
    }
    private bool Middleware(int id, string name, int age)
    {
        if (id > 0 && !string.IsNullOrEmpty(name) && age > 0 && age < 140)
        {
            return true;
        }
        return false;
    }
    private User? Service(int id, string name, int age)
    {
        User? temp = Repository(id, name, age);
        if (temp == null)
        {
            Console.WriteLine("error");
        }
        Console.WriteLine("change succesful");
        return temp;
    }
    private User? Repository(int id, string name, int age)
    {
        for (int i = 0; i < Users.Length; i++)
        {
            if (Users[i].Id == id)
            {
                Users[i].Name = name;
                Users[i].Age = age;
                return Users[i];
            }
        }
        return null;
    }
}