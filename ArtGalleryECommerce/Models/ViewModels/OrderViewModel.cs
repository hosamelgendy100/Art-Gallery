using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtGalleryECommerce.Models.ViewModels
{
    public class OrderViewModel : Order
    {
        public IQueryable<Order> Orders { get; set; }
        public List<OrderViewModel> ViewModelOrders { get; set; }
        
    }
}
