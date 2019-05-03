using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Pcf.Dotnet.Core.Intro.Models;
using System;
using System.Net;
using System.Runtime.InteropServices;

namespace Pcf.Dotnet.Core.Intro.Controllers
{
    public class DetailsController : Controller
    {
        private readonly IConfiguration configuration;

        public DetailsController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public IActionResult Index()
        {
            // environment variables
            var vcap_application = configuration["VCAP_APPLICATION"];

            var application = JsonConvert.DeserializeObject<Application>(vcap_application);

            var uris = String.Empty;
            foreach(var uri in application.uris)
            {
                uris += uri + ", ";
            }

            uris = uris.TrimEnd(' ', ',');

            ViewBag.Uris = uris;

            // runtime details
            ViewBag.OSDescription = RuntimeInformation.OSDescription;

            // host
            var hostname = Dns.GetHostName();
            var hostAddresses = Dns.GetHostAddresses(hostname);

            var addresses = String.Empty;
            foreach(var hostAddress in hostAddresses)
            {
                addresses += hostAddress.ToString() + ", ";
            }

            addresses = addresses.TrimEnd(' ', ',');

            ViewBag.HostName = hostname;
            ViewBag.HostAddress = addresses;

            return View(application);
        }
    }
}