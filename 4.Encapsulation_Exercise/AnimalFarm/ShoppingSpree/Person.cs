namespace ShoppingSpree
{
    using System;
    using System.Collections.Generic;

    public class Person
    {
        private string _name;
        private decimal _money;
        private List<Product> bag;
                
        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            bag = new List<Product>();
        }
        public string Name {
            get
            {
                return this._name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException($"{nameof(Name)} cannot be empty");
                }

                this._name = value;
            }
        }

        public decimal Money {
            get
            {
                return this._money;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"{nameof(Money)} cannot be negative");
                }
                this._money = value;
            }
        }

        public void BuyProduct(Product product)
        {
            if (this.Money < product.Cost)
            {
                throw new InvalidOperationException($"{this.Name} can't afford {product.NameOfProduct}");
            }

            bag.Add(product);
            this.Money -= product.Cost;
        }

        public IList<Product> GetAllProducts()
        {
            return this.bag.AsReadOnly();
        }
                
    }
}
