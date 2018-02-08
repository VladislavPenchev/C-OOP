
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
                        Deposit(cmdArgs,account);
                        break;
                    case "Withdraw":
                        Withdraw();
                        break;
                    case "Print":
                        Print();
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

        private static void Deposit(string[] cmdArg, Dictionary<int,BankAccount> accounts)
        {
            
        }

        private static void Withdraw()
        {

        }

        private static void Print()
        {

        }
    }

