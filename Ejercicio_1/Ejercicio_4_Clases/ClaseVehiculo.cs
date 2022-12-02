using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4_Clases
{
    public class ClaseVehiculo
    {
        public int CantidadPuertas  { get; set; }
        public string Color { get; set; }

        public string EnviarColor(int NumColor)
        {
            return "Rojo";
        }

        public string EnviarColor(int NumColor, string VariableColor)
        {
            return "Rojo Erlado";
        }
    }
}
