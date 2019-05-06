using Microsoft.AspNetCore.Mvc;
using Pcf.Dotnet.Core.Push.Mvc.Linux.Models;
using System.Diagnostics;

namespace Pcf.Dotnet.Core.Push.Mvc.Linux.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}