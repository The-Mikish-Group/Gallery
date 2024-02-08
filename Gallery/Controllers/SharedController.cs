using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Gallery.Models;
using System.Diagnostics;
using System.IO;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Gallery.Controllers
{
    public class CombosController : Controller // Combos Controller
    {
        protected IActionResult CustomView(string viewName)
        {
            ViewData["ViewName"] = viewName;
            return View("Galleries");
        }
        public IActionResult Index() => CustomView("Combos");
    }
    public class SlideshowsController : Controller  //Slideshows Controller
    {
        protected IActionResult CustomView(string viewName)
        {
            ViewData["ViewName"] = viewName;
            return View("Galleries");
        }
        public IActionResult Index() => CustomView("Slideshows");
    }
    public class GalleriesController : Controller  // Galleries Controller
    {
        protected IActionResult CustomView(string viewName)
        {
            ViewData["ViewName"] = viewName;
            return View("Galleries");
        }
        public IActionResult Index() => CustomView("Galleries");
    }

    // Gallery Base Controller
    public class GalleryBaseController : Controller
    {
        public IActionResult Index() => GalleryView();
        public IActionResult Gallery(string viewName) => GalleryView(viewName);
        protected IActionResult GalleryView(string imagefolder = "Gallery")
        {
            ViewData["ViewName"] = imagefolder;
            return View();
        }
    }


    // One Gallery
    // To add a new Gallery, copy these three lines and
    // rename to the new gallery name.
    public class KPHS68Controller : GalleryBaseController { }    
    public class KPHS68SlideController : GalleryBaseController { }
    public class KPHS68ComboController : GalleryBaseController { }
}
