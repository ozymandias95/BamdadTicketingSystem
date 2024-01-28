using App.EndPoints.MVC.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Claims;

namespace App.EndPoints.MVC.Controllers
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

           // List<Claim> claims = new List<Claim>()
           //{
           //    new Claim(ClaimTypes.Name,"Ali")
           //};

           // var identity = new ClaimsIdentity(claims,"MyClaim");
           // ClaimsPrincipal principal = new ClaimsPrincipal(identity);
           // HttpContext.SignInAsync("MyClaim",principal);
            return View();
        }

        public IActionResult Privacy()
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
