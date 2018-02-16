namespace _06.CompanyRoster_RecoveryEdition
{
    public class Employee
    {
        private string _name;
        private decimal _salary;
        private string _position;
        private string _department;
        private string _email;
        private int _age;

        public Employee(string name, decimal salary, string position, string department)
        {
            this._name = name;
            this._salary = salary;
            this._position = position;
            this._department = department;
            this._email = "n/a";
            this._age = -1;
        }

        public string Email { set { this._email = value; } }

        public int Age { set { this._age = value; } }

        public string Department { get { return this._department; } }

        public decimal Salary { get { return this._salary; } }

    }
}
