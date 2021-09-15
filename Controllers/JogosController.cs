using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using interart2.Models;
using interart2.Repositório;

namespace interart2.Controllers
{
    public class JogosController : Controller
    {
        // GET: Func
        public ActionResult Index()
        {
            var jogos = new JogosModel();
            return View(jogos);
        }
        Acoes ac = new Acoes();

        [HttpPost]
        public ActionResult Index (JogosModel jogos)
        {
            ac.CadastrarJogo(jogos);
            return View(jogos);
        }
    }
}