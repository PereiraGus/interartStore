using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using interart.Models;

namespace interart.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Func
        public ActionResult Index()
        {
            var cliente = new ClienteModel();
            return View(cliente);
        }

        [HttpPost]
        public ActionResult Index (ClienteModel cliente)
        {
            if(ModelState.IsValid)
            {
                return View("Listar", cliente);
            }
            return View(cliente);
        }
    }
}