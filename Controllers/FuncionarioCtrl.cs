using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using interartStore.Models;
using interartStore.Repos;

namespace interartStore.Controllers
{
    public class FuncionarioCtrl : Controller
    {
        public ActionResult Index()
        {
            var funcionario = new Funcionario();
            return View(funcionario);
        }
        Cadastros ac = new Cadastros();

        [HttpPost]
        public ActionResult Index(Funcionario funcionario)
        {
            ac.CadastrarFuncionario(funcionario);
            return View(funcionario);
        }
    }
}