using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using interart2.Models;

namespace interart2.Controllers
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