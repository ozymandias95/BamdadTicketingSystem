using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace App.EndPoints.MVC.Areas.UserArea.Controllers;

[Area("User")]
public class HomeController : Controller
{
    //[Route("dashboard")]
    //[Authorize(Roles = "User")]
    [AllowAnonymous]
    public IActionResult Index()
    {
        
        ViewData["Title"] = "خانه";
        return View();
    }

}
