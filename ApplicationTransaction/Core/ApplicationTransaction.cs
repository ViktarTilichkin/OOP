using AppTransaction.SharedModels;
using AppTransaction.Service;

namespace AppTransaction.Core;

public class ApplicationTransaction
{
    public (bool, User?) SignIn(IAuthorization authorization)
    {
        if (authorization.Login(out User? user))
        {
            return (true, user);
        }
        return (false, null);
    }
    public void SendTransaction(User? user, WorkflowTransaction transaction)
    {
        Console.Write("Введите Id получателя: ");
        int idToSend = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите коментарий: ");
        string? commet = Console.ReadLine();
        Console.Write("Введите сумму: ");
        decimal value = Convert.ToDecimal(Console.ReadLine());
        transaction.SendTransaction(user, idToSend, commet, value);
    }
}