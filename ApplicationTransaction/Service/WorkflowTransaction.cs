using AppTransaction.SharedModels;
using AppTransaction.Service;
using System;

public class WorkflowTransaction
{
    private Transaction[] ArrayTransaction;
    public WorkflowTransaction()
    {
        ArrayTransaction = new Transaction[4]
        {
            new Transaction(1, 002, 003,"hi" , 10, DateTime.Now.AddDays(-1) ),
            new Transaction(2, 001,004, "hello" , 10, DateTime.Now.AddDays(-1)),
            new Transaction(3, 004, 002,"heh" , 10, DateTime.Now.AddDays(-1)),
            new Transaction(4, 001,002, "lol" , 10, DateTime.Now.AddDays(-1)),
        };
    }
    public void Show(User user)
    {
        bool chek = true;
        for (int i = 0; i < ArrayTransaction.Length; i++)
        {
            if (user.Id == ArrayTransaction[i].UserId)
            {
                chek = false;
                Console.WriteLine(ArrayTransaction[i]);
            }
        }
        if (chek)
        {
            Console.WriteLine("не данных по пользователю");
        }
    }
    public void SendTransaction(User user, int idToSend, string comment, decimal value)
    {
        Transaction[] arrayTemp = new Transaction[ArrayTransaction.Length + 1];
        Array.Copy(ArrayTransaction, arrayTemp, ArrayTransaction.Length);
        arrayTemp[arrayTemp.Length - 1] = new Transaction(arrayTemp.Length, user.Id, idToSend, comment, value, DateTime.Now.AddDays(0));
        ArrayTransaction = new Transaction[arrayTemp.Length];
        Array.Copy(arrayTemp, ArrayTransaction, arrayTemp.Length);
    }
}