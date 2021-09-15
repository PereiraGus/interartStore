using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using interart2.Models;
using interart2.Repositório;

namespace interart2.Controllers
{
    public class FuncionarioController : Controller
    {
        // GET: Func
        public ActionResult Index()
        {
            var funcionario = new FuncionarioModel();
            return View(funcionario);
        }
        Acoes ac = new Acoes();

        [HttpPost]
        public ActionResult Index (FuncionarioModel funcionario)
        {
            ac.CadastrarFuncionario(funcionario);
            return View(funcionario);
        }
    }
}