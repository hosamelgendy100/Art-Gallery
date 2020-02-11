using ArtGalleryECommerce.Models;
using ArtGalleryECommerce.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtGalleryECommerce.Interface
{
    public interface IProduct
    {
        IQueryable<Product> Products { get; }
        ProductViewModel GetProducts();
        ProductViewModel GetWithJoin();
        ProductViewModel GetActivesWithJoin();
        ProductViewModel GetInactivesWithJoin();
        ProductViewModel GetSoldWithJoin();
        Product GetByID(int ID);
        ProductViewModel GetByArtist(int artistId);
        bool AddProduct(Product product);
        bool UpdateProduct(Product product);
        bool DelProduct(Product product);
        IEnumerable<ProductViewModel> GetByFilters(string Id = null, string name = null, string shortName = null, float? price = null);
    }
}
