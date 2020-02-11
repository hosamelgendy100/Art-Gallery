using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace ArtGalleryECommerce.Models.ViewModels
{
    [NotMapped]
    public class ProductViewModel : Product
    {
        [NotMapped]
        public IQueryable<Product> Products { get; set; }
        [NotMapped]
        private List<ProductViewModel> viewModelProducts = new List<ProductViewModel>();
        [NotMapped]
        private List<ProductViewModel> viewModelActiveProducts = new List<ProductViewModel>();
        [NotMapped]
        public List<ProductViewModel> ViewModelActiveProducts
        {
            get { return viewModelActiveProducts; }
            set { viewModelActiveProducts = value; }
        }
        [NotMapped]
        public List<ProductViewModel> ViewModelProducts
        {
            get { return viewModelProducts; }
            set { viewModelProducts = value; }
        }
        
        [NotMapped]
        public Product ProductInstance { get; set; }
        //public Image Img { get; set; }
        [NotMapped]
        public string Artist { get; set; }
        [NotMapped]
        public string ProductType { get; set; }

        //public static int UserID { get; set; }
    }
}
