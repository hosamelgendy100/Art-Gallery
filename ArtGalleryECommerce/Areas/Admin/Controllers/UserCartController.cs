using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArtGalleryECommerce.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ArtGalleryECommerce.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class UserCartController : Controller
    {
        private IUserCart repo;
        public UserCartController(IUserCart _repo)
        {
            repo = _repo;
        }
        public IActionResult Index()
        {

            return View(repo.GetUsersInUserCart());
        }
        public IActionResult Details(int userId)
        {
            return View(repo.GetCartOfUser(userId));
        }
    }
}