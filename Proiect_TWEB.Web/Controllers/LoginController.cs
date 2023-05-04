using Microsoft.ApplicationInsights.Extensibility.Implementation;
using Proiect_TWEB.BusinessLogic.Interfaces;
using Proiect_TWEB.Domain.Entities.User;
using Proiect_TWEB.Web.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Proiect_TWEB.Web.Controllers
{
     public class LoginController : Controller
     {
          private readonly ISession _session;
          public LoginController()
          {
               var bl = new Proiect_TWEB.BusinessLogic.BusinessLogic();
               _session = bl.GetSessionBL();
          }

          // GET: Login
          public ActionResult Index()
          {
               return View();
          }

          [HttpPost]
          [ValidateAntiForgeryToken]
          public ActionResult Index(UserLogin login)
          {
               if (ModelState.IsValid)
               {
                    ULoginData data = new ULoginData
                    {
                         Credential = login.Credential,
                         Password = login.Password,
                         LoginIp = Request.UserHostAddress,
                         LoginDateTime = DateTime.Now
                    };

                    var userLogin = _session.UserLogin(data);
                    if (userLogin.Status)
                    {
                         //ADD COOKIE
                         return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                         ModelState.AddModelError("", userLogin.StatusMsg);
                         return View();

                    }
               }
               return View();
          }
     }
}
