using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using interartStore.Models;
using interartStore.Repos;

namespace interartStore.Controllers
{
    public class GameCtrl : Controller
    {
        public ActionResult Index()
        {
            var game = new Game();
            return View(game);
        }
        Cadastros ac = new Cadastros();

        [HttpPost]
        public ActionResult Index(Game game)
        {
            ac.CadastrarJogo(game);
            return View(game);
        }
    }
}