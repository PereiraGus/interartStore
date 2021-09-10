using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using interart.Models;

namespace interart.Controllers
{
    public class FuncionarioController : Controller
    {
        // GET: Func
        public ActionResult Index()
        {
            var funcionario = new FuncionarioModel();
            return View(funcionario);
        }

        [HttpPost]
        public ActionResult Index (FuncionarioModel funcionario)
        {
            if(ModelState.IsValid)
            {
                return View("Listar", funcionario);
            }
            return View(funcionario);
        }
    }
}