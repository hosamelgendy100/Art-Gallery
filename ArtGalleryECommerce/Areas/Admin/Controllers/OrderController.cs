using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using ArtGalleryECommerce.Interface;
using ArtGalleryECommerce.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static ArtGalleryECommerce.Models.Common.Common;

namespace ArtGalleryECommerce.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class OrderController : Controller
    {
        private IOrderProduct repo;
        private IOrder repoOrder;
        public OrderController(IOrderProduct _repo, IOrder _repoOrder)
        {
            repo = _repo;
            repoOrder = _repoOrder;
        }
        public IActionResult Index()
        {
            return View(repo.GetActivesWithJoin());
        }
        public IActionResult CompletedOrders()
        {
            return View(repo.GetCompletedWithJoin());
        }
        public IActionResult CanceledOrders()
        {
            return View(repo.GetCanceledWithJoin());
        }
        public IActionResult SetCompleteOrderDetail(int orderID)
        {
           
            return View(repo.GetByViewID(orderID));
        }

        [HttpPost]
        public IActionResult SetCompleteOrder(int orderID)
        {
            repoOrder.CompleteOrder(orderID);
            var user = repoOrder.GetUserByOrderId(orderID);
            SendOrderStatusUpdateMail(user.EMail, user.Name, OrderState.Completed);
            return View("Index", repo.GetActivesWithJoin());
        }
        public IActionResult SetCancelOrderDetail(int orderID)
        {
            
            return View(repo.GetByViewID(orderID));
        }
        public IActionResult SetCancelOrder(int orderID)
        {
            repoOrder.CancelOrder(orderID);
            var user = repoOrder.GetUserByOrderId(orderID);
            if (user != null)
            {
                SendOrderStatusUpdateMail(user.EMail, user.Name, OrderState.Canceled);
            }
            
            return View("Index", repo.GetActivesWithJoin());
        }
        public IActionResult SetActiveOrder(int orderID)
        {
            repoOrder.ActivateOrder(orderID);
            var user = repoOrder.GetUserByOrderId(orderID);
            SendOrderStatusUpdateMail(user.EMail, user.Name, OrderState.Active);
            return View("Index", repo.GetActivesWithJoin());
        }
        public IActionResult Edit(int orderId)
        {

            return View(repoOrder.GetByID(orderId));
        }

        [HttpPost]
        public IActionResult Edit(Order order)
        {
            repoOrder.UpdateOrder(order);
            return View("Index", repo.GetActivesWithJoin());
        }

        public IActionResult Details(int orderId)
        {
            //var a = repo.GetOrderDetails(orderId);
            return View(repo.GetOrderDetails(orderId));
        }

        private void SendOrderStatusUpdateMail(string email, string name, OrderState orderState)
        {
            var fromAddress = new MailAddress("artgalleryproject1001@gmail.com", "no-reply");
            var toAddress = new MailAddress(email, name);
            const string fromPassword = "51348790";
            const string subject = "no-reply";
            string body = $"Dear {name},\nYour order status has been set as {orderState}";

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