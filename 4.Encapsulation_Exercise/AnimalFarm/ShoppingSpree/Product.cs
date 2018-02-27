using System;

namespace ShoppingSpree
{
    public class Product
    {
        private string _nameOfProduct;
        private decimal _cost;

        public Product(string nameOfProduct,decimal cost)
        {
            this.NameOfProduct = nameOfProduct;
            this.Cost = cost;
        }

        public string NameOfProduct
        {
            get
            {
                return this._nameOfProduct;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException($"{nameof(NameOfProduct)} cannot be empty");
                }
                this._nameOfProduct = value;
            }
        }

        public decimal Cost
        {
            get
            {
                return this._cost;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"{nameof(Cost)} cannot be negative");
                }
                this._cost = value;
            }
        }
    }
}
