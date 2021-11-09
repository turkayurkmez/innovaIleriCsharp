using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousTypes
{
   public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> Features { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public DateTime CreatedDate { get; set; }
        public int Stock { get; set; }
    }
}
