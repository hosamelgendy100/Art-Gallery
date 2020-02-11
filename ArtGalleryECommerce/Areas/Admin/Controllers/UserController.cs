using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArtGalleryECommerce.Interface;
using ArtGalleryECommerce.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ArtGalleryECommerce.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class UserController : Controller
    {
        private IUser repo;
        private UserManager<ApplicationUser> userManager;

        private IPasswordValidator<ApplicationUser> passwordValidator;
        private IPasswordHasher<ApplicationUser> passwordHasher;

        public UserController(IUser _repo, UserManager<ApplicationUser> _userManager, IPasswordValidator<ApplicationUser> _passwordValidator, IPasswordHasher<ApplicationUser> _passwordHasher)
        {
            repo = _repo;
            userManager = _userManager;
            passwordValidator = _passwordValidator;
            passwordHasher = _passwordHasher;
        }
        public IActionResult Index()
        {
            return View(repo.GetUsers());
        }
        public IActionResult Edit(int Id)
        {
            return View(repo.GetByID(Id));
        }
        [HttpPost]
        public async Task<IActionResult> Edit(User user)
        {
            var userAsp = await userManager.FindByIdAsync(user.Guid);

            if (userAsp != null)
            {
                userAsp.Email = user.EMail;
                userAsp.UserName = user.EMail;
                userAsp.PhoneNumber = user.PhoneNumber;
                IdentityResult validPassword = null;
                if (!String.IsNullOrEmpty(user.Password))
                {
                    validPassword = await passwordValidator.ValidateAsync(userManager, userAsp, user.Password);
                    if (validPassword.Succeeded)
                    {
                        userAsp.PasswordHash = passwordHasher.HashPassword(userAsp, user.Password);
                    }
                }
                else
                {
                    foreach (var item in validPassword.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
                if (validPassword.Succeeded)
                {
                    var result = await userManager.UpdateAsync(userAsp);
                    repo.UpdateUser(user);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", repo.GetUsers());
                    }
                    else
                    {
                        foreach (var item in result.Errors)
                        {
                            ModelState.AddModelError("", item.Description);
                        }
                    }
                }
            }
            else
            {
                ModelState.AddModelError("", "User Not Found");
            }
            
            return View("Index", repo.GetUsers());
        }
        public IActionResult Details(int Id)
        {
            
            return View(repo.GetByID(Id));
        }
        public IActionResult Delete(int Id)
        {
            return View(repo.GetByID(Id));
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int Id,User userNull)
        {
            if (Id != 0)
            {
                var user = repo.GetByID(Id);
                var userAsp = await userManager.FindByIdAsync(user.Guid);
                var result = await userManager.DeleteAsync(userAsp);
                if (result.Succeeded)
                {
                    repo.DelUser(user);
                    return RedirectToAction("Index", repo.GetUsers());
                }
                //else
                //{
                //    foreach (var item in result.Errors)
                //    {
                //        ModelState.AddModelError("", item.Description);
                //    }
                //}
            }
            
            return View("Index", repo.GetUsers());
        }
    }
}