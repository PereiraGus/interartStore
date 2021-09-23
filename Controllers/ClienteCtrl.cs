using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using interartStore.Models;
using interartStore.Repos;

namespace interartStore.Controllers
{
    public class ClienteCtrl : Controller
    {
        public ActionResult Index()
        {
            var cliente = new Cliente();
            return View(cliente);
        }
        Cadastros ac = new Cadastros();

        [HttpPost]
        public ActionResult Index(Cliente cliente)
        {
            ac.CadastrarCliente(cliente);
            return View(cliente);
        }
    }
}