using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArtGalleryECommerce.Interface;
using ArtGalleryECommerce.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ArtGalleryECommerce.Controllers
{
    [Authorize]
    public class CartController : Controller
    {
        private IUserCart repo;
        public CartController(IUserCart _repo)
        {
            repo = _repo;
        }
        public IActionResult Index()
        {
            return View(repo.GetWithJoin(UserCartViewModel.UserAccountID));
        }

        public IActionResult DeleteFromCart(int productID)
        {
            repo.DeleteFromCart(productID);
            return View("Index", repo.GetWithJoin(UserCartViewModel.UserAccountID));
        }
       
    }
}