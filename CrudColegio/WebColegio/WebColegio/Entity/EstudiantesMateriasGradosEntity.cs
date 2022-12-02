using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class EstudiantesMateriasGradosEntity
    {
        public string DataAction { get; set; }
        public int EstudiantesMateriasGradosId { get; set; }
        public int EstudianteId { get; set; }
        public int MateriasGradosId { get; set; }
        [Display(Name="NombreEstudiante")]
        public string EstudianteNombre { get; set; }
        public string MateriaNombre { get; set; }
        public decimal Notas { get; set; }
        public string Grado { get; set; }
        

    }
}
