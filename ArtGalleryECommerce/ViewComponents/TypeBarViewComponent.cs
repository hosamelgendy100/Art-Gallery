using ArtGalleryECommerce.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtGalleryECommerce.ViewComponents
{
    public class TypeBarViewComponent : ViewComponent
    {
        private IType repo;
        public TypeBarViewComponent(IType _repo)
        {
            repo = _repo;
        }
        public IViewComponentResult Invoke()
        {
            return View(repo.GetProductTypes());
        }
    }
}
