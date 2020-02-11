using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using static ArtGalleryECommerce.Models.Common.Common;

namespace ArtGalleryECommerce.Models.ViewModels
{
    [NotMapped]
    public class UserCartViewModel : UserCart
    {
        public IQueryable<UserCart> UserCarts { get; set; }
        public List<UserCartViewModel> ViewModelUserCarts { get; set; }

        
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public double Price { get; set; }
        public string ProductSize { get; set; }
        public int ArtistID { get; set; }
        public int ProductTypeID { get; set; }
        public string Artist { get; set; }
        public string ProductType { get; set; }
        public string Image { get; set; }
        public bool IsActive { get; set; }
        public ProductState ProductState { get; set; }


        public string Name { get; set; }
        public string Surname { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }
        public string CitizenshipNo { get; set; }
        public string Nationality { get; set; }
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }

        public double TotalPrice { get; set; }

        public static int UserAccountID { get; set; }
    }
}
