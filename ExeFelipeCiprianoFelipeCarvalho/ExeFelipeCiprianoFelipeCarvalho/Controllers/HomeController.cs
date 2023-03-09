using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExeFelipeCiprianoFelipeCarvalho.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewData["Cont"] = "Contato";
            TempData["Text"] = "O MVC é um padrão de desenvolvimento muito utilizado no mundo web é conhecido por 'forçar' o programador a separar as responsabilidades.";
            return View();
        }
    }
}