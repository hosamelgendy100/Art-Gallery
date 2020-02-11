using ArtGalleryECommerce.Models;
using ArtGalleryECommerce.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtGalleryECommerce.Interface
{
    public interface IUser
    {
        IQueryable<User> Users { get; }
        UserViewModel GetUsers();
        UserViewModel GetActiveUsers();
        UserViewModel GetUsers(int? ID);
        User GetByID(int ID);
        int GetIdByGuid(string guid);
        string GetMailByGuid(string guid);
        string GetUserFullNameByGuid(string guid);

        bool AddUser(User user);
        bool UpdateUser(User user);
        bool DelUser(User user);
    }
}
