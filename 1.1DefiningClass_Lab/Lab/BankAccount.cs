
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
            return $"Account {this._id}, balance {this._balance}";
        }
    }

