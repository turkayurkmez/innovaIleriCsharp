using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFAndAsenkronWebAPI.Models
{
    public class OrderDetail
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int Quantity { get; set; }
        public virtual Order Order { get; set; }

    }
}
