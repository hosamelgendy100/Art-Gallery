using ArtGalleryECommerce.Interface;
using ArtGalleryECommerce.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtGalleryECommerce.ViewComponents
{
    public class CartMenuViewComponent : ViewComponent
    {
        private IUserCart repo;
        public CartMenuViewComponent(IUserCart _repo)
        {
            repo = _repo;
        }
        public IViewComponentResult Invoke()
        {
            return View(repo.GetWithJoin(UserCartViewModel.UserAccountID));
        }
    }
}
