using Proiect_TWEB.BusinessLogic.Interfaces;
using Proiect_TWEB.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Proiect_TWEB.Web.Filters
{

     public class AdminModAttribute : ActionFilterAttribute
     {
          private readonly ISession _sessionBusinessLogic;

          public AdminModAttribute()
          {
               var businessLogic = new BusinessLogic.BusinessLogic();
               _sessionBusinessLogic = BusinessLogic.GetSessionBL();
          }

          public override void OnActionExecuting(ActionExecutingContext filterContext)
          {
               var apiCookie = HttpContext.Current.request.Cookies["X-KEY"];
               if (apiCookie != null)
               {
                    var profile = _sessionBusinessLogic.GetUserByCookie(apiCookie.Value);
                    if (profile != null && profile.Level != URole.Admin)
                    {
                         HttpContext.Current.SetMySessionObject(profile);
                    }
                    else
                    {
                         filterContext.Result = new RedirectToRouteresult(new
                              RouteValueDictionary(new { controller = "ERROR", action = "Error404" }));
                    }
               }
          }
     }
}
