using Microsoft.AspNetCore.Mvc;

namespace Pcf.Dotnet.Core.Intro.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}