using ArtGalleryECommerce.Interface;
using ArtGalleryECommerce.Models;
using ArtGalleryECommerce.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtGalleryECommerce.Data
{
    public class UserRepository : IUser
    {
        private Context context;
        public UserRepository(Context _context)
        {
            context = _context;
        }
        public IQueryable<User> Users => context.Users;


        public bool AddUser(User user)
        {
            if (!context.Users.Select(x => x.EMail).Contains(user.EMail))
            {
                context.Users.Add(user);

            }
            if (context.SaveChanges() > 0)
            {
                Cart cart = new Cart();
                cart.UserID = context.Users.Where(x => x.EMail == user.EMail).Select(x => x.ID).FirstOrDefault();
                context.Carts.Add(cart);
            }

            return (context.SaveChanges() > 0) ? true : false;
        }

        public bool DelUser(User user)
        {
            context.Users.Remove(user);
            context.Carts.Remove(context.Carts.Where(x => x.UserID == user.ID).FirstOrDefault());
            return (context.SaveChanges() > 0) ? true : false;
        }

        public UserViewModel GetActiveUsers()
        {
            UserViewModel uvm = new UserViewModel();
            uvm.Users = context.Users.Where(x => x.IsActive == true);
            return uvm;
        }

        public User GetByID(int ID)
        {
            var user = context.Users.Where(x => x.ID == ID).FirstOrDefault();
            return user;
        }

        public int GetIdByGuid(string guid)
        {
            var userId = context.Users.Where(x => x.Guid == guid).Select(x => x.ID).FirstOrDefault();
            return userId;
        }

        public string GetMailByGuid(string guid)
        {
            var mail = context.Users.Where(x => x.ID == GetIdByGuid(guid)).Select(x => x.EMail).FirstOrDefault();
            return mail;
        }

        public string GetUserFullNameByGuid(string guid)
        {
            var name = context.Users.Where(x => x.ID == GetIdByGuid(guid)).Select(x => x.Name).FirstOrDefault();
            var surname = context.Users.Where(x => x.ID == GetIdByGuid(guid)).Select(x => x.Surname).FirstOrDefault();
            var fullName = name + " " + surname;
            return name;
        }

        public UserViewModel GetUsers()
        {
            UserViewModel uvm = new UserViewModel();
            uvm.Users = context.Users;
            return uvm;
        }

        public UserViewModel GetUsers(int? ID)
        {
            throw new NotImplementedException();
        }

        public bool UpdateUser(User user)
        {
            context.Users.Update(user);
            return (context.SaveChanges() > 0) ? true : false;
        }
    }
}
