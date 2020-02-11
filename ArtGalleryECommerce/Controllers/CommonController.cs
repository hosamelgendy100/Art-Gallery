using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ArtGalleryECommerce.Controllers
{
    public class CommonController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.userName = this.User.Identity.Name;
            return View();
        }

        public IActionResult NewRegistrationView()
        {
            return View();
        }

        public IActionResult LogoutView()
        {
            return View();
        }

        public IActionResult OrderReceived()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}