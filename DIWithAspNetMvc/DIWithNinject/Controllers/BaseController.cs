using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DIWithNinject.Controllers
{
    public class BaseController : Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            ViewBag.Title = "Dependency Injection With Ninject";

            base.OnActionExecuting(filterContext);
        }
    }
}
