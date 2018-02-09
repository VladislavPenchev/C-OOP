
using System;
using System.Collections.Generic;

public class StartUp
{
    public static void Main()
    {
        BankAccount acc = new BankAccount();
        //Task1

        //acc.ID = 1;
        //acc.Balance = 15;

        //Console.WriteLine($"Account {acc.ID}, balance {acc.Balance}");


        //Task2

        //acc.ID = 1;
        //acc.Deposit(15);
        //acc.Withdraw(5);

        //Console.WriteLine(acc.ToString());

        //Task3
        Dictionary<int, BankAccount> account = new Dictionary<int, BankAccount>();

        bool isTrue = true;

        while (isTrue)
        {
            string command = Console.ReadLine();

            string[] cmdArgs = command.Split();

            string cmdType = cmdArgs[0];

            switch (cmdType)
            {
                case "Create":
                    Create(cmdArgs, account);
                    break;
                case "Deposit":
                    Deposit(cmdArgs, account);
                    break;
                case "Withdraw":
                    Withdraw(cmdArgs, account);
                    break;
                case "Print":
                    Print(cmdArgs, account);
                    break;
                default:
                    isTrue = false;
                    break;
            }

        }


    }


    private static void Create(string[] cmdArg, Dictionary<int, BankAccount> accounts)
    {
        int id = int.Parse(cmdArg[1]);

        if (accounts.ContainsKey(id))
        {
            Console.WriteLine("Account already exists");
        }
        else
        {
            BankAccount acc = new BankAccount();
            acc.ID = id;
            accounts.Add(id, acc);
        }
    }

    private static void Deposit(string[] cmdArg, Dictionary<int, BankAccount> accounts)
    {
        int id = int.Parse(cmdArg[1]);

        if (accounts[id].ID == 0)
        {
            Console.WriteLine("Account does not exist");
        }
        else
        {
            foreach (var acc in accounts)
            {
                if (acc.Key == id)
                {
                    acc.Value.Deposit(double.Parse(cmdArg[2]));
                }

            }
        }       
    }

    private static void Withdraw(string[] cmdArg, Dictionary<int,BankAccount> accounts)
    {
        int id = int.Parse(cmdArg[1]);

        if (accounts[id].ID == 0)
        {
            Console.WriteLine("Account does not exist");
        }
        else
        {
            foreach (var acc in accounts)
            {
                if (acc.Key == id)
                {
                    if (acc.Value.Balance < double.Parse(cmdArg[2]))
                    {
                        Console.WriteLine("Insufficient balance");
                    }
                    else
                    {
                        acc.Value.Withdraw(double.Parse(cmdArg[2]));
                    }
                    
                }
            }
        }
                
    }

    private static void Print(string[] cmdArg, Dictionary<int, BankAccount> accounts)
    {
        int id = int.Parse(cmdArg[1]);
        Console.WriteLine($"Account ID{accounts[id].ID},balance{accounts[id].Balance}");
    }
}

