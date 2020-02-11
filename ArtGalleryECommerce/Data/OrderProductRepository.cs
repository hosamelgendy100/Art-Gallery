using ArtGalleryECommerce.Interface;
using ArtGalleryECommerce.Models;
using ArtGalleryECommerce.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtGalleryECommerce.Data
{
    public class OrderProductRepository : IOrderProduct
    {
        private Context context;
        public OrderProductRepository(Context _context)
        {
            context = _context;
        }
        public IQueryable<OrderProduct> OrderProducts => context.OrderProducts;

        public OrderProductViewModel GetActivesWithJoin()
        {
            OrderProductViewModel opvmMain = new OrderProductViewModel();
            var list = context.OrderProducts.GroupBy(a => new { a.OrderID }).Select(a => a.First()).Join(context.Orders, e => e.OrderID, c => c.ID, (e, c) => new { ID = e.ID, OrderID = e.OrderID, ProductID = e.ProductID, UserID = c.UserID, CartID = c.CartID, ShipName = c.ShipName, ShipSurname = c.ShipSurname, ShipEMail = c.ShipEMail, ShipAddress = c.ShipAddress, Message = c.Message, OrderDate = c.OrderDate, OrderState = c.OrderState, ShipPhone = c.ShipPhone, TotalPrice = c.TotalPrice }).Join(context.Products, e => e.ProductID, c => c.ID, (e, c) => new { ID = e.ID, OrderID = e.OrderID, ProductID = e.ProductID, UserID = e.UserID, CartID = e.CartID, ShipName = e.ShipName, ShipSurname = e.ShipSurname, ShipEMail = e.ShipEMail, ShipAddress = e.ShipAddress, Message = e.Message, OrderDate = e.OrderDate, OrderState = e.OrderState, ShipPhone = e.ShipPhone, TotalPrice = e.TotalPrice, ProductName = c.ProductName, Image = c.Image, Price = c.Price }).Where(x => x.OrderState == Models.Common.Common.OrderState.Active);

            List<OrderProductViewModel> opViewList = new List<OrderProductViewModel>();

            foreach (var item in list)
            {
                OrderProductViewModel opvm = new OrderProductViewModel();
                opvm.ID = item.ID;
                opvm.OrderID = item.OrderID;
                opvm.ProductID = item.ProductID;
                opvm.UserID = item.UserID;
                opvm.CartID = item.CartID;
                opvm.ShipName = item.ShipName;
                opvm.ShipSurname = item.ShipSurname;
                opvm.ShipEMail = item.ShipEMail;
                opvm.ShipAddress = item.ShipAddress;
                opvm.Message = item.Message;
                opvm.OrderDate = item.OrderDate;
                opvm.OrderState = item.OrderState;
                opvm.ShipPhone = item.ShipPhone;
                opvm.TotalPrice = item.TotalPrice;

                opvm.ProductName = item.ProductName;
                opvm.Image = item.Image;
                opvm.Price = item.Price;

                opViewList.Add(opvm);
            }

            opvmMain.ViewModelOrderProducts = opViewList;
            return opvmMain;
        }
        public OrderProductViewModel GetCompletedWithJoin()
        {
            OrderProductViewModel opvmMain = new OrderProductViewModel();
            var list = context.OrderProducts.GroupBy(a => new { a.OrderID }).Select(a => a.First()).Join(context.Orders, e => e.OrderID, c => c.ID, (e, c) => new { ID = e.ID, OrderID = e.OrderID, ProductID = e.ProductID, UserID = c.UserID, CartID = c.CartID, ShipName = c.ShipName, ShipSurname = c.ShipSurname, ShipEMail = c.ShipEMail, ShipAddress = c.ShipAddress, Message = c.Message, OrderDate = c.OrderDate, OrderState = c.OrderState, ShipPhone = c.ShipPhone, TotalPrice = c.TotalPrice }).Join(context.Products, e => e.ProductID, c => c.ID, (e, c) => new { ID = e.ID, OrderID = e.OrderID, ProductID = e.ProductID, UserID = e.UserID, CartID = e.CartID, ShipName = e.ShipName, ShipSurname = e.ShipSurname, ShipEMail = e.ShipEMail, ShipAddress = e.ShipAddress, Message = e.Message, OrderDate = e.OrderDate, OrderState = e.OrderState, ShipPhone = e.ShipPhone, TotalPrice = e.TotalPrice, ProductName = c.ProductName, Image = c.Image, Price = c.Price }).Where(x => x.OrderState == Models.Common.Common.OrderState.Completed);

            List<OrderProductViewModel> opViewList = new List<OrderProductViewModel>();

            foreach (var item in list)
            {
                OrderProductViewModel opvm = new OrderProductViewModel();
                opvm.ID = item.ID;
                opvm.OrderID = item.OrderID;
                opvm.ProductID = item.ProductID;
                opvm.UserID = item.UserID;
                opvm.CartID = item.CartID;
                opvm.ShipName = item.ShipName;
                opvm.ShipSurname = item.ShipSurname;
                opvm.ShipEMail = item.ShipEMail;
                opvm.ShipAddress = item.ShipAddress;
                opvm.Message = item.Message;
                opvm.OrderDate = item.OrderDate;
                opvm.OrderState = item.OrderState;
                opvm.ShipPhone = item.ShipPhone;
                opvm.TotalPrice = item.TotalPrice;

                opvm.ProductName = item.ProductName;
                opvm.Image = item.Image;
                opvm.Price = item.Price;

                opViewList.Add(opvm);
            }

            opvmMain.ViewModelOrderProducts = opViewList;
            return opvmMain;
        }
        public OrderProductViewModel GetCanceledWithJoin()
        {
            OrderProductViewModel opvmMain = new OrderProductViewModel();
            var list = context.OrderProducts.GroupBy(a => new { a.OrderID }).Select(a => a.First()).Join(context.Orders, e => e.OrderID, c => c.ID, (e, c) => new { ID = e.ID, OrderID = e.OrderID, ProductID = e.ProductID, UserID = c.UserID, CartID = c.CartID, ShipName = c.ShipName, ShipSurname = c.ShipSurname, ShipEMail = c.ShipEMail, ShipAddress = c.ShipAddress, Message = c.Message, OrderDate = c.OrderDate, OrderState = c.OrderState, ShipPhone = c.ShipPhone, TotalPrice = c.TotalPrice }).Join(context.Products, e => e.ProductID, c => c.ID, (e, c) => new { ID = e.ID, OrderID = e.OrderID, ProductID = e.ProductID, UserID = e.UserID, CartID = e.CartID, ShipName = e.ShipName, ShipSurname = e.ShipSurname, ShipEMail = e.ShipEMail, ShipAddress = e.ShipAddress, Message = e.Message, OrderDate = e.OrderDate, OrderState = e.OrderState, ShipPhone = e.ShipPhone, TotalPrice = e.TotalPrice, ProductName = c.ProductName, Image = c.Image, Price = c.Price }).Where(x => x.OrderState == Models.Common.Common.OrderState.Canceled);

            List<OrderProductViewModel> opViewList = new List<OrderProductViewModel>();

            foreach (var item in list)
            {
                OrderProductViewModel opvm = new OrderProductViewModel();
                opvm.ID = item.ID;
                opvm.OrderID = item.OrderID;
                opvm.ProductID = item.ProductID;
                opvm.UserID = item.UserID;
                opvm.CartID = item.CartID;
                opvm.ShipName = item.ShipName;
                opvm.ShipSurname = item.ShipSurname;
                opvm.ShipEMail = item.ShipEMail;
                opvm.ShipAddress = item.ShipAddress;
                opvm.Message = item.Message;
                opvm.OrderDate = item.OrderDate;
                opvm.OrderState = item.OrderState;
                opvm.ShipPhone = item.ShipPhone;
                opvm.TotalPrice = item.TotalPrice;

                opvm.ProductName = item.ProductName;
                opvm.Image = item.Image;
                opvm.Price = item.Price;

                opViewList.Add(opvm);
            }

            opvmMain.ViewModelOrderProducts = opViewList;
            return opvmMain;
        }

        public OrderProductViewModel GetOrderDetails(int ID)
        {
            OrderProductViewModel opvmMain = new OrderProductViewModel();
            var list = context.OrderProducts.Join(context.Orders, e => e.OrderID, c => c.ID, (e, c) => new { ID = e.ID, OrderID = e.OrderID, ProductID = e.ProductID, UserID = c.UserID, CartID = c.CartID, ShipName = c.ShipName, ShipSurname = c.ShipSurname, ShipEMail = c.ShipEMail, ShipAddress = c.ShipAddress, Message = c.Message, OrderDate = c.OrderDate, OrderState = c.OrderState, ShipPhone = c.ShipPhone, TotalPrice = c.TotalPrice }).Join(context.Products, e => e.ProductID, c => c.ID, (e, c) => new { ID = e.ID, OrderID = e.OrderID, ProductID = e.ProductID, UserID = e.UserID, CartID = e.CartID, ShipName = e.ShipName, ShipSurname = e.ShipSurname, ShipEMail = e.ShipEMail, ShipAddress = e.ShipAddress, Message = e.Message, OrderDate = e.OrderDate, OrderState = e.OrderState, ShipPhone = e.ShipPhone, TotalPrice = e.TotalPrice, ProductName = c.ProductName, Image = c.Image, Price = c.Price }).Where(x => x.OrderID == ID);

            List<OrderProductViewModel> opViewList = new List<OrderProductViewModel>();

            foreach (var item in list)
            {
                OrderProductViewModel opvm = new OrderProductViewModel();
                opvm.ID = item.ID;
                opvm.OrderID = item.OrderID;
                opvm.ProductID = item.ProductID;
                opvm.UserID = item.UserID;
                opvm.CartID = item.CartID;
                opvm.ShipName = item.ShipName;
                opvm.ShipSurname = item.ShipSurname;
                opvm.ShipEMail = item.ShipEMail;
                opvm.ShipAddress = item.ShipAddress;
                opvm.Message = item.Message;
                opvm.OrderDate = item.OrderDate;
                opvm.OrderState = item.OrderState;
                opvm.ShipPhone = item.ShipPhone;
                opvm.TotalPrice = item.TotalPrice;

                opvm.ProductName = item.ProductName;
                opvm.Image = item.Image;
                opvm.Price = item.Price;

                opViewList.Add(opvm);
            }

            opvmMain.ViewModelOrderProducts = opViewList;
            return opvmMain;
        }
        public OrderProductViewModel GetByViewID(int ID)
        {
            OrderProductViewModel opvm = new OrderProductViewModel();
            var orderProduct = context.OrderProducts.Join(context.Orders, e => e.OrderID, c => c.ID, (e, c) => new { ID = e.ID, OrderID = e.OrderID, ProductID = e.ProductID, UserID = c.UserID, CartID = c.CartID, ShipName = c.ShipName, ShipSurname = c.ShipSurname, ShipEMail = c.ShipEMail, ShipAddress = c.ShipAddress, Message = c.Message, OrderDate = c.OrderDate, OrderState = c.OrderState, ShipPhone = c.ShipPhone, TotalPrice = c.TotalPrice }).Join(context.Products, e => e.ProductID, c => c.ID, (e, c) => new { ID = e.ID, OrderID = e.OrderID, ProductID = e.ProductID, UserID = e.UserID, CartID = e.CartID, ShipName = e.ShipName, ShipSurname = e.ShipSurname, ShipEMail = e.ShipEMail, ShipAddress = e.ShipAddress, Message = e.Message, OrderDate = e.OrderDate, OrderState = e.OrderState, ShipPhone = e.ShipPhone, TotalPrice = e.TotalPrice, ProductName = c.ProductName, Image = c.Image, Price = c.Price }).Where(x => x.OrderID == ID).FirstOrDefault();

            opvm.ID = orderProduct.ID;
            opvm.OrderID = orderProduct.OrderID;
            opvm.ProductID = orderProduct.ProductID;
            opvm.UserID = orderProduct.UserID;
            opvm.CartID = orderProduct.CartID;
            opvm.ShipName = orderProduct.ShipName;
            opvm.ShipSurname = orderProduct.ShipSurname;
            opvm.ShipEMail = orderProduct.ShipEMail;
            opvm.ShipAddress = orderProduct.ShipAddress;
            opvm.Message = orderProduct.Message;
            opvm.OrderDate = orderProduct.OrderDate;
            opvm.OrderState = orderProduct.OrderState;
            opvm.ShipPhone = orderProduct.ShipPhone;
            opvm.TotalPrice = orderProduct.TotalPrice;

            opvm.ProductName = orderProduct.ProductName;
            opvm.Image = orderProduct.Image;
            opvm.Price = orderProduct.Price;
            return opvm;
        }

        public bool AddOrderProduct(int orderID, int productID)
        {

            context.OrderProducts.Add(new OrderProduct { OrderID = orderID, ProductID = productID });
            return (context.SaveChanges() > 0) ? true : false;
        }

        public bool DelOrderProduct(OrderProduct orderProduct)
        {
            throw new NotImplementedException();
        }

        public bool UpdateOrderProduct(OrderProduct orderProduct)
        {
            throw new NotImplementedException();
        }

        public OrderProductViewModel GetOrdersByUserWithJoin(int userId)
        {
            OrderProductViewModel opvmMain = new OrderProductViewModel();
            var list = context.OrderProducts.GroupBy(a => new { a.OrderID }).Select(a => a.First()).Join(context.Orders, e => e.OrderID, c => c.ID, (e, c) => new { ID = e.ID, OrderID = e.OrderID, ProductID = e.ProductID, UserID = c.UserID, CartID = c.CartID, ShipName = c.ShipName, ShipSurname = c.ShipSurname, ShipEMail = c.ShipEMail, ShipAddress = c.ShipAddress, Message = c.Message, OrderDate = c.OrderDate, OrderState = c.OrderState, ShipPhone = c.ShipPhone, TotalPrice = c.TotalPrice }).Join(context.Products, e => e.ProductID, c => c.ID, (e, c) => new { ID = e.ID, OrderID = e.OrderID, ProductID = e.ProductID, UserID = e.UserID, CartID = e.CartID, ShipName = e.ShipName, ShipSurname = e.ShipSurname, ShipEMail = e.ShipEMail, ShipAddress = e.ShipAddress, Message = e.Message, OrderDate = e.OrderDate, OrderState = e.OrderState, ShipPhone = e.ShipPhone, TotalPrice = e.TotalPrice, ProductName = c.ProductName, Image = c.Image, Price = c.Price }).Where(x=>x.UserID==userId);

            List<OrderProductViewModel> opViewList = new List<OrderProductViewModel>();

            foreach (var item in list)
            {
                OrderProductViewModel opvm = new OrderProductViewModel();
                opvm.ID = item.ID;
                opvm.OrderID = item.OrderID;
                opvm.ProductID = item.ProductID;
                opvm.UserID = item.UserID;
                opvm.CartID = item.CartID;
                opvm.ShipName = item.ShipName;
                opvm.ShipSurname = item.ShipSurname;
                opvm.ShipEMail = item.ShipEMail;
                opvm.ShipAddress = item.ShipAddress;
                opvm.Message = item.Message;
                opvm.OrderDate = item.OrderDate;
                opvm.OrderState = item.OrderState;
                opvm.ShipPhone = item.ShipPhone;
                opvm.TotalPrice = item.TotalPrice;

                opvm.ProductName = item.ProductName;
                opvm.Image = item.Image;
                opvm.Price = item.Price;

                opViewList.Add(opvm);
            }

            opvmMain.ViewModelOrderProducts = opViewList;
            return opvmMain;
        }
    }
}
