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
    private int Id = 1;

    public ServerPost()
    {
        Users = new User[20];
        Users[0] = new User(Id, "Yesenia", 22);
        Users[1] = new User(Id++, "Hanna", 22);
        Users[2] = new User(Id++, "Stanislau", 25);
        Users[3] = new User(Id++, "German", 18);
        Users[4] = new User(Id++, "Maria", 27);
    }

    public void Controller(string name, int age)
    {
        if (Middleware(name, age))
        {
            Console.WriteLine("User add successful");
        }
        else
        {
            Console.WriteLine("User not add");
        }
    }
    private bool Middleware(string name, int age)
    {
        if (!string.IsNullOrEmpty(name) && age > 0)
        {
            return true;
        }
        return false;
    }
    private User? Service(string name, int age)
    {
        User? temp = Repository(name, age);
        if (temp == null)
        {
            Console.WriteLine("error");
            return temp;
        }
        return temp;


    }
    private User? Repository(string name, int age)
    {
        for (int i = 0; i < Users.Length; i++)
        {
            if (Users[i].Name.ToLower() == name.ToLower())
            {
                return null;
            }

        }

        return Users[Id - 1] = new User(Id, name, age);
    }
}