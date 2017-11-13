using Caixa.AulaAspnet.Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Caixa.AulaAspnet.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About(int id, string msg)
        {
            ViewBag.Message = "Your application description page.";
            ViewBag.Id = id;
            ViewBag.Mensagem = msg;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Teste()
        {
            ViewBag.Teste = "Teste de página sem layout.";
            return View();
        }

        //public ActionResult Cliente(Cliente cliente)
        //{
        //    return View(cliente);
        //}
    }
}