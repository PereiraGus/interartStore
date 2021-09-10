using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using interart.Models;

namespace interart.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var func = new FuncionarioModel();
            return View(func);
        }

    }
}