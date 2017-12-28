using System;
using System.Web;
using System.Linq;
using System.Web.Mvc;
using System.Collections.Generic;
using App.Models;

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
    }
}