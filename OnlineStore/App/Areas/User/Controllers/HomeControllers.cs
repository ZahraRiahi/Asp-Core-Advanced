using Microsoft.AspNetCore.Mvc;

namespace Areas.User.Controllers;

[Area("User")]
public class HomeController : Controller
{

     public IActionResult Index()
    {
        return View();
    }
    
     public IActionResult Cart()
    {
        return View();
    }
    
}