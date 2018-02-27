namespace ShoppingSpree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var people = new List<Person>();
            var products = new List<Product>();

            var allPeople = Console.ReadLine().Split(new Char[] { ';' },StringSplitOptions.RemoveEmptyEntries);
            var allProducts = Console.ReadLine().Split(new Char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            try
            {
                foreach (var pair in allPeople)
                {
                    var personInfo = pair.Split('=');
                    Person person = new Person(personInfo[0], decimal.Parse(personInfo[1]));
                    people.Add(person);
                }

                foreach (var pair in allProducts)
                {
                    var productsInfo = pair.Split('=');
                    Product product = new Product(productsInfo[0], decimal.Parse(productsInfo[1]));
                    products.Add(product);
                }


                string purchase;
                while ((purchase = Console.ReadLine()) != "END")
                {
                    var purchaseInfo = purchase.Split();
                    var buyerName = purchaseInfo[0];
                    var productName = purchaseInfo[1];

                    var buyer = people.FirstOrDefault(b => b.Name == buyerName);
                    var productToBuyer = products.FirstOrDefault(pb => pb.NameOfProduct == productName);

                    try
                    {
                        buyer.BuyProduct(productToBuyer);
                        Console.WriteLine($"{buyer.Name} bought {productToBuyer.NameOfProduct}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                    foreach (var person in people)
                    {
                        var boughtProducts = person.GetAllProducts();
                        var result = boughtProducts.Any() ? string.Join(", ", boughtProducts.Select(x => x.NameOfProduct).ToList()) : "Nothing bought";
                        Console.WriteLine($"{person.Name} - {result}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
