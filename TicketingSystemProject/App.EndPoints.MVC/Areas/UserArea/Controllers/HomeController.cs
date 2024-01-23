using Microsoft.AspNetCore.Mvc;

namespace App.EndPoints.MVC.Areas.UserArea.Controllers;

[Area("User")]
public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
