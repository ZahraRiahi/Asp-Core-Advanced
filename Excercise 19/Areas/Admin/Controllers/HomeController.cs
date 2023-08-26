using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Excercise_20.Models;
using Excercise_20.Models.Context;
using Excercise_20.Models.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using Excercise_20.Models.Dto;

namespace Excercise_20.Areas.Admin.Controllers;
[Area("Admin")]
public class HomeController : Controller
{
   private readonly Context _context;
   public HomeController(Context context)
   {
    _context=context;
   }
    public IActionResult Index()
    {
        var Tbl_Menus=_context.Tbl_Menus.OrderByDescending(x=>x.Id).ToList();
        ViewBag.Menu=new SelectList(Tbl_Menus,"Id","CategoryName");
        List<Menu> menus=new List<Menu>();
        foreach(var item in Tbl_Menus )
        {
            var menu=new Menu(){
                Id=item.Id,
                Name=item.CategoryName,
                ParentName=item.ParentId == 0?"دسته اصلی":Tbl_Menus.FirstOrDefault(x=>x.Id==item.ParentId).CategoryName
            };
            menus.Add(menu);
        }
        ViewBag.Table=menus;

        return View();
    }
    [HttpPost]
public IActionResult Add(string CategoryName,string ParentId)
    {
        var Tbl_Menu=new Tbl_Menu(){
            CategoryName=CategoryName,
            ParentId=int.Parse(ParentId),
            Status=true
        };
        _context.Tbl_Menus.Add(Tbl_Menu);
        _context.SaveChanges();

        return RedirectToAction("Index");
    }
  
}
