using Microsoft.AspNetCore.Mvc;

namespace Sube2.HelloMvc.Controllers
{
    public class OgretmenController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ViewResult OgretmenListe()
        {
            return View();
        }
    }
}