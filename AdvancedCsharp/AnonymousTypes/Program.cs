using System;
using System.Collections.Generic;
using System.Linq;

namespace AnonymousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 5;
            var y = "Türkay";

            FakeService fake = new FakeService();
            var  products = fake.GetProducts();
            var spesificProperties = fake.GetProducts().Select(pr => new { Ad = pr.Name, Fiyat = pr.Price });

            spesificProperties.ToList().ForEach(an => Console.WriteLine($"{an.Ad} isimli ürünün fiyatı {an.Fiyat}"));



        }
    }
}
