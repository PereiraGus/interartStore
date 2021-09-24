using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using interartStore.Models;
using interartStore.Repos;

namespace interartStore.Controllers
{
    public class HomeController : Controller
    {
        Cadastros ac = new Cadastros();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Cliente()
        {
            var cliente = new Cliente();
            return View(cliente);
        }

        [HttpPost]
        public ActionResult CadCli(Cliente cliente)
        {
            ac.CadastrarCliente(cliente);
            return View(cliente);
        }

        public ActionResult ListarCli(Cliente cliente)
        {
            var ExibeCli = new Cadastros();
            var AllCli = ExibeCli.ListarClientes();
            return View(AllCli);
        }

        public ActionResult Funcionario()
        {
            var funcionario = new Funcionario();
            return View(funcionario);
        }

        [HttpPost]
        public ActionResult CadFunc(Funcionario funcionario)
        {
            ac.CadastrarFuncionario(funcionario);
            return View(funcionario);
        }

        public ActionResult ListarFunc(Funcionario funcionario)
        {
            var ExibeFunc = new Cadastros();
            var AllFunc = ExibeFunc.ListarFuncionarios();
            return View(AllFunc);
        }

        public ActionResult Game()
        {
            var game = new Game();
            return View(game);
        }

        [HttpPost]
        public ActionResult CadGame(Game game)
        {
            ac.CadastrarJogo(game);
            return View(game);
        }

        public ActionResult ListarGame(Game game)
        {
            var ExibeGame = new Cadastros();
            var AllGame = ExibeGame.ListarJogos();
            return View(AllGame);
        }
    }
}