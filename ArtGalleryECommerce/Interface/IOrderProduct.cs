using ArtGalleryECommerce.Models;
using ArtGalleryECommerce.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtGalleryECommerce.Interface
{
    public interface IOrderProduct
    {
        IQueryable<OrderProduct> OrderProducts { get; }
        OrderProductViewModel GetOrdersByUserWithJoin(int userId);
        OrderProductViewModel GetActivesWithJoin();
        OrderProductViewModel GetCanceledWithJoin();
        OrderProductViewModel GetCompletedWithJoin();
        OrderProductViewModel GetByViewID(int ID);
        OrderProductViewModel GetOrderDetails(int ID);
       

        bool AddOrderProduct(int orderID, int productID);
        bool UpdateOrderProduct(OrderProduct orderProduct);
        bool DelOrderProduct(OrderProduct orderProduct);
    }
}
