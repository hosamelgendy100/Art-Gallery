using ArtGalleryECommerce.Interface;
using ArtGalleryECommerce.Models;
using ArtGalleryECommerce.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtGalleryECommerce.Data
{
    public class CartRepository : ICart
    {
        private Context context;
        public CartRepository(Context _context)
        {
            context = _context;
        }
        public IQueryable<Cart> Carts => context.Carts;

        public bool AddCart(Cart cart)
        {
            throw new NotImplementedException();
        }

        public bool DelCart(Cart cart)
        {
            throw new NotImplementedException();
        }

        public int GetCartID(int userID)
        {
            return context.Carts.Where(x => x.UserID == userID).Select(x => x.ID).FirstOrDefault();
        }

        public CartViewModel GetCarts()
        {
            throw new NotImplementedException();
        }

        public CartViewModel GetCarts(int? ID)
        {
            throw new NotImplementedException();
        }

        public bool UpdateCart(Cart cart)
        {
            throw new NotImplementedException();
        }
    }
}
