using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static ArtGalleryECommerce.Models.Common.Common;

namespace ArtGalleryECommerce.Models
{
    public class Product
    {
        public int? ID { get; set; }
        [Required(ErrorMessage = "Tablo adı girin")]
        public string ProductName { get; set; }
       
        public string ProductDescription { get; set; }
        [Required(ErrorMessage = "Fiyat girin")]
        public double Price { get; set; }
        [Required(ErrorMessage = "Boyut Girin")]
        public string ProductSize { get; set; }
        [Required(ErrorMessage = "Ressam Girin")]
        public int ArtistID { get; set; }
        [Required(ErrorMessage = "Ürün Tipi Girin")]
        public int ProductTypeID { get; set; }
        [Required(ErrorMessage = "Resim Ekleyin")]
        public string Image { get; set; }
        
        public bool IsActive { get; set; }
        
        public DateTime CreationDate { get; set; }
        public ProductState ProductState { get; set; }

        public Product()
        {
            this.IsActive = true;
            this.CreationDate = DateTime.Now;
            this.ProductState = ProductState.Active;
        }
    }
}
