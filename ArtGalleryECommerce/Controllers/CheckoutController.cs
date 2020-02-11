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
using Microsoft.AspNetCore.Mvc;

namespace ArtGalleryECommerce.Controllers
{
    [Authorize]
    public class CheckoutController : Controller
    {
        private IOrder repo;
        private ICart repoCart;
        private IUserCart repoUserCart;
        private IProduct repoProduct;
        private IUser repoUser;
        public CheckoutController(IOrder _repo, ICart _repoCart, IUserCart _repoUserCart, IProduct _repoProduct, IUser _repoUser)
        {
            repo = _repo;
            repoCart = _repoCart;
            repoUserCart = _repoUserCart;
            repoProduct = _repoProduct;
            repoUser = _repoUser;
        }
        public IActionResult Index()
        {
            //var mail = User.FindFirstValue(ClaimTypes.Email);
            //var name = User.FindFirstValue(ClaimTypes.Name);
            var order = new OrderViewModel();
            order.CartID = repoCart.GetCartID(UserCartViewModel.UserAccountID);
            //order.UserID = UserCartViewModel.UserAccountID;
            order.TotalPrice = repoUserCart.GetTotalPrice(UserCartViewModel.UserAccountID);
            return View(order);
        }

        [HttpPost]
        public IActionResult NewOrder(Order order)
        {
            //order.CartID = repoCart.GetCartID(UserCartViewModel.UserAccountID);
            //order.TotalPrice = repoUserCart.GetTotalPrice(UserCartViewModel.UserAccountID);
            //if (repo.AddOrder(order))
            //{
                repo.AddOrder(order);
                SendNewOrderMail(order.ID);
                if (User.Identity.Name != order.ShipEMail)
                {
                    SendNewOrderMail(order.ShipEMail, order.ShipName, order.ID);
                    
                }

                return RedirectToAction("OrderReceived", "Common");

            //}
            //else
            //{
            //    return RedirectToAction("Error", "Common");
            //}

            //return RedirectToAction("Index", "Home", repoProduct.GetActivesWithJoin());
        }

        private void SendNewOrderMail(int orderId)
        {
            var fromAddress = new MailAddress("artgalleryproject1001@gmail.com", "no-reply");
            var toAddress = new MailAddress(repoUser.GetMailByGuid(User.FindFirst(ClaimTypes.NameIdentifier).Value), User.FindFirstValue(ClaimTypes.Name));
            const string fromPassword = "51348790";
            const string subject = "no-reply";
            string body = $"Your -{orderId}- numbered order has been received to us. Please contact wih us if you have request about your order";

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

        private void SendNewOrderMail(string email, string name, int orderId)
        {
            var fromAddress = new MailAddress("artgalleryproject1001@gmail.com", "no-reply");
            var toAddress = new MailAddress(email, name);
            const string fromPassword = "51348790";
            const string subject = "no-reply";
            string body = $"Your -{orderId}- numbered order has been received to us. Please contact wih us if you have request about your order";

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