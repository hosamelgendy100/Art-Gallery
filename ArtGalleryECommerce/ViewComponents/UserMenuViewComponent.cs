using ArtGalleryECommerce.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtGalleryECommerce.ViewComponents
{
    public class UserMenuViewComponent : ViewComponent
    {
        private IUser repo;
        public UserMenuViewComponent(IUser _repo)
        {
            repo = _repo;
        }

        public IViewComponentResult Invoke()
        {

            return View(repo.GetUsers());
        }
    }
}
