using ArtGalleryECommerce.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtGalleryECommerce.ViewComponents
{
    public class ModalViewComponent : ViewComponent
    {
        //private int ID;
        //private ProductViewModel product;
        //public ModalViewComponent(int _ID, ProductViewModel _product)
        //{
        //    ID = _ID;
        //    product = _product;
        //}


        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
