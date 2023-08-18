using System;
using System.Security.AccessControl;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Excercise_17.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Linq;
using Excercise_17.Models.Context;

namespace Excercise_17.Controllers;

public class HomeController : Controller
{
   private readonly Context _context; 
   public HomeController(Context context)
   {
    _context=context;
   }

    public IActionResult Index()
    {
        return View();
    }

 public IActionResult AccessDenied()
    {
        return View();
    }
     public IActionResult Login()
    {
        return View();
    }
[HttpPost]
     public IActionResult check(string username,string password) {
        
        var user = _context.Users.Where(x => x.Username == username && x.Password == password).FirstOrDefault();

        if(username== user.Username && password==user.Password)
        {
            
            var claims=new List<Claim>
            {
                new Claim(ClaimTypes.Name,username),
                new Claim(ClaimTypes.Role,username),
                new Claim(ClaimTypes.NameIdentifier,user.Id.ToString())
            };

            var identity=new ClaimsIdentity(claims,CookieAuthenticationDefaults.AuthenticationScheme);
            var principal=new ClaimsPrincipal(identity);
            HttpContext.SignInAsync(principal);
             return RedirectToAction("Index","Home",new {area = "Admin"});
        }
        else
        {
           // return RedirectToAction("Login");
         return RedirectToAction("Index","Home","PanelUser",new {area = "PanelUser"});

        }
        
    }

    private IActionResult RedirectToAction(string v1, string v2, string v3, object value)
    {
        throw new NotImplementedException();
    }
}

