using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using App.Models;
using Core.Domain.Product;
using Core.Interface.Product;

namespace App.Controllers;

public class HomeController : Controller
{

private readonly IProduct _product;
public HomeController(IProduct product)
{
    _product=product;
}
    public IActionResult Index()
    {
        ViewBag.listProducts=_product.GetAllProduct();
        return View();
    }
     public IActionResult addproduct(MProduct product)
    {
        _product.AddProduct(product);
        return RedirectToAction("index");
    }
    public IActionResult deleteproduct(int id)
    {
        _product.DeleteProduct(id);
        return RedirectToAction("index");
    }
    

}
