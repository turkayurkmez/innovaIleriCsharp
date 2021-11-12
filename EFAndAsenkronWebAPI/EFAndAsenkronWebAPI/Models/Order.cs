using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFAndAsenkronWebAPI.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

    }
}
