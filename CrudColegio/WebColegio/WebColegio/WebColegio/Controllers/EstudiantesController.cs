using Controlador;
using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace WebColegio.Controllers
{
    public class EstudiantesController : Controller
    {
        private EstudiantesBL estudianteBL = new EstudiantesBL();
        private EstudiantesMateriasGradosBL estudiantesMateriasGradosBL = new EstudiantesMateriasGradosBL();

        public async Task<ActionResult> Index()
        {
            try
            {
                List<EstudiantesEntity> lista= new List<EstudiantesEntity>();
                EstudiantesEntity estudiantesEntity = new EstudiantesEntity
                {
                    DataAction = "SELECT",
                };
                DataTable list = await estudianteBL.Select(estudiantesEntity);

                foreach (DataRow item in list.Rows)
                {
                    EstudiantesEntity estudiantesEntityList = new EstudiantesEntity
                    {
                       EstudianteId=Convert .ToInt32(item["EstudianteId"]),
                       EstudianteNombre=item["EstudianteNombre"].ToString()
                    };
                    lista.Add(estudiantesEntityList);
                }
                return View(lista);

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public ActionResult Nuevo()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Nuevo(EstudiantesMateriasGradosEntity estudiantesMateriasGradosEntity)
        {
            estudiantesMateriasGradosEntity.DataAction = "INSERT";
           await estudiantesMateriasGradosBL.Insert(estudiantesMateriasGradosEntity);
            return Redirect("~/Estudiantes/");
        }

        public async Task<ActionResult> Editar(int Id)
        {
            try
            {
                List<EstudiantesMateriasGradosEntity> lista = new List<EstudiantesMateriasGradosEntity>();
                string Estudiante = "";
                EstudiantesMateriasGradosEntity estudiantesMateriasGradosEntity = new EstudiantesMateriasGradosEntity()
                {
                    EstudianteId = Id,
                    DataAction = "SELECT"
                };

                DataTable list = await estudiantesMateriasGradosBL.Select(estudiantesMateriasGradosEntity);
                if (list  != null)
                {


                    foreach (DataRow item in list.Rows)
                    {
                        EstudiantesMateriasGradosEntity estudiantesMateriasGradosEntityList = new EstudiantesMateriasGradosEntity
                        {
                            EstudiantesMateriasGradosId = Convert.ToInt32(item["EstudiantesMateriasGradosId"]),
                            EstudianteId = Convert.ToInt32(item["EstudianteId"]),
                            MateriasGradosId = Convert.ToInt32(item["MateriasGradosId"]),
                            Notas = Convert.ToDecimal(item["Notas"]),
                            EstudianteNombre = item["EstudianteNombre"].ToString(),
                            Grado = item["Grado"].ToString(),
                            MateriaNombre = item["MateriaNombre"].ToString(),
                        };
                        lista.Add(estudiantesMateriasGradosEntityList);
                        Estudiante = item["EstudianteNombre"].ToString();
                    }
                }
                else
                {

                }

                ViewData["Estudiante"] = Estudiante;
                return View(lista);

            }
            catch (Exception ex)
            {
                return Redirect("~Estudiante");
            } 
        }

        [HttpGet]
        public async Task<ActionResult> Eliminar(int id)
        {
            try
            {
                EstudiantesMateriasGradosEntity estudiantesMateriasGradosEntity = new EstudiantesMateriasGradosEntity()
                {
                    EstudiantesMateriasGradosId = id,
                    DataAction = "DELETE"
                };
                await estudiantesMateriasGradosBL.Delete(estudiantesMateriasGradosEntity);
            }
            catch (Exception ex)
            {

            }
            return Redirect("~/Estudiantes/");
}


    }
}