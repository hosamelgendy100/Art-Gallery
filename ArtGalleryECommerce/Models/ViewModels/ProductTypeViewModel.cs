using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ArtGalleryECommerce.Models.ViewModels
{
    [NotMapped]
    public class ProductTypeViewModel : ProductType
    {
        [NotMapped]
        public IQueryable<ProductType> ProductTypes { get; set; }
        [NotMapped]
        public ProductType ProductTypeInstance { get; set; }
        [NotMapped]
        public int ProductTypeID { get; set; }
        [NotMapped]
        public int SelectedProductTypeID { get; set; }
        [NotMapped]
        public string SelectedProductTypeName { get; set; }
    }
}
