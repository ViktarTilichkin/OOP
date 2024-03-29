﻿// See https://aka.ms/new-console-template for more information

using AppTransaction.Core;
using AppTransaction.SharedModels;
using AppTransaction.Service;


namespace AppTransaction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationTransaction obj1 = new ApplicationTransaction();
            Account users = new Account();
            WorkflowTransaction transaction = new WorkflowTransaction();
            bool autorizationIn = false;
            User? user = null;
            while (true)
            {
                Console.WriteLine("Список доступных меню:");
                Console.WriteLine("1 Регистраация");
                Console.WriteLine("2 Авторизация");
                Console.WriteLine("0 Выход из программы");
                Console.WriteLine("Введите номер меню");
                string? menu = Console.ReadLine();
                if (menu.Equals("1"))
                {
                    while (true)
                    {
                        Console.WriteLine("Меню регистраци");
                        Console.WriteLine("1 регистрация");
                        Console.WriteLine("0 Выход");
                        string? menu1 = Console.ReadLine();
                        if (menu1.Equals("1"))
                        {
                            users.RegistrAcc(out User? user11);
                        }
                        else if (menu1.Equals("0"))
                        {
                            break;
                        }
                    }
                }
                else if (menu.Equals("2"))
                {
                    while (true)
                    {
                        Console.WriteLine("Меню авторизации");
                        if (autorizationIn)
                        {
                            Console.WriteLine("Вы авторизованы");
                        }
                        Console.WriteLine("1 Авторизация");
                        Console.WriteLine("2 Отправка тразакции");
                        Console.WriteLine("3 Просмотр своих транзакций");
                        Console.WriteLine("4 выход из аккаунта");
                        Console.WriteLine("0 Выход");
                        Console.WriteLine("Введите номер меню");
                        string? menu2 = Console.ReadLine();
                        if (menu2.Equals("1"))
                        {
                            Console.WriteLine("Меню авторизации");
                            (autorizationIn, user) = obj1.SignIn(users);
                        }
                        else if (menu2.Equals("2") && autorizationIn)
                        {
                            obj1.SendTransaction(user, transaction);
                        }
                        else if (menu2.Equals("3") && autorizationIn)
                        {
                            transaction.Show(user);
                        }
                        else if (menu2.Equals("4"))
                        {
                            Console.WriteLine("выход из аккаунта");
                            autorizationIn = false;
                            user = null;
                        }
                        else if (menu2.Equals("0"))
                        {
                            break;
                        }
                    }
                }
                else if (menu.Equals("0"))
                {
                    break;
                }
            }

        }
    }
}
