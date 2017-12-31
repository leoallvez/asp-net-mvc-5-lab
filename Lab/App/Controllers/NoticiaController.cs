using App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace App.Controllers
{
    public class NoticiaController : Controller
    {
        private IEnumerable<Noticia> TodasNoticias;

        public NoticiaController()
        {
            TodasNoticias = new Noticia().TodasAsNoticias().OrderByDescending(m => m.Data);
        }
        // GET: Default
        public ActionResult Index()
        {

            ViewBag.Categorias = TodasNoticias.Select(x => x.Categoria).Distinct().ToList();

            return View(TodasNoticias.Take(3));
        }

        public ActionResult TodasAsNoticias()
        {
            return View(TodasNoticias);
        }

        public ActionResult MostraNoticia(int id)
        {
            return View(TodasNoticias.Where(m => m.NoticiaId == id));
        }
    }
}