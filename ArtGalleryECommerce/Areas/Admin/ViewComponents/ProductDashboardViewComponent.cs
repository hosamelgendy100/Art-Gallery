using ArtGalleryECommerce.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtGalleryECommerce.Areas.Admin.ViewComponents
{
    public class ProductDashboardViewComponent : ViewComponent
    {
        private IProduct repo;
        public ProductDashboardViewComponent(IProduct _repo)
        {
            repo = _repo;
        }
        public IViewComponentResult Invoke()
        {
            return View(repo.GetWithJoin());
        }
    }
}
