using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtGalleryECommerce.Models
{
    public class UserCart
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int CartID { get; set; }
        public int ProductID { get; set; }
    }
}
