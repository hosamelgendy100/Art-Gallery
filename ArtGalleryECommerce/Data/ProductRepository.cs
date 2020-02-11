using ArtGalleryECommerce.Interface;
using ArtGalleryECommerce.Models;
using ArtGalleryECommerce.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtGalleryECommerce.Data
{
    public class ProductRepository : IProduct
    {

        private Context context;
        public ProductRepository(Context _context)
        {
            context = _context;
        }


        public IQueryable<Product> Products => context.Products;
        public ProductViewModel GetProducts()
        {
            ProductViewModel pvm = new ProductViewModel();
            pvm.Products = context.Products;
            return pvm;
        }
        public ProductViewModel GetWithJoin()
        {

            ProductViewModel pvmMain = new ProductViewModel();

            var list = context.Products.Join(context.Artists, e => e.ArtistID, c => c.ID, (e, c) => new { ProductName = e.ProductName, ID = e.ID, ProductDescription = e.ProductDescription, Price = e.Price, ProductSize = e.ProductSize, Artist = c.Name + " " + c.Surname, ArtistID = e.ArtistID, ProductTypeID = e.ProductTypeID, Image = e.Image, IsActive = e.IsActive, CreationDate = e.CreationDate, ProductState = e.ProductState }).Join(context.ProductTypes, e => e.ProductTypeID, c => c.ID, (e, c) => new { ProductName = e.ProductName, ID = e.ID, ProductDescription = e.ProductDescription, Price = e.Price, ProductSize = e.ProductSize, Artist = e.Artist, ArtistID = e.ArtistID, ProductTypeID = e.ProductTypeID, ProductType = c.Type, Image = e.Image, IsActive = e.IsActive, CreationDate = e.CreationDate, ProductState = e.ProductState });

            List<ProductViewModel> pViewList = new List<ProductViewModel>();

            foreach (var item in list)
            {
                ProductViewModel pvm = new ProductViewModel();
                pvm.ID = item.ID;
                pvm.ProductName = item.ProductName;
                pvm.ProductDescription = item.ProductDescription;
                pvm.Price = item.Price;
                pvm.ProductSize = item.ProductSize;
                pvm.Artist = item.Artist;
                pvm.ProductType = item.ProductType;
                pvm.Image = item.Image;
                pvm.IsActive = item.IsActive;
                pvm.CreationDate = item.CreationDate;
                pvm.ArtistID = item.ArtistID;
                pvm.ProductTypeID = item.ProductTypeID;
                pvm.ProductState = item.ProductState;

                pViewList.Add(pvm);

            }


            pvmMain.ViewModelProducts = pViewList;
            return pvmMain;
        }

        public ProductViewModel GetActivesWithJoin()
        {
            ProductViewModel pvmMain = new ProductViewModel();

            var list = context.Products.Join(context.Artists, e => e.ArtistID, c => c.ID, (e, c) => new { ProductName = e.ProductName, ID = e.ID, ProductDescription = e.ProductDescription, Price = e.Price, ProductSize = e.ProductSize, Artist = c.Name + " " + c.Surname, ArtistID = e.ArtistID, ProductTypeID = e.ProductTypeID, Image = e.Image, IsActive = e.IsActive, CreationDate = e.CreationDate, ProductState = e.ProductState }).Join(context.ProductTypes, e => e.ProductTypeID, c => c.ID, (e, c) => new { ProductName = e.ProductName, ID = e.ID, ProductDescription = e.ProductDescription, Price = e.Price, ProductSize = e.ProductSize, Artist = e.Artist, ArtistID = e.ArtistID, ProductTypeID = e.ProductTypeID, ProductType = c.Type, Image = e.Image, IsActive = e.IsActive, CreationDate = e.CreationDate, ProductState = e.ProductState }).Where(x => x.IsActive == true && x.ProductState == Models.Common.Common.ProductState.Active);

            List<ProductViewModel> pViewList = new List<ProductViewModel>();

            foreach (var item in list)
            {
                ProductViewModel pvm = new ProductViewModel();
                pvm.ID = item.ID;
                pvm.ProductName = item.ProductName;
                pvm.ProductDescription = item.ProductDescription;
                pvm.Price = item.Price;
                pvm.ProductSize = item.ProductSize;
                pvm.Artist = item.Artist;
                pvm.ProductType = item.ProductType;
                pvm.Image = item.Image;
                pvm.IsActive = item.IsActive;
                pvm.CreationDate = item.CreationDate;
                pvm.ArtistID = item.ArtistID;
                pvm.ProductTypeID = item.ProductTypeID;
                pvm.ProductState = item.ProductState;

                pViewList.Add(pvm);

            }


            pvmMain.ViewModelActiveProducts = pViewList;
            return pvmMain;
        }

        public ProductViewModel GetInactivesWithJoin()
        {
            ProductViewModel pvmMain = new ProductViewModel();

            var list = context.Products.Join(context.Artists, e => e.ArtistID, c => c.ID, (e, c) => new { ProductName = e.ProductName, ID = e.ID, ProductDescription = e.ProductDescription, Price = e.Price, ProductSize = e.ProductSize, Artist = c.Name + " " + c.Surname, ArtistID = e.ArtistID, ProductTypeID = e.ProductTypeID, Image = e.Image, IsActive = e.IsActive, CreationDate = e.CreationDate, ProductState = e.ProductState }).Join(context.ProductTypes, e => e.ProductTypeID, c => c.ID, (e, c) => new { ProductName = e.ProductName, ID = e.ID, ProductDescription = e.ProductDescription, Price = e.Price, ProductSize = e.ProductSize, Artist = e.Artist, ArtistID = e.ArtistID, ProductTypeID = e.ProductTypeID, ProductType = c.Type, Image = e.Image, IsActive = e.IsActive, CreationDate = e.CreationDate, ProductState = e.ProductState }).Where(x => x.ProductState == Models.Common.Common.ProductState.Inactive);

            List<ProductViewModel> pViewList = new List<ProductViewModel>();

            foreach (var item in list)
            {
                ProductViewModel pvm = new ProductViewModel();
                pvm.ID = item.ID;
                pvm.ProductName = item.ProductName;
                pvm.ProductDescription = item.ProductDescription;
                pvm.Price = item.Price;
                pvm.ProductSize = item.ProductSize;
                pvm.Artist = item.Artist;
                pvm.ProductType = item.ProductType;
                pvm.Image = item.Image;
                pvm.IsActive = item.IsActive;
                pvm.CreationDate = item.CreationDate;
                pvm.ArtistID = item.ArtistID;
                pvm.ProductTypeID = item.ProductTypeID;
                pvm.ProductState = item.ProductState;

                pViewList.Add(pvm);

            }


            pvmMain.ViewModelActiveProducts = pViewList;
            return pvmMain;
        }

        public ProductViewModel GetSoldWithJoin()
        {
            ProductViewModel pvmMain = new ProductViewModel();

            var list = context.Products.Join(context.Artists, e => e.ArtistID, c => c.ID, (e, c) => new { ProductName = e.ProductName, ID = e.ID, ProductDescription = e.ProductDescription, Price = e.Price, ProductSize = e.ProductSize, Artist = c.Name + " " + c.Surname, ArtistID = e.ArtistID, ProductTypeID = e.ProductTypeID, Image = e.Image, IsActive = e.IsActive, CreationDate = e.CreationDate, ProductState = e.ProductState }).Join(context.ProductTypes, e => e.ProductTypeID, c => c.ID, (e, c) => new { ProductName = e.ProductName, ID = e.ID, ProductDescription = e.ProductDescription, Price = e.Price, ProductSize = e.ProductSize, Artist = e.Artist, ArtistID = e.ArtistID, ProductTypeID = e.ProductTypeID, ProductType = c.Type, Image = e.Image, IsActive = e.IsActive, CreationDate = e.CreationDate, ProductState = e.ProductState }).Where(x => x.ProductState == Models.Common.Common.ProductState.Sold);

            List<ProductViewModel> pViewList = new List<ProductViewModel>();

            foreach (var item in list)
            {
                ProductViewModel pvm = new ProductViewModel();
                pvm.ID = item.ID;
                pvm.ProductName = item.ProductName;
                pvm.ProductDescription = item.ProductDescription;
                pvm.Price = item.Price;
                pvm.ProductSize = item.ProductSize;
                pvm.Artist = item.Artist;
                pvm.ProductType = item.ProductType;
                pvm.Image = item.Image;
                pvm.IsActive = item.IsActive;
                pvm.CreationDate = item.CreationDate;
                pvm.ArtistID = item.ArtistID;
                pvm.ProductTypeID = item.ProductTypeID;
                pvm.ProductState = item.ProductState;

                pViewList.Add(pvm);

            }


            pvmMain.ViewModelActiveProducts = pViewList;
            return pvmMain;
        }


        public ProductViewModel GetByArtist(int artistId)
        {
            ProductViewModel pvmMain = new ProductViewModel();

            var list = context.Products.Join(context.Artists, e => e.ArtistID, c => c.ID, (e, c) => new { ProductName = e.ProductName, ID = e.ID, ProductDescription = e.ProductDescription, Price = e.Price, ProductSize = e.ProductSize, Artist = c.Name + " " + c.Surname, ArtistID = e.ArtistID, ProductTypeID = e.ProductTypeID, Image = e.Image, IsActive = e.IsActive, CreationDate = e.CreationDate, ProductState = e.ProductState }).Join(context.ProductTypes, e => e.ProductTypeID, c => c.ID, (e, c) => new { ProductName = e.ProductName, ID = e.ID, ProductDescription = e.ProductDescription, Price = e.Price, ProductSize = e.ProductSize, Artist = e.Artist, ArtistID = e.ArtistID, ProductTypeID = e.ProductTypeID, ProductType = c.Type, Image = e.Image, IsActive = e.IsActive, CreationDate = e.CreationDate, ProductState = e.ProductState }).Where(x => x.ArtistID == artistId && x.ProductState == Models.Common.Common.ProductState.Active);

            List<ProductViewModel> pViewList = new List<ProductViewModel>();

            foreach (var item in list)
            {
                ProductViewModel pvm = new ProductViewModel();
                pvm.ID = item.ID;
                pvm.ProductName = item.ProductName;
                pvm.ProductDescription = item.ProductDescription;
                pvm.Price = item.Price;
                pvm.ProductSize = item.ProductSize;
                pvm.Artist = item.Artist;
                pvm.ProductType = item.ProductType;
                pvm.Image = item.Image;
                pvm.IsActive = item.IsActive;
                pvm.CreationDate = item.CreationDate;
                pvm.ArtistID = item.ArtistID;
                pvm.ProductTypeID = item.ProductTypeID;
                pvm.ProductState = item.ProductState;

                pViewList.Add(pvm);

            }
            pvmMain.ViewModelActiveProducts = pViewList;
            return pvmMain;
        }

        public bool AddProduct(Product product)
        {
            //product.IsActive = true;
            //product.CreationDate = DateTime.Now;
            context.Products.Add(product);
            return (context.SaveChanges() > 0) ? true : false;
        }



        public bool DelProduct(Product product)
        {
            //product.IsActive = false;
            context.Products.Remove(product);
            return (context.SaveChanges() > 0) ? true : false;
        }



        public bool UpdateProduct(Product product)
        {
            //SetEqualToInstance(product);
            context.Products.Update(product);
            return (context.SaveChanges() > 0) ? true : false;
        }

        IEnumerable<ProductViewModel> IProduct.GetByFilters(string Id, string name, string shortName, float? price)
        {
            throw new NotImplementedException();
        }

        public Product GetByID(int ID)
        {
            //ProductViewModel product = new ProductViewModel();
            //product.ProductInstance = context.Products.Where(x => x.ID == ID).FirstOrDefault();
            var product = context.Products.Where(x => x.ID == ID).FirstOrDefault();
            return product;
        }

        private void SetEqualToInstance(ProductViewModel product)
        {
            product.ProductInstance.ID = product.ID;
            product.ProductInstance.ProductName = product.ProductName;
            product.ProductInstance.ProductDescription = product.ProductDescription;
            product.ProductInstance.Price = product.Price;
            product.ProductInstance.ProductSize = product.ProductSize;
            product.ProductInstance.ArtistID = product.ArtistID;
            product.ProductInstance.Image = product.Image;
            product.ProductInstance.IsActive = product.IsActive;
            product.ProductInstance.ProductTypeID = product.ProductTypeID;
            product.ProductInstance.CreationDate = product.CreationDate;

        }


    }
}
