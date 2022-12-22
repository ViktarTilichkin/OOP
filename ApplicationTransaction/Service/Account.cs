using AppTransaction.SharedModels;

namespace AppTransaction.Service;

public class Account
{
    private User[] Users;
    private int NextIdUsers = 1;

    public Account()
    {
        Users = new User[20];
        Users[0] = new User(NextIdUsers++, "Viktor", "viktor@mail.ru", "hello");
        Users[1] = new User(NextIdUsers++, "Dima", "dima@mail.ru", "hello");
        Users[2] = new User(NextIdUsers++, "Artem", "artem@mail.ru", "hello");
        Users[3] = new User(NextIdUsers++, "Luba", "luba@mail.ru", "hello");

    }
    public bool Login(out User? user)
    {
        Console.Write("Enter email ");
        string? email = Console.ReadLine();
        Console.Write("Enter pass ");
        string? pass = Console.ReadLine();
        user = Search(email, pass);
        return user != null;
    }
    private User? Search(string? email, string? pass)
    {
        if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(pass))
        {
            Console.WriteLine("error input");
            return null;
        }
        foreach (User user in Users)
        {
            if (user == null)
            {
                continue;
            }
            if (user.Email == email && user.Password == pass)
            {
                Console.WriteLine("Successful login ");
                return user;
            }
        }
        Console.WriteLine("error input");
        return null;
    }
    public bool RegistrAcc(out User? user)
    {
        Console.WriteLine("Enter email");
        string? email = Console.ReadLine();
        Console.WriteLine("Enter name");
        string? name = Console.ReadLine();
        Console.WriteLine("Enter password");
        string? pass = Console.ReadLine();
        user = SearchSimple(name, email, pass);
        if (user != null)
        {
            Users[user.Id - 1] = user;
        }
        return user != null;

    }
    private User? SearchSimple(string? name, string? email, string? pass)
    {
        if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(pass) || string.IsNullOrEmpty(name))
        {
            System.Console.WriteLine("error input");
            return null;
        }
        // for (int i = 0; i < Users.Length; i++)
        // {
        //     if (Users[i].Email == email)
        //     {
        //         System.Console.WriteLine("This email not available");
        //         return null;
        //     }
        // }
        return new User(NextIdUsers++, name, pass, email);

    }
}