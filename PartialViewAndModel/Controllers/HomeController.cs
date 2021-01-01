using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PartialViewAndModel.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PartialViewAndModel.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult _partialViews()
        {
            return View();
        }
        public IActionResult Login(Models.UserClass user)
        {
            var user1 = new Models.UserClass();
            user1.ad = "Zeynep";
            user1.soyad = "Çelik";
            user1.sifre = "12345";
            return View(user1);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
