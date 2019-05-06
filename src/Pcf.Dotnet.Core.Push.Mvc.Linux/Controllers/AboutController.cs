using Microsoft.AspNetCore.Mvc;

namespace Pcf.Dotnet.Core.Push.Mvc.Linux.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}