using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using App.Models;

namespace App.Controllers;

public class HomeController : Controller
{
        private readonly IUser _user;
        public  HomeController(IUser user){
            _user=user;
        }

    public IActionResult Index()
    {
        return View();
    }

}
