using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        public static string contadorAsteriscos { get; set; }
        //string contadorAsteriscos = "";
        static void Main(string[] args)
        {

            int[] myArray = new int[10];
            Random rnd = new Random();
            int contador = 0;
            string Histograma = "" ;
            int ValorHistograma = 1;
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = rnd.Next(1, 6);
                Console.Write(myArray[i] + " ");


            }
            Console.WriteLine();
            while (ValorHistograma <= 5)
            {
                for (int i = 0; i < myArray.Length; i++)
                {
                    if (ValorHistograma == myArray[i])
                    {
                        contador++;
                        Histograma = Contador();
                    }

                }
                Console.WriteLine(ValorHistograma + " : "+ Histograma);
                ValorHistograma++;
                contadorAsteriscos = "";
                contador = 0;
            }

            Console.ReadLine();

          
        }
        public static string Contador()
        {
            return contadorAsteriscos = contadorAsteriscos + "*"; 
        }
    }
}
