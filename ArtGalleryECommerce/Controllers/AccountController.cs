using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using ArtGalleryECommerce.Interface;
using ArtGalleryECommerce.Models;
using ArtGalleryECommerce.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ArtGalleryECommerce.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private UserManager<ApplicationUser> userManager;
        private SignInManager<ApplicationUser> signInManager;
        private IProduct repo;
        private IUser repoUser;
        private IOrderProduct repoOrderProduct;

        public AccountController(UserManager<ApplicationUser> _userManager, SignInManager<ApplicationUser> _signInManager, IProduct _repo, IUser _repoUser, IOrderProduct _repoOrderProduct)
        {
            userManager = _userManager;
            signInManager = _signInManager;
            repo = _repo;
            repoUser = _repoUser;
            repoOrderProduct = _repoOrderProduct;
        }

        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult Login(string returnUrl)
        {
            ViewBag.returnUrl = returnUrl;
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByEmailAsync(model.Email);
                if (user != null)
                {
                    await signInManager.SignOutAsync();
                    var result = await signInManager.PasswordSignInAsync(user, model.Password, false, false);
                    if (result.Succeeded)
                    {
                        UserCartViewModel.UserAccountID = repoUser.GetIdByGuid(user.Id);
                        LoginModel.DidLoggedIn = true;
                        if (returnUrl == null)
                        {
                            return RedirectToAction("Index", "Common");
                        }else return RedirectToLocal(returnUrl);


                    }
                }
                ModelState.AddModelError("Email", "Invalid Email or Password");
            }
            return View(model);
        }

        public IActionResult UserArea()
        {
            var userId = repoUser.GetIdByGuid(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            return View(repoOrderProduct.GetOrdersByUserWithJoin(userId));
        }
        public IActionResult OrderDetails(int orderId)
        {
            return View(repoOrderProduct.GetOrderDetails(orderId));
        }

        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            LoginModel.DidLoggedIn = false;
            UserCartViewModel.UserAccountID = 0;
            return RedirectToAction("LogoutView", "Common");
        }

        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            return RedirectToAction("Index", "Home", repo.GetActivesWithJoin());
        }
    }
}