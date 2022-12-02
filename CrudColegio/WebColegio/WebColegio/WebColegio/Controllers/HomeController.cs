using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Controlador;
using Entity;

namespace WebColegio.Controllers
{
    public class HomeController : Controller
    {
        private EstudiantesBL estududianteBL = new EstudiantesBL();

        public async Task<ActionResult> Index()
        {
            try
            {
                //EstudiantesEntity estudiantesEntity = new EstudiantesEntity
                //{
                //    DataAction="INSERT",
                //    EstudianteId = 1,
                //    EstudianteNombre = "Jonathan"
                //};
                //await estududianteBL.Insert(estudiantesEntity);
                return RedirectToAction("Index","Estudiantes");
                //return View();

            }
            catch (Exception ex)
            {
                return View();

            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}