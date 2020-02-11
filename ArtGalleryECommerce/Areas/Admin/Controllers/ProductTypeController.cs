using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArtGalleryECommerce.Interface;
using ArtGalleryECommerce.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ArtGalleryECommerce.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class ProductTypeController : Controller
    {
        private IType repo;
        public ProductTypeController(IType _repo)
        {
            repo = _repo;
        }
        public IActionResult Index()
        {
            return View(repo.GetProductTypes());
        }

        public IActionResult Create()
        {

            return View(repo.GetProductTypes());
        }

        [HttpPost]
        public IActionResult Create(ProductType product)
        {
            repo.AddProductType(product);
            
            return View("Index", repo.GetProductTypes());
        }

        public IActionResult Delete(int Id)
        {
            return View(repo.GetByID(Id));
        }

        [HttpPost]
        public IActionResult Delete(ProductType product)
        {
            repo.DelProductType(product);
            return View("Index", repo.GetProductTypes());
        }

        public IActionResult Edit(int Id)
        {
            return View(repo.GetByID(Id));
        }

        [HttpPost]
        public IActionResult Edit(ProductType productType)
        {
            repo.UpdateProductType(productType);
            return View("Index", repo.GetProductTypes());
        }

        public IActionResult Details(int Id)
        {
            return View(repo.GetByID(Id));
        }
    }
}