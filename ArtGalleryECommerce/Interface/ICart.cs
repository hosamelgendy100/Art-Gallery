using ArtGalleryECommerce.Models;
using ArtGalleryECommerce.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtGalleryECommerce.Interface
{
    public interface ICart
    {
        IQueryable<Cart> Carts { get; }
        CartViewModel GetCarts();
        CartViewModel GetCarts(int? ID);
        //Cart GetByID(int ID);
        int GetCartID(int userID);

        bool AddCart(Cart cart);
        bool UpdateCart(Cart cart);
        bool DelCart(Cart cart);
    }
}
