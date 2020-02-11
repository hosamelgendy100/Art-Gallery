using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using static ArtGalleryECommerce.Models.Common.Common;

namespace ArtGalleryECommerce.Models.ViewModels
{
    [NotMapped]
    public class OrderProductViewModel : OrderProduct
    {
        public IQueryable<OrderProduct> OrderProducts { get; set; }
        private List<OrderProductViewModel> viewModelOrderProducts = new List<OrderProductViewModel>();

        public List<OrderProductViewModel> ViewModelOrderProducts
        {
            get { return viewModelOrderProducts; }
            set { viewModelOrderProducts = value; }
        }

        public string ProductName { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }

        
        public int UserID { get; set; }
        public int CartID { get; set; }
        public string ShipName { get; set; }
        public string ShipSurname { get; set; }
        public string ShipPhone { get; set; }
        public string ShipEMail { get; set; }
        public string ShipAddress { get; set; }
        public double TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }
        public string Message { get; set; }
        
        public OrderState OrderState { get; set; }

    }
}
