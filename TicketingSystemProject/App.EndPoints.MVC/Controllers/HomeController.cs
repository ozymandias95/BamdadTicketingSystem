using App.EndPoints.MVC.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System.Data;
using System.Diagnostics;
using System.Security.Claims;
using App.Infra.Data.Db.SqlServer.Ef.DbCtx;

namespace App.EndPoints.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IMemoryCache _memoryCache;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly IWebHostEnvironment _environment;
        private readonly IConfiguration _configuration;

        public HomeController(ILogger<HomeController> logger, IWebHostEnvironment environment, IConfiguration configuration, RoleManager<ApplicationRole> roleManager, IMemoryCache memoryCache, UserManager<ApplicationUser> userManager)
        {
            _logger = logger;
            _environment = environment;
            _configuration = configuration;
            _roleManager = roleManager;
            _memoryCache = memoryCache;
            _userManager = userManager;
        }

        public async Task SeedData()
        {
            if (_environment.IsDevelopment())
            {
                await _roleManager.CreateAsync(new ApplicationRole
                {
                    Name = "Admin",
                    NameFa = "ادمین",
                });

                await _roleManager.CreateAsync(new ApplicationRole
                {
                    Name = "Support",
                    NameFa = "پشتیبان",
                });
                await _roleManager.CreateAsync(new ApplicationRole
                {
                    Name = "User",
                    NameFa = "کاربر",
                });

                var adminUser = new ApplicationUser
                {
                    UserName = "admin",
                    Email = "admin@bamdad.ir"
                };

                var result = await _userManager.CreateAsync(adminUser, "1234567Ab@");

                if (result.Succeeded)
                {
                    var role = await _roleManager.FindByNameAsync("Admin");
                    var result2 = await _userManager.AddToRoleAsync(adminUser, role.Name);
                }
                // List<Claim> claims = new List<Claim>()
                //{
                //    new Claim(ClaimTypes.Name,"Ali")
                //};

                // var identity = new ClaimsIdentity(claims,"MyClaim");
                // ClaimsPrincipal principal = new ClaimsPrincipal(identity);
                // HttpContext.SignInAsync("MyClaim",principal);
            }
        }

        public IActionResult Index()
        {
            //ViewData["Title"] = "Home";
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
