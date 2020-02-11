﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtGalleryECommerce.Models
{
    public class OrderProduct
    {
        public int ID { get; set; }
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public DateTime CreationDate { get; set; }

        public OrderProduct()
        {
            this.CreationDate = DateTime.Now;
        }
    }
}
