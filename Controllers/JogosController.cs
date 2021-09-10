using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using interart.Models;

namespace interart.Controllers
{
    public class JogosController : Controller
    {
        // GET: Func
        public ActionResult Index()
        {
            var jogos = new JogosModel();
            return View(jogos);
        }

        [HttpPost]
        public ActionResult Index (JogosModel jogos)
        {
            if(ModelState.IsValid)
            {
                return View("Listar", jogos);
            }
            return View(jogos);
        }
    }
}