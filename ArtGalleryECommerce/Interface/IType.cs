using ArtGalleryECommerce.Models;
using ArtGalleryECommerce.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtGalleryECommerce.Interface
{
    public interface IType
    {
        IQueryable<ProductType> ProductTypes { get; }
        ProductTypeViewModel GetProductTypes();
        ProductTypeViewModel GetProductTypes(int? ID);
        ProductType GetByID(int ID);
        bool AddProductType(ProductType productType);
        bool UpdateProductType(ProductType productType);
        bool DelProductType(ProductType productType);
    }
}
