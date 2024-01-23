using Microsoft.AspNetCore.Mvc;

namespace App.EndPoints.MVC.Areas.AdminArea.Controllers;

[Area("Admin")]
public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
