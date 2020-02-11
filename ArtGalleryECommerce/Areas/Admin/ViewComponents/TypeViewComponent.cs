using ArtGalleryECommerce.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtGalleryECommerce.Areas.Admin.ViewComponents
{
    public class TypeViewComponent : ViewComponent
    {
        private IType repo;
        public TypeViewComponent(IType _repo)
        {
            repo = _repo;
        }

        public IViewComponentResult Invoke(int? ID)
        {
            if (ID != null)
            {
                return View(repo.GetProductTypes(ID));
            }else
            return View(repo.GetProductTypes());
        }
    }
}
