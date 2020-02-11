using ArtGalleryECommerce.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtGalleryECommerce.Areas.Admin.ViewComponents
{
    public class ArtistAdminViewComponent : ViewComponent
    {
        private IArtist repo;
        public ArtistAdminViewComponent(IArtist _repo)
        {
            repo = _repo;
        }

        public IViewComponentResult Invoke(int? ID)
        {
            if (ID != null)
            {
                return View(repo.GetArtists(ID));
            }
            else
                return View(repo.GetArtists());
        }
    }
}
