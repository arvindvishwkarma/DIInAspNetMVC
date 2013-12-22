using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DIWithNinject.Infrastructure;

namespace DIWithNinject.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(IMessageService messageService)
        {
            this.messageService = messageService;
        }

        private IMessageService messageService;

        public ActionResult Index()
        {
            ViewBag.Message = messageService.GetMessage();
            //ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
