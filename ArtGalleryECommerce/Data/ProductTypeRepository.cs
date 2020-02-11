using ArtGalleryECommerce.Interface;
using ArtGalleryECommerce.Models;
using ArtGalleryECommerce.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtGalleryECommerce.Data
{
    public class ProductTypeRepository : IType
    {
        private Context context;
        public ProductTypeRepository(Context _context)
        {
            context = _context;
        }

        public IQueryable<ProductType> ProductTypes => context.ProductTypes;

        public bool AddProductType(ProductType productType)
        {
            context.ProductTypes.Add(productType);
            return (context.SaveChanges() > 0) ? true : false;
        }

        public bool DelProductType(ProductType productType)
        {
            context.ProductTypes.Remove(productType);
            return (context.SaveChanges() > 0) ? true : false;
        }

        public ProductType GetByID(int ID)
        {
            //ProductTypeViewModel type = new ProductTypeViewModel();
            //type.ProductTypeInstance = context.ProductTypes.Where(x => x.ID == ID).FirstOrDefault();
            var type = context.ProductTypes.Where(x => x.ID == ID).FirstOrDefault();
            return type;
        }


        public ProductTypeViewModel GetProductTypes()
        {
            ProductTypeViewModel ptvm = new ProductTypeViewModel();
            ptvm.ProductTypes = context.ProductTypes;
            return ptvm;
        }

        public ProductTypeViewModel GetProductTypes(int? ID)
        {
            ProductTypeViewModel ptvm = new ProductTypeViewModel();
            ptvm.ProductTypes = context.ProductTypes;
            ptvm.SelectedProductTypeID = (int)ID;
            ptvm.SelectedProductTypeName = context.ProductTypes.Where(x => x.ID == ID).FirstOrDefault().Type;
            return ptvm;
        }

        public bool UpdateProductType(ProductType productType)
        {
            context.ProductTypes.Update(productType);
            return (context.SaveChanges() > 0) ? true : false;
        }
    }
}
