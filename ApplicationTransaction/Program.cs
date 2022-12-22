// See https://aka.ms/new-console-template for more information

using AppTransaction.Core;


namespace AppTransaction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // bool exit = false;
            // do
            // {
            //     ApplicationTransaction obj1 = new ApplicationTransaction();
            //     obj1.SignIn();
            //     Console.Write("хотите продолжить ? yes/no ");
            //     string? exite = Console.ReadLine();
            //     if (exite.Equals("yes"))
            //     {
            //         exit = true;
            //     }
            //     else
            //     {
            //         exit = false;
            //     }
            // }
            // while (exit);
            while (true)
            {
                ApplicationTransaction obj1 = new ApplicationTransaction();
                obj1.SignIn();
                Console.Write("хотите продолжить ? yes/no ");
                string? exite = Console.ReadLine();
                if (exite.Equals("no"))
                {
                    break;
                }
            }

        }
    }
}

// while (true)
// {
//     Меню уровень 
//     1.методы регистрация
//     2.метод авторизация
//      2.1 метод пуша транзакции
//      2.2 просмотра транзакций
//      2.3 выход из акаунта 
//     3. выход из программы.
// }