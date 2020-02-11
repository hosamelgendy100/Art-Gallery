using ArtGalleryECommerce.Models;
using ArtGalleryECommerce.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtGalleryECommerce.Interface
{
    public interface IUserCart
    {
        IQueryable<UserCart> UserCarts { get; }
        UserCartViewModel GetUserCarts();
        UserCartViewModel GetUserCarts(int? ID);
        UserCartViewModel GetWithJoin();
        UserCartViewModel GetWithJoin(int ID);
        UserCart GetByID(int ID);
        double GetTotalPrice(int UserID);
        UserCartViewModel GetUsersInUserCart();
        UserCartViewModel GetCartOfUser(int ID);

        bool AddUserCart(int productID);
        bool AddUserCart(UserCart userCart);
        bool UpdateUserCart(UserCart userCart);
        void DelUserCart(int userID);
        bool DeleteFromCart(int ProductID);
    }
}
