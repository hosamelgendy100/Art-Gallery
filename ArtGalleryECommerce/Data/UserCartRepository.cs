using ArtGalleryECommerce.Interface;
using ArtGalleryECommerce.Models;
using ArtGalleryECommerce.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtGalleryECommerce.Data
{
    public class UserCartRepository : IUserCart
    {
        private Context context;
        public UserCartRepository(Context _context)
        {
            context = _context;
        }
        public IQueryable<UserCart> UserCarts => context.UserCarts;

        public ProductViewModel GetProductsInCart(int userID)
        {
            var productsInCart = context.UserCarts.Where(x => x.UserID == userID);
            return null;
        }

        public bool AddUserCart(UserCart userCart)
        {
            context.UserCarts.Add(userCart);
            return (context.SaveChanges() > 0) ? true : false;
        }

        public bool AddUserCart(int productID)
        {
            if (UserCartViewModel.UserAccountID != 0)
            {


                var cartId = context.Carts.Where(x => x.ID == UserCartViewModel.UserAccountID).Select(a => a.ID).FirstOrDefault();
                var list = context.UserCarts.Where(x => x.UserID == UserCartViewModel.UserAccountID);
                if (!list.Select(x => x.ProductID).Contains(productID))
                {
                    UserCart userCart = new UserCart();
                    userCart.UserID = UserCartViewModel.UserAccountID;
                    userCart.CartID = cartId;
                    userCart.ProductID = productID;
                    context.UserCarts.Add(userCart);
                    return (context.SaveChanges() > 0) ? true : false;
                }
                else return false;
            }
            else return false;

        }

        public void DelUserCart(int userID)
        {
            do
            {
                var cart = context.UserCarts.Where(x => x.UserID == userID).FirstOrDefault();
                context.UserCarts.Remove(cart);
                context.SaveChanges();
            } while (context.UserCarts.Select(x => x.UserID).Contains(userID));


        }

        public UserCart GetByID(int ID)
        {
            throw new NotImplementedException();
        }

        public UserCartViewModel GetUserCarts()
        {
            throw new NotImplementedException();
        }

        public UserCartViewModel GetUserCarts(int? ID)
        {
            throw new NotImplementedException();
        }

        public bool UpdateUserCart(UserCart userCart)
        {
            throw new NotImplementedException();
        }

        public UserCartViewModel GetWithJoin()
        {
            throw new NotImplementedException();
        }

        public UserCartViewModel GetUsersInUserCart()
        {
            UserCartViewModel ucvmMain = new UserCartViewModel();
            var list = context.UserCarts.GroupBy(a => new { a.UserID }).Select(a => a.First()).Join(context.Users, e => e.UserID, c => c.ID, (e, c) => new { UserID = e.UserID, CartID = e.CartID, Name = c.Name, Surname = c.Surname, EMail = c.EMail });
            List<UserCartViewModel> uViewList = new List<UserCartViewModel>();

            foreach (var item in list)
            {
                UserCartViewModel uvm = new UserCartViewModel();

                uvm.Name = item.Name;
                uvm.Surname = item.Surname;
                uvm.EMail = item.EMail;

                uvm.UserID = item.UserID;
                uvm.CartID = item.CartID;

                uViewList.Add(uvm);
            }

            ucvmMain.ViewModelUserCarts = uViewList;
            return ucvmMain;
        }

        public UserCartViewModel GetCartOfUser(int ID)
        {
            UserCartViewModel ucvmMain = new UserCartViewModel();
            var list = context.Products.Join(context.Artists, e => e.ArtistID, c => c.ID, (e, c) => new { ProductName = e.ProductName, ID = e.ID, ProductDescription = e.ProductDescription, Price = e.Price, ProductSize = e.ProductSize, Artist = c.Name + " " + c.Surname, ArtistID = e.ArtistID, ProductTypeID = e.ProductTypeID, Image = e.Image, IsActive = e.IsActive, CreationDate = e.CreationDate }).Join(context.ProductTypes, e => e.ProductTypeID, c => c.ID, (e, c) => new { ProductName = e.ProductName, ID = e.ID, ProductDescription = e.ProductDescription, Price = e.Price, ProductSize = e.ProductSize, Artist = e.Artist, ArtistID = e.ArtistID, ProductTypeID = e.ProductTypeID, ProductType = c.Type, Image = e.Image, IsActive = e.IsActive, CreationDate = e.CreationDate }).Join(context.UserCarts.Where(x => x.UserID == ID), e => e.ID, c => c.ProductID, (e, c) => new { ID = e.ID, ProductName = e.ProductName, ProductDescription = e.ProductDescription, Price = e.Price, ProductSize = e.ProductSize, Artist = e.Artist, ArtistID = e.ArtistID, ProductTypeID = e.ProductTypeID, ProductType = e.ProductType, Image = e.Image, IsActive = e.IsActive, CreationDate = e.CreationDate, ProductID = c.ProductID, UserID = c.UserID, CartID = c.CartID });

            List<UserCartViewModel> uViewList = new List<UserCartViewModel>();

            foreach (var item in list)
            {
                UserCartViewModel uvm = new UserCartViewModel();
                uvm.ProductID = item.ProductID;
                uvm.ProductName = item.ProductName;
                uvm.ProductDescription = item.ProductDescription;
                uvm.Price = item.Price;
                uvm.ProductSize = item.ProductSize;
                uvm.Artist = item.Artist;
                uvm.ProductType = item.ProductType;
                uvm.Image = item.Image;
                uvm.IsActive = item.IsActive;
                uvm.ArtistID = item.ArtistID;
                uvm.ProductTypeID = item.ProductTypeID;



                uvm.CartID = item.CartID;


                uViewList.Add(uvm);
            }


            ucvmMain.ViewModelUserCarts = uViewList;
            return ucvmMain;
        }


        public UserCartViewModel GetWithJoin(int ID)
        {
            UserCartViewModel ucvmMain = new UserCartViewModel();
            var list = context.Products.Join(context.Artists, e => e.ArtistID, c => c.ID, (e, c) => new { ProductName = e.ProductName, ID = e.ID, ProductDescription = e.ProductDescription, Price = e.Price, ProductSize = e.ProductSize, Artist = c.Name + " " + c.Surname, ArtistID = e.ArtistID, ProductTypeID = e.ProductTypeID, Image = e.Image, IsActive = e.IsActive, CreationDate = e.CreationDate }).Join(context.ProductTypes, e => e.ProductTypeID, c => c.ID, (e, c) => new { ProductName = e.ProductName, ID = e.ID, ProductDescription = e.ProductDescription, Price = e.Price, ProductSize = e.ProductSize, Artist = e.Artist, ArtistID = e.ArtistID, ProductTypeID = e.ProductTypeID, ProductType = c.Type, Image = e.Image, IsActive = e.IsActive, CreationDate = e.CreationDate }).Join(context.UserCarts, e => e.ID, c => c.ProductID, (e, c) => new { ID = e.ID, ProductName = e.ProductName, ProductDescription = e.ProductDescription, Price = e.Price, ProductSize = e.ProductSize, Artist = e.Artist, ArtistID = e.ArtistID, ProductTypeID = e.ProductTypeID, ProductType = e.ProductType, Image = e.Image, IsActive = e.IsActive, CreationDate = e.CreationDate, ProductID = c.ProductID, UserID = c.UserID, CartID = c.CartID }).Join(context.Users, e => e.UserID, c => c.ID, (e, c) => new { ID = e.ID, ProductName = e.ProductName, ProductDescription = e.ProductDescription, Price = e.Price, ProductSize = e.ProductSize, Artist = e.Artist, ArtistID = e.ArtistID, ProductTypeID = e.ProductTypeID, ProductType = e.ProductType, Image = e.Image, IsActive = e.IsActive, CreationDate = e.CreationDate, ProductID = e.ProductID, UserID = e.UserID, CartID = e.CartID, Name = c.Name, Surname = c.Surname, EMail = c.EMail }).Where(x => x.UserID == ID);

            List<UserCartViewModel> uViewList = new List<UserCartViewModel>();

            foreach (var item in list)
            {
                UserCartViewModel uvm = new UserCartViewModel();
                uvm.ProductID = item.ProductID;
                uvm.ProductName = item.ProductName;
                uvm.ProductDescription = item.ProductDescription;
                uvm.Price = item.Price;
                uvm.ProductSize = item.ProductSize;
                uvm.Artist = item.Artist;
                uvm.ProductType = item.ProductType;
                uvm.Image = item.Image;
                uvm.IsActive = item.IsActive;
                uvm.ArtistID = item.ArtistID;
                uvm.ProductTypeID = item.ProductTypeID;

                uvm.Name = item.Name;
                uvm.Surname = item.Surname;
                uvm.EMail = item.EMail;

                uvm.CartID = item.CartID;


                uViewList.Add(uvm);
            }


            ucvmMain.ViewModelUserCarts = uViewList;
            return ucvmMain;
        }

        public bool DeleteFromCart(int ProductID)
        {
            var instance = context.UserCarts.Where(x => x.UserID == UserCartViewModel.UserAccountID && x.ProductID == ProductID).FirstOrDefault();
            if (instance != null)
            {
                context.UserCarts.Remove(instance);
                return (context.SaveChanges() > 0) ? true : false;
            }
            else
            {
                return false;
            }

        }

        public double GetTotalPrice(int UserID)
        {
            return context.Products.Join(context.Artists, e => e.ArtistID, c => c.ID, (e, c) => new { ProductName = e.ProductName, ID = e.ID, ProductDescription = e.ProductDescription, Price = e.Price, ProductSize = e.ProductSize, Artist = c.Name + " " + c.Surname, ArtistID = e.ArtistID, ProductTypeID = e.ProductTypeID, Image = e.Image, IsActive = e.IsActive, CreationDate = e.CreationDate }).Join(context.ProductTypes, e => e.ProductTypeID, c => c.ID, (e, c) => new { ProductName = e.ProductName, ID = e.ID, ProductDescription = e.ProductDescription, Price = e.Price, ProductSize = e.ProductSize, Artist = e.Artist, ArtistID = e.ArtistID, ProductTypeID = e.ProductTypeID, ProductType = c.Type, Image = e.Image, IsActive = e.IsActive, CreationDate = e.CreationDate }).Join(context.UserCarts, e => e.ID, c => c.ProductID, (e, c) => new { ID = e.ID, ProductName = e.ProductName, ProductDescription = e.ProductDescription, Price = e.Price, ProductSize = e.ProductSize, Artist = e.Artist, ArtistID = e.ArtistID, ProductTypeID = e.ProductTypeID, ProductType = e.ProductType, Image = e.Image, IsActive = e.IsActive, CreationDate = e.CreationDate, ProductID = c.ProductID, UserID = c.UserID, CartID = c.CartID }).Join(context.Users, e => e.UserID, c => c.ID, (e, c) => new { ID = e.ID, ProductName = e.ProductName, ProductDescription = e.ProductDescription, Price = e.Price, ProductSize = e.ProductSize, Artist = e.Artist, ArtistID = e.ArtistID, ProductTypeID = e.ProductTypeID, ProductType = e.ProductType, Image = e.Image, IsActive = e.IsActive, CreationDate = e.CreationDate, ProductID = e.ProductID, UserID = e.UserID, CartID = e.CartID, Name = c.Name, Surname = c.Surname, EMail = c.EMail }).Where(x => x.UserID == UserID).Sum(x => x.Price);
        }
    }
}
