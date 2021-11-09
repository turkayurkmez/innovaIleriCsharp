using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMechanism
{
   public class ProductBusiness
    {
       
        public event EventHandler<ProductAddedEventArgs> ProductAdded;
        public void AddProduct(Product product)
        {
            if (ProductAdded != null)
            {
                ProductAddedEventArgs e = new ProductAddedEventArgs { CreatedDate = DateTime.Now, Operator = "türkay", Product = product };
                ProductAdded(this, e);
            }
        }
    }

    public class ProductAddedEventArgs: EventArgs
    {
        public Product Product { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Operator { get; set; }
    }
}
