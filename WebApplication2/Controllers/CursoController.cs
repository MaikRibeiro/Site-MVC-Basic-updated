using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    

    public class CursoController : Controller
    {
        // GET: Curso
        public ActionResult Index()
        {
            return View(CursoModel.CriarLista());
        }

        // GET: Curso/Details/5
        public ActionResult Details(int id)
        {
            var curso = CursoModel.CriarLista()[id];
            return View(curso);
        }

        // GET: Curso/Create
        public ActionResult Create()
        {
            var curso = CursoModel.CriarLista();

            return View();
        }

        // POST: Curso/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CursoModel collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Curso/Edit/5
        public ActionResult Edit(int id)
        {
            var curso = CursoModel.CriarLista()[id];

            return View(curso);

        }

        // POST: Curso/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit()
        {

            return View();
        }

        // GET: Curso/Delete/5
        public ActionResult Delete(int id)
        {
            var curso = CursoModel.CriarLista()[id];

            //  var curso = CursoModel.CriarLista().Where(o => o.Id == Id).FirstOrDefault();
            return View(curso);
        }

        // POST: Curso/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(CursoModel Curso, IFormCollection collection)
        {


            return RedirectToAction("Index");
        }
    }
}
  
