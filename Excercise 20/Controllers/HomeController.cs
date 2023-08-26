using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Excercise_20.Models;
using Excercise_20.Models.Context;

namespace Excercise_20.Controllers;

public class HomeController : Controller
{
    private readonly Context _context;
    public HomeController(Context context)
    {
        _context=context;
    }

    

    public IActionResult Index()
    {
    StaticVariable.menu=_context.Tbl_Menus.ToList();

        // ViewBag.menu=_context.Tbl_Menus.ToList();
        return View();
    }
    
    public IActionResult Category(string url)
    {
        ViewBag.pro=url;
        return View();
    }


}
