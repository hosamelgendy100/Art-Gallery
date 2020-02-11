using ArtGalleryECommerce.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtGalleryECommerce.ViewComponents
{
    public class LoginModalViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(new LoginModel());
        }
    }
}
