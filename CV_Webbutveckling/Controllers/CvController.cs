using Microsoft.AspNetCore.Mvc;
using CV_Webbutveckling.Models;

namespace CV_Webbutveckling.Controllers
{
    public class CvController : Controller
    {
        public IActionResult OmMig()
        {
            return View();
        }

        public IActionResult Erfarenhet()
        {
            return View();
        }

        public IActionResult Utbildning()
        {
            return View();
        }

        public IActionResult Kontakt()
        {
            return View();
        }

        public IActionResult personligtBrev()
        {
            return View();
        }
    }
}
