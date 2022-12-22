using AppTransaction.SharedModels;
using AppTransaction.Service;

namespace AppTransaction.Core;

public class ApplicationTransaction
{

    public void SignIn()
    {
        Account authorization = new Account();
        if (authorization.Login(out User? user))
        {
            WorkflowTransaction transact = new WorkflowTransaction();
            transact.Show(user);
            Console.Write("хотет сделать транзакцию? yes/no ");
            string? iwant = Console.ReadLine();
            if (iwant.Equals("yes"))
            {
                Console.Write("Введите Id получателя: ");
                int idToSend = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите коментарий: ");
                string? commet = Console.ReadLine();
                Console.Write("Введите сумму: ");
                decimal value = Convert.ToDecimal(Console.ReadLine());
                transact.SendTransaction(user, idToSend, commet, value);
                transact.Show(user);
            }

        }
    }
}