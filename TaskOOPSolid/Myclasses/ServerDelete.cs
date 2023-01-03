
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