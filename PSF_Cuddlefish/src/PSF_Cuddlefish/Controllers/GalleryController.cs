using Microsoft.AspNetCore.Mvc;

namespace PSF_Cuddlefish.Controllers
{
    public class GalleryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}