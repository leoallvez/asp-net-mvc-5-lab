using Materialize.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Materialize.Controllers
{
    public class DoctorsController : Controller
    {
        private DoctorWhoEntities2 db = new DoctorWhoEntities2();

        // GET: Doctors
        public ActionResult Index()
        {
            var doctors = db.Doctors.Include("Cities").Include("Specialties");
            return View(doctors);
        }

        public ActionResult Create()
        {
            ViewBag.Cities = new SelectList(db.Cities, "CityId", "FullName");
            ViewBag.Specialties = new SelectList(db.Specialties, "SpecialtyId", "Descriptions");
            /**
            ViewBag.IDCidade = new SelectList(db.Cidades, "IDCidade", "Nome");
            ViewBag.IDEspecialidade = new SelectList(db.Especialidades, "IDEspecialidade", "Nome");

            */

            return View(new Doctors());
        }

        [HttpPost]
        public ActionResult Create(Doctors doctor)
        {
            if (ModelState.IsValid)
            {
                db.Doctors.Add(doctor);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(doctor);
        }
    }
}