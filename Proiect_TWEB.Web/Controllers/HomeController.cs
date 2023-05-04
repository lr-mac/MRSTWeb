using Proiect_TWEB.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proiect_TWEB.Web.Controllers
{
     public class HomeController : Controller
     {
          // GET: Home
          //
          public ActionResult Index()
          {
               var product = Request.QueryString["p"];

               UserData u = new UserData();
               u.Username = "Customer";
               u.Products = new List<string> { "Product #1", "Product #2", "Product #3", "Product #4" };
               ViewBag.title = "Home";

               return View(u);
          }
          [HttpPost]
          public ActionResult Product(string btn)
          {
             return RedirectToAction("Product", "Home", new { @p = btn});
          }
    }
}
