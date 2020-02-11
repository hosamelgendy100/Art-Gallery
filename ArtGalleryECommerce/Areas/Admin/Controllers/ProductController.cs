using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArtGalleryECommerce.Interface;
using ArtGalleryECommerce.Models;
using ArtGalleryECommerce.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ArtGalleryECommerce.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class ProductController : Controller
    {
        IProduct repo;
        public ProductController(IProduct _repo)
        {
            repo = _repo;
        }
        public IActionResult Index()
        {
            return View(repo.GetActivesWithJoin());
        }

        public IActionResult InactiveProducts()
        {
            return View(repo.GetInactivesWithJoin());
        }

        public IActionResult SoldProducts()
        {
            return View(repo.GetSoldWithJoin());
        }

        public IActionResult Create()
        {

            return View(repo.GetActivesWithJoin());
        }


        [HttpPost]
        public IActionResult Create(ProductViewModel product)
        {


            repo.AddProduct(product);
            //ViewData["Message"] = "Ürün başarıyla eklendi.";


            return View("Index", repo.GetActivesWithJoin());
        }


        public IActionResult Delete(int Id)
        {
            return View(repo.GetByID(Id));
        }

        [HttpPost]
        public IActionResult Delete(ProductViewModel product)
        {
            repo.DelProduct(product);
            return View("Index", repo.GetActivesWithJoin());
        }

        public IActionResult Edit(int Id)
        {
            var product = repo.GetByID(Id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {

            repo.UpdateProduct(product);
            return View("Index", repo.GetActivesWithJoin());
        }

        public IActionResult Details(int Id)
        {
            var product = repo.GetByID(Id);
            return View(product);
        }
    }
}