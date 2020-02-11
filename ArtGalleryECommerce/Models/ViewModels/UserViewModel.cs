using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ArtGalleryECommerce.Models.ViewModels
{
    [NotMapped]
    public class UserViewModel : User
    {
        public IQueryable<User> Users { get; set; }
        public int CartID { get; set; }
    }
}
