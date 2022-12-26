using AppTransaction.SharedModels;
using AppTransaction.Service;
using System;

public class WorkflowTransaction
{
    private Transaction[] ArrayTransaction;
    public WorkflowTransaction()
    {
        ArrayTransaction = new Transaction[30];

        ArrayTransaction[0] = new Transaction(1, 2, 3, "hi", 10, DateTime.Now.AddDays(-1));
        ArrayTransaction[1] = new Transaction(2, 1, 4, "hello", 10, DateTime.Now.AddDays(-1));
        ArrayTransaction[2] = new Transaction(3, 4, 2, "heh", 10, DateTime.Now.AddDays(-1));
        ArrayTransaction[3] = new Transaction(4, 1, 2, "lol", 10, DateTime.Now.AddDays(-1));

    }
    public void Show(User? user)
    {
        bool chek = true;
        for (int i = 0; i < ArrayTransaction.Length; i++)
        {
            if (ArrayTransaction[i] == null)
            {
                continue;
            }
            if (user?.Id == ArrayTransaction[i].UserId)
            {
                chek = false;
                Console.WriteLine(ArrayTransaction[i]);
            }
        }
        if (chek)
        {
            Console.WriteLine("нет данных по пользователю");
        }
    }
    public void SendTransaction(User? user, int idToSend, string comment, decimal value)
    {
        Transaction[] arrayTemp = new Transaction[ArrayTransaction.Length + 1];
        Array.Copy(ArrayTransaction, arrayTemp, ArrayTransaction.Length);
        arrayTemp[arrayTemp.Length - 1] = new Transaction(arrayTemp.Length, user.Id, idToSend, comment, value, DateTime.Now.AddDays(0));
        ArrayTransaction = new Transaction[arrayTemp.Length];
        Array.Copy(arrayTemp, ArrayTransaction, arrayTemp.Length);
    }
}