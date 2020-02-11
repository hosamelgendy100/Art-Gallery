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
    public class ArtistController : Controller
    {
        private IArtist repo;
        public ArtistController(IArtist _repo)
        {
            repo = _repo;
        }
        public IActionResult Index()
        {
            return View(repo.GetArtists());
        }

        public IActionResult Create()
        {

            return View(repo.GetArtists());
        }
        
        [HttpPost]
        public IActionResult Create(Artist artist)
        {
            repo.AddArtist(artist);

            return View("Index", repo.GetArtists());
        }

        public IActionResult Delete(int Id)
        {
            return View(repo.GetByID(Id));
        }

        [HttpPost]
        public IActionResult Delete(Artist artist)
        {
            repo.DelArtist(artist);
            return View("Index", repo.GetArtists());
        }

        public IActionResult Edit(int Id)
        {
            
            return View(repo.GetByID(Id));
        }

        [HttpPost]
        public IActionResult Edit(Artist product)
        {
            repo.UpdateArtist(product);
            return View("Index", repo.GetArtists());
        }

        public IActionResult Details(int Id)
        {
            return View(repo.GetByID(Id));
        }
    }
}