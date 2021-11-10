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
            productCart.Add(new Product { Id = 1, Name = "Turbo Sakız", Price = 5, Quantity = 100 });
            productCart.Add(new Product { Id = 2, Name = "Big Babol", Price = 3, Quantity = 150 });
            productCart.Add(new Product { Id = 1, Name = "Turbo Sakız", Price = 5, Quantity = 150 });

            productCart.ShowAllProducts();
             

            Console.WriteLine(productCart.GetTotalPrice());

            int x = 5;
            int y = 3;

            string ad = "Türkay";
            string soyad = "Ürkmez";

            Console.WriteLine(x + y);
            Console.WriteLine(ad + x);
        }
    }


    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public int Quantity { get; set; }

        public static double operator +(double value, Product product)
        {
            // var price1 = product1.Price * product1.Quantity;
            var price2 = product.Price * product.Quantity;

            return value + price2;
        }
        public static double operator -(double value, Product product)
        {
            //var price1 = product1.Price * product1.Quantity;
            var price2 = product.Price * product.Quantity;

            return value - price2;
        }

        public static bool operator ==(Product product1, Product product2)
        {
            return product1?.Id == product2?.Id;
            //if (product1 is null || product2 is null)
            //{
            //    return true;
            //}
            //return product1.Equals(product2);
        }
        public static bool operator !=(Product product1, Product product2)
        {
            return product1?.Id != product2?.Id;
            //if (product1 is null || product2 is null)
            //{
            //    return true;
            //}
            //return !product1.Equals(product2);
        }

        // override object.Equals
        public override bool Equals(object obj)
        {
            //       
            // See the full list of guidelines at
            //   http://go.microsoft.com/fwlink/?LinkID=85237  
            // and also the guidance for operator== at
            //   http://go.microsoft.com/fwlink/?LinkId=85238
            //

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            // TODO: write your implementation of Equals() here

            return base.Equals(obj);
        }



        // override object.GetHashCode
        public override int GetHashCode()
        {
            // TODO: write your implementation of GetHashCode() here

            return Id;
        }
    }

    public class ProductCart
    {
        private List<Product> products = new List<Product>();
        public void Add(Product product)
        {
            Product existingProduct = null;
            foreach (var item in products)
            {
                if (item == product)
                {
                    existingProduct = item;
                    break;
                }
            }

            if (existingProduct == null)
            {
                products.Add(product);
            }
            else
            {
                existingProduct.Quantity += product.Quantity;
            }


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

        public double GetTotalPrice()
        {
            var result = 0.0;
            foreach (var item in products)
            {
                result += item;
            }
            return result;
        }

        public void ShowAllProducts()
        {
            products.ForEach(p => Console.WriteLine($"{p.Name} {p.Quantity} {p.Price} "));
        }


    }


}
