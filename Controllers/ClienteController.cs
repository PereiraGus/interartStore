using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using interart2.Models;
using interart2.Repositório;

namespace interart2.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Func
        public ActionResult Index()
        {
            var cliente = new ClienteModel();
            return View(cliente);
        }
        Acoes ac = new Acoes();

        [HttpPost]
        public ActionResult Index (ClienteModel cliente)
        {
            ac.CadastrarCliente(cliente);
            return View(cliente);
        }


    }
}