using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4_Clases
{
    class Program
    {
        static void Main(string[] args)
        {
            ClaseVehiculo Vehiculo = new ClaseVehiculo();

            Vehiculo.Color = "Negro";

            var ColorVehiculo = Vehiculo.EnviarColor(1);
        }
    }
}
