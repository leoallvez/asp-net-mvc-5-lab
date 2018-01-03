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

        public ActionResult MostraNoticia(int id, string categoria, string titulo)
        {
            Noticia noticia = TodasNoticias.FirstOrDefault(m => m.Id == id);
            return View(noticia);
        }

    
        /**URL - Amigaveis -> http://localhost:50857/noticias/Esportes */
        public ActionResult MostraCategoria(string categoria)
        {
            var noticias = TodasNoticias.Where(m => m.Categoria.ToLower()
                .Equals(categoria.ToLower())).ToList();

            ViewBag.Categoria = categoria;
            return View(noticias);
        }
    }
}