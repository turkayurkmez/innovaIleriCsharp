using System;
using System.Collections.Generic;
using System.Linq;

namespace OperatorOverloadingAndIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "Ayna", "telefon" };
            Console.WriteLine(words[0]);
            ProductCart productCart = new ProductCart();
            var product = productCart[1];
            var another = productCart["PC"];
        }
    }


    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public int Quantity { get; set; }
    }

    public class ProductCart
    {
        private List<Product> products = new List<Product>();
        public void Add(Product product)
        {
            products.Add(product);
        }

        public Product this[int id]
        {
            get { return products.FirstOrDefault(p => p.Id == id); }
            private set { /* set the specified index to value here */ }
        }

        public Product this[string name]
        {
            get { return products.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase)); }
            private set { /* set the specified index to value here */ }
        }

    }


}
