using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ArtGalleryECommerce.Data;
using ArtGalleryECommerce.Interface;
using ArtGalleryECommerce.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;

namespace ArtGalleryECommerce
{
    public class Startup
    {
        private IConfiguration configuration;
        public Startup(IConfiguration _configuration)
        {
            configuration = _configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_2_1);

            services.AddTransient<IProduct, ProductRepository>();
            services.AddTransient<IArtist, ArtistRepository>();
            services.AddTransient<IType, ProductTypeRepository>();

            services.AddTransient<ICart, CartRepository>();
            services.AddTransient<IUser, UserRepository>();
            services.AddTransient<IUserCart, UserCartRepository>();
            services.AddTransient<IOrder, OrderRepository>();
            services.AddTransient<IOrderProduct, OrderProductRepository>();


            //var con = @"Server=DESKTOP-D4JGU1O\SQLEXPRESS;Database=ArtGalleryDb;User ID= sa;Password= 123456";
            //var con = @"Server=WISSEN\SQLEXPRESS;Database=ArtGalleryDb;User ID=sa;Password= 123456";
            services.AddDbContext<Context>(x => x.UseSqlServer(configuration.GetConnectionString("WissenConnection")));
            services.AddDbContext<ApplicationIdentityContext>(x => x.UseSqlServer(configuration.GetConnectionString("WissenConnection")));

            services.AddIdentity<ApplicationUser, IdentityRole>(options => {
                options.User.RequireUniqueEmail = true;//email uniq olsun mu
                options.User.AllowedUserNameCharacters = "abcçdefgğhıijklmnoöpqrsştuüvwxyzABCÇDEFGĞHIİJKLMNOÖPQRSŞTUÜVWXYZ-._@+0123456789;";
                

                options.Password.RequiredLength = 5;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireDigit = false;
                options.Password.RequireNonAlphanumeric = false;

                
            }).AddEntityFrameworkStores<ApplicationIdentityContext>().AddDefaultTokenProviders();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            SeedData.Seed(app);
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseStaticFiles(new StaticFileOptions { FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "node_modules")), RequestPath = "/modules" });

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
            name: "areas",
            template: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
          );
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
