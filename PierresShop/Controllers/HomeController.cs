using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PierresShop.Models;
using System.Collections.Generic;
using System.Linq;

namespace PierresShop.Controllers
{
    public class HomeController : Controller
    {
      private readonly PierresShopContext _db;

      public HomeController(PierresShopContext db)
      {
        _db = db;
      }

      [HttpGet("/")]
      public ActionResult Index()
      {
        ViewBag.Treats = _db.Treats.ToList();
        ViewBag.Flavors = _db.Flavors.ToList();
        return View();
      }
    }
}