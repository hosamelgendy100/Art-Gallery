using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
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
    public class HomeController : Controller
    {
        
        private IProduct repo;
        private IUserCart repoUserCart;
        private IUser repoUser;
        private UserManager<ApplicationUser> userManager;

        public HomeController(IProduct _repo, IUserCart _repoUserCart, IUser _repoUser, UserManager<ApplicationUser> _userManager)
        {
            repo = _repo;
            repoUserCart = _repoUserCart;
            repoUser = _repoUser;
            userManager = _userManager;
        }
        [AllowAnonymous]
        public IActionResult Index()
        {

            //var user = User.Identity.Name;
            //var b = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            if (User.Identity.Name != null)
            {
                var a = repoUser.GetIdByGuid(User.FindFirst(ClaimTypes.NameIdentifier).Value);

                if (repoUser.GetIdByGuid(User.FindFirst(ClaimTypes.NameIdentifier).Value) != 0)
                {
                    UserCartViewModel.UserAccountID = repoUser.GetIdByGuid(User.FindFirst(ClaimTypes.NameIdentifier).Value);
                }
            }
            var product = repo.GetActivesWithJoin();

            return View(product);
        }
        [AllowAnonymous]
        public IActionResult SetCategory(int artistId)
        {

            return View("Index", repo.GetByArtist(artistId));
        }

        [AllowAnonymous]
        public IActionResult SetUser(int userID)
        {
            UserCartViewModel.UserAccountID = userID;
            //ViewBag.UserID = userID;
            return View("Index",repo.GetActivesWithJoin());
        }

        public IActionResult AddToCart(int productID)
        {
            
            repoUserCart.AddUserCart(productID);
            return View("Index", repo.GetActivesWithJoin());
        }

        public IActionResult DeleteFromCart(int productID)
        {
            repoUserCart.DeleteFromCart(productID);
            return View("Index", repo.GetActivesWithJoin());
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> AddUser(User user)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser au = new ApplicationUser();
                au.Email = user.EMail;
                au.UserName = user.Name + ";" + Guid.NewGuid();
                au.PhoneNumber = user.PhoneNumber;
                

                var result = await userManager.CreateAsync(au, user.Password);

                if (result.Succeeded)
                {
                    user.Guid = au.Id;
                    repoUser.AddUser(user);
                    SendNewAccMail(user.EMail, user.Name, user.Password);
                    return RedirectToAction("NewRegistrationView", "Common");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                    return RedirectToAction("Error", "Common");
                }
            }
            
            return View("Index", repo.GetActivesWithJoin());
        }

        private void SendNewAccMail(string email, string name, string password)
        {
            var fromAddress = new MailAddress("artgalleryproject1001@gmail.com", "no-reply");
            var toAddress = new MailAddress(email, name);
            const string fromPassword = "51348790";
            const string subject = "no-reply";
            string body = $"Welcome to 1001Gallery {name}. Your registration is successfully completed and activated.\n\nYour account informations\nEmail: {email}\nPassword: {password}";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        }
       
    }
}

