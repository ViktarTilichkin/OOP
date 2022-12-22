using AppTransaction.SharedModels;
using AppTransaction.Service;

namespace AppTransaction.Core;

public class ApplicationTransaction
{

    WorkflowTransaction transact;

    public void ActivationBD()
    {
        transact = new WorkflowTransaction();
    }

    public (bool, User) SignIn()
    {
        Account authorization = new Account();
        if (authorization.Login(out User? user))
        {
            return (true, user);
        }
        return (false, user);
    }
    public void SendTransaction(User? user)
    {
        Console.Write("Введите Id получателя: ");
        int idToSend = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите коментарий: ");
        string? commet = Console.ReadLine();
        Console.Write("Введите сумму: ");
        decimal value = Convert.ToDecimal(Console.ReadLine());
        transact.SendTransaction(user, idToSend, commet, value);
    }

}

//    public (bool, User) SignIn()
//     {
//         Account authorization = new Account();
//         if (authorization.Login(out User? user))
//         {
//             return (true, user);
//             transact.Show(user);
//             Console.Write("хотет сделать транзакцию? yes/no ");
//             string? iwant = Console.ReadLine();
//             if (iwant.Equals("yes"))
//             {
//                 Console.Write("Введите Id получателя: ");
//                 int idToSend = Convert.ToInt32(Console.ReadLine());
//                 Console.Write("Введите коментарий: ");
//                 string? commet = Console.ReadLine();
//                 Console.Write("Введите сумму: ");
//                 decimal value = Convert.ToDecimal(Console.ReadLine());
//                 transact.SendTransaction(user, idToSend, commet, value);
//                 transact.Show(user);
//             }

//         }
//         return (false, user);
//     }