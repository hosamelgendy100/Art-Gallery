using ArtGalleryECommerce.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtGalleryECommerce.ViewComponents
{
    public class ArtistViewComponent : ViewComponent
    {
        private IArtist repo;
        public ArtistViewComponent(IArtist _repo)
        {
            repo = _repo;
        }
        public IViewComponentResult Invoke()
        {
            
            return View(repo.GetArtists());
        }
    }
}
