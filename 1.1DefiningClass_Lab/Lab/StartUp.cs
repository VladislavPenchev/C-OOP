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

        string input = string.Empty;

        while ((input = Console.ReadLine()) != "End")
        {
            var cmdArgs = input.Split();

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
        double amount = double.Parse(cmdArg[2]);

        if (accounts.ContainsKey(id))
        {
            accounts[id].Deposit(amount);
        }
        else
        {
            Console.WriteLine("Account does not exist");
        }

             
    }

    private static void Withdraw(string[] cmdArg, Dictionary<int,BankAccount> accounts)
    {
        int id = int.Parse(cmdArg[1]);
        double amount = double.Parse(cmdArg[2]);

        if (accounts.ContainsKey(id))
        {
            if (accounts[id].Balance < amount)
            {
                Console.WriteLine("Insufficient balance");
            }
            else
            {
                accounts[id].Withdraw(amount);
            }
        }
        else
        {
            Console.WriteLine("Account does not exist");
        }
        
                
    }

    private static void Print(string[] cmdArg, Dictionary<int, BankAccount> accounts)
    {
        int id = int.Parse(cmdArg[1]);


        if (accounts.ContainsKey(id))
        {
            Console.WriteLine(accounts[id].ToString());
        }
        else
        {
            Console.WriteLine("Account does not exist");
        }
        
    }
}

