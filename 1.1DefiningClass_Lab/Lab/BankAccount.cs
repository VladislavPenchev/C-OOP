
using System;

public class BankAccount
    {
        private int _id;

        private double _balance;

        public BankAccount()
        {
            this._id = ID;
            this._balance = Balance;
        }

        public int ID
        {
            get
            {
                return this._id;
            }

            set
            {
                this._id = value;
            }
        }

        public double Balance
        {
            get
            {
                return this._balance;
            }

            set
            {
            if (this._balance + value < 0)
            {
                throw new ArgumentException("Balance can not be negative");
            }
                this._balance = value;
            }
        }

    

        public void Deposit(double amount)
        {
            this._balance += amount;
        }

        public void Withdraw(double amount)
        {
            this._balance -= amount;
        }

        public override string ToString()
        {
            return $"Account ID{this._id}, balance {this._balance:F2}";
        }
    }

