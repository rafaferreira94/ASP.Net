using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrimeiroSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
           // ViewBag.Message = "Aqui a nossa Página de Descrição";

            return View();
        }

        public ActionResult Contact()
        {
            //ViewBag.Message = "Nossa Página de contato";

            return View();
        }
    }
}