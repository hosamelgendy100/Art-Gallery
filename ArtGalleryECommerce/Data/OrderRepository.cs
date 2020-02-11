using ArtGalleryECommerce.Interface;
using ArtGalleryECommerce.Models;
using ArtGalleryECommerce.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtGalleryECommerce.Data
{
    public class OrderRepository : IOrder
    {
        private Context context;
        private IUserCart repoUserCart;
        private ICart repoCart;
        private IOrderProduct orderProduct;
        public OrderRepository(Context _context, IUserCart _repoUserCart, ICart _repoCart, IOrderProduct _orderProduct)
        {
            context = _context;
            repoUserCart = _repoUserCart;
            repoCart = _repoCart;
            orderProduct = _orderProduct;
        }
        public IQueryable<Order> Orders => context.Orders;

        public bool AddOrder(Order order)
        {
            order.CartID = repoCart.GetCartID(UserCartViewModel.UserAccountID);
            order.TotalPrice = repoUserCart.GetTotalPrice(UserCartViewModel.UserAccountID);
            context.Orders.Add(order);
            if (context.SaveChanges() > 0)
            {
                var productsInCart = context.UserCarts.Where(x => x.UserID == UserCartViewModel.UserAccountID).Select(x => x.ProductID).ToList();
                foreach (var item in productsInCart)
                {
                    var product = context.Products.Where(x => x.ID == item).FirstOrDefault();
                    if (product.ProductState != Models.Common.Common.ProductState.Sold || product.ProductState != Models.Common.Common.ProductState.Inactive)
                    {
                        product.ProductState = Models.Common.Common.ProductState.Sold;
                        context.Products.Update(product);
                        context.UserCarts.RemoveRange(context.UserCarts.Where(x=>x.ProductID == product.ID));
                    }
                    else return false;
                }
                
                var orderID = order.ID;

                foreach (var item in productsInCart)
                {
                    OrderProduct op = new OrderProduct();
                    op.OrderID = orderID;
                    op.ProductID = item;
                    context.OrderProducts.Add(op);
                }

                repoUserCart.DelUserCart(UserCartViewModel.UserAccountID);
                return (context.SaveChanges() > 0) ? true : false;
            }
            else return false;
        }

        public bool DelOrder(Order order)
        {
            context.Orders.Remove(order);
            return (context.SaveChanges() > 0) ? true : false;
        }

        public Order GetByID(int ID)
        {
            var order = context.Orders.Where(x => x.ID == ID).FirstOrDefault();

            return order;
        }

        public User GetUserByOrderId(int orderId)
        {
            var userId = context.Orders.Where(x => x.ID == orderId).Select(x => x.UserID).FirstOrDefault();
            var user = context.Users.Where(x => x.ID == userId).FirstOrDefault();
            return user;
        }

        public OrderViewModel GetOrders()
        {
            OrderViewModel ovm = new OrderViewModel();
            ovm.Orders = context.Orders;
            return ovm;
        }

        public bool UpdateOrder(Order order)
        {
            context.Orders.Update(order);
            return (context.SaveChanges() > 0) ? true : false;
        }

        public bool ActivateOrder(int ID)
        {
            var order = context.Orders.Where(x => x.ID == ID).FirstOrDefault();
            order.OrderState = Models.Common.Common.OrderState.Active;
            context.Orders.Update(order);
            return (context.SaveChanges() > 0) ? true : false;
        }

        public bool CancelOrder(int ID)
        {
            var order = context.Orders.Where(x => x.ID == ID).FirstOrDefault();
            order.OrderState = Models.Common.Common.OrderState.Canceled;



            context.Orders.Update(order);
            return (context.SaveChanges() > 0) ? true : false;
        }

        public bool CompleteOrder(int ID)
        {
            var order = context.Orders.Where(x => x.ID == ID).FirstOrDefault();
            order.OrderState = Models.Common.Common.OrderState.Completed;
            context.Orders.Update(order);
            return (context.SaveChanges() > 0) ? true : false;
        }
    }
}
