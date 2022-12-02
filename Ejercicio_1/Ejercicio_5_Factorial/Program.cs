using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int Numero, Valor;
            Numero = 6;
            Valor = 1;
            for (int i = Numero; i >= 1; i--)
            {
                Valor = Valor * i;
            }

            Console.WriteLine(Valor);
            Console.ReadLine();

        }
    }
}
