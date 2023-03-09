using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExeFelipeCiprianoFelipeCarvalho.Controllers
{
    public class AulaController : Controller
    {
        // GET: Aluno
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Aluno()
        {
            if (TempData["Text"] != null)
            {
                ViewBag.Mens = "Os melhores alunos são aqueles que estudam mais!";
                return View();
            }
            else
            {
                ViewBag.Mens = "Os melhores alunos são aqueles que estudam mais!";
                return View();
            }
        }

        public ActionResult Google()
        {
            return Redirect("https://google.com");
        }
    }
}