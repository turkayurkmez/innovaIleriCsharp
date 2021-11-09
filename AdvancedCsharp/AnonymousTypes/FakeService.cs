using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousTypes
{
   public class FakeService
    {
        List<Product> products = new List<Product>
        {
            new Product { Id =1, Name="IPhone 13", CreatedDate=DateTime.Now, Description="Pahalı", ImageUrl="birResim.jpg", Price=12000, Stock=100},
            new Product { Id =2, Name="Samsung A51", CreatedDate=DateTime.Now, Description="Normal", ImageUrl="birResim.jpg", Price=4000, Stock=100},
            new Product { Id =3, Name="Xiaomi Mi", CreatedDate=DateTime.Now, Description="Ucuz", ImageUrl="birResim.jpg", Price=2500, Stock=100},


        };
        public List<Product> GetProducts()
        {
            return products;
        }
    }
}
