using Microsoft.AspNetCore.Mvc;

namespace İntProgÖdev.Controllers
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