using Gallery.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Gallery.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Message = "Galleries";
            return View();        
        }

        public IActionResult Contact()
        {
            ViewBag.Message = "Contact";
            return View();
        }
        public IActionResult TOS()
        {
            ViewBag.Message = "TOS";
            return View();
        }
        public IActionResult Privacy()
        {
            ViewBag.Message = "Privacy";
            return View();
        }
        public IActionResult Classmates()
        {
            ViewBag.Message = "Classmates";
            return View();
        }
        public IActionResult Links()
        {
            ViewBag.Message = "Links";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
