using ArtGalleryECommerce.Models;
using ArtGalleryECommerce.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtGalleryECommerce.Interface
{
    public interface IOrder
    {
        IQueryable<Order> Orders { get; }
        OrderViewModel GetOrders();
        //OrderViewModel GetArtists(int? ID);
        Order GetByID(int ID);
        User GetUserByOrderId(int orderId);
        bool ActivateOrder(int ID);
        bool CancelOrder(int ID);
        bool CompleteOrder(int ID);
        bool AddOrder(Order order);
        bool UpdateOrder(Order order);
        bool DelOrder(Order order);
    }
}
