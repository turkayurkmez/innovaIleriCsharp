﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFAndAsenkronWebAPI.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(150)]
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }

        public virtual Category Category { get; set; }
        public int CategoryId { get; set; }

        public virtual ICollection<OrderDetail> Orders { get; set; }
    }
}
