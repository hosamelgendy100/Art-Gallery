using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArtGalleryECommerce.Models.ViewModels;

namespace ArtGalleryECommerce.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserCart> UserCarts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
        public DbSet<ArtGalleryECommerce.Models.ViewModels.ProductViewModel> ProductViewModel { get; set; }
        public DbSet<ArtGalleryECommerce.Models.ViewModels.ProductTypeViewModel> ProductTypeViewModel { get; set; }
        //public DbSet<ArtGalleryECommerce.Models.ViewModels.OrderViewModel> OrderViewModel { get; set; }
        //public DbSet<ArtGalleryECommerce.Models.ViewModels.OrderProductViewModel> OrderProductViewModel { get; set; }
        //public DbSet<ArtGalleryECommerce.Models.ViewModels.OrderProductViewModel> OrderProductViewModel { get; set; }
        //public DbSet<ArtGalleryECommerce.Models.ViewModels.OrderProductViewModel> OrderProductViewModel { get; set; }

        
    }
}
