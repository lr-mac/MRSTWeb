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
               ViewBag.title = "Home";
               return View();
        }
    }
}
