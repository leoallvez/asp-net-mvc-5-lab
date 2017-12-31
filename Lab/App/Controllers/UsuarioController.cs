using System;
using App.Models;
using System.Web;
using System.Linq;
using System.Web.Mvc;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace App.Controllers
{
    public class UsuarioController : Controller
    {

        // GET: Usuario
        public ActionResult Index()
        {
            return View(new Usuario());
        }

        [HttpPost]
        public ActionResult Index(Usuario usuario)
        {
            if(ModelState.IsValid)
            {
                return View("Resultado", usuario);
            }

            return View(usuario);
        }

        public ActionResult Resultado(Usuario usuario)
        {
            return View(usuario);
        }

        public ActionResult LoginUnico(string login)
        {
            var bdExemplo = new Collection<string>
            {
                "hugo",
                "freitas",
                "paula"
            };

            return Json(bdExemplo.All(m => !m.ToLower().Equals(login.ToLower())), JsonRequestBehavior.AllowGet);
        }
    }
}