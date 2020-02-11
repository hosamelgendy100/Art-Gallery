using ArtGalleryECommerce.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static ArtGalleryECommerce.Models.Common.Common;

namespace ArtGalleryECommerce.Models
{
    public class Order
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int CartID { get; set; }
        public string ShipName { get; set; }
        public string ShipSurname { get; set; }
        public string ShipPhone { get; set; }
        public string ShipEMail { get; set; }
        //public string ShipCompany { get; set; }
        public string ShipAddress { get; set; }
        public double TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }
        public string Message { get; set; }
        public bool IsActive { get; set; }
        public OrderState OrderState { get; set; }


        public Order()
        {
            this.IsActive = true;
            this.OrderDate = DateTime.Now;
            this.UserID = UserCartViewModel.UserAccountID;
            this.OrderState = OrderState.Active;
            
        }
    }
}
