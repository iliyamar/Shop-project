﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainClasses
{
    public class OrderedProduct
    {
        public OrderedProduct()
        {
            Quantity = 1;
        }

        [Key, Column(Order = 1)]
        public int OrderID { get; set; }

        [Key, Column(Order = 2)]
        public int ProductID { get; set; }

        public Order Order { get; set; }

        public int Quantity { get; set; }

        public Product Product { get; set; }
    }
}
