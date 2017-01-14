using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControledeEstoque.Web.Controllers
{
    public class GraficoController : Controller
    {
        public ActionResult PerdasMensais()
        {
            return View();
        }
        public ActionResult EntradasSaidas()
        {
            return View();
        }
    }
}