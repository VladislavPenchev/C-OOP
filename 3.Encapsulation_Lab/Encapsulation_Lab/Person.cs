namespace Encapsulation_Lab
{
    using System;

    public class Person
    {
        private string _firstName;
        private string _lastName;
        private int _age;
        private double _salary;

        public Person(string firstName,string lastName, int age, double salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }

        public string FirstName
        {
            get
            {                
                return this._firstName;
            }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException($"{nameof(this.FirstName)} cannot be less than 3 symbols");
                }
                this._firstName = value;
            }
        }

        public string LastName
        {
            get
            {                
                return this._lastName;
            }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Last name cannot be less than 3 symbols");
                }
                this._lastName = value;
            }
        }

        public int Age
        {
            get
            {               
                return this._age;
            }
            set
            {
                if (value == 0 || value < 0)
                {
                    throw new ArgumentException("Age must not be zero or negative");
                }

                this._age = value;
            }
        }

        public double Salary
        {
            get
            {               
                return this._salary;
            }
            set
            {
                if (value < 460)
                {
                    throw new ArgumentException("Salary can't be less than 460.0");
                }

                this._salary = value;
            }
        }

        public void IncreaseSalary(double bonus)
        {
            if (this.Age < 30)
            {
                this._salary += this._salary*((bonus/2) / 100);
            }
            else
            {

                this._salary += this._salary * ((bonus) / 100);
            }
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this._lastName} get {this._salary} leva";
        }

    }
}
