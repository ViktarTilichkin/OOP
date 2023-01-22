namespace Abstract.Db;

// Реализовать метод в классе Server CreateUser,
// принимающий в параметрах: имя и фамилию, почту, пароль и добавляющий в
// конец массива Db переданные данные
public class ServerDb : Db
{
    public Db[]? Users { get; set; }

    private int Id = 1;

    public ServerDb()
    {
        Users = new Db[50];
        Users[0] = new Db(Id, "test", "test", "1111");
    }
    public void CreateUser(string name, string surName, string pwd)
    {
        if (name != null && surName != null && pwd != null)
        {
            Users[Id] = new Db(++Id, name, surName, pwd);
            Console.WriteLine("succesful");
        }
        else
        {
            Console.WriteLine("input error");
        }
    }
    public void ShowUsers()
    {
        foreach (Db item in Users)
        {
            if (item != null)
            {
                Console.WriteLine(item);
            }
        }
    }
}