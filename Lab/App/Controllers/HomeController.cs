using App.Models;
using System.Web.Mvc;

namespace App.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            var pessoa = new Pessoa ()
            {
                PessoaId = 1,
                Nome = "Hugo Vasconcelos dos Santos Lima",
                Tipo = "Administrador"
            };

            //ViewData["pessoa_nome"] = pessoa.Nome;
            //ViewBag.Pessoa = pessoa;

            return View(pessoa);
        }

        [HttpGet]
        public ActionResult Contatos()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Lista(Pessoa pessoa)
        {
            return View();
        }
    }
}