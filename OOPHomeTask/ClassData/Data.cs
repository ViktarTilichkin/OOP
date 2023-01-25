namespace ClassData;
// Задача
// Написать обобщенный класс (без ограничений)
// поле Items массив 
// метод добавления
// метод поиск индеса по значению
// удаления значения (по индексу, удаление по занчению)
// метод вывода

public class DbUser
{
    public User[] ArrayUsers;

    public int Id = 1;

    public DbUser(int arrayLength)
    {
        ArrayUsers = new User[arrayLength];
        for (int i = 0; i < arrayLength; i++)
        {
            ArrayUsers[i] = new User(Id++);
        }
    }
    public bool AddUser(int id, string name, int age)
    {
        ArrayUsers[id - 1].Name = name;
        ArrayUsers[id - 1].Age = age;
        return true;
    }
    public bool RemoveById(int id)
    {
        ArrayUsers[id - 1].Name = "dafault";
        ArrayUsers[id - 1].Age = 0;
        return true;
    }
    public bool RemoveByValue()
    {
        return true;
    }

    public void Show()
    {
        foreach (User item in ArrayUsers)
        {
            Console.WriteLine(item);
        }
    }

}