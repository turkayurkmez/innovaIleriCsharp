using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFAndAsenkronWebAPI.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Navigation Property
        public virtual ICollection<Product> Products { get; set; }

       
    }
}
