using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6_Burbuja
{
    class Program
    {
        static int[] myArray = { 1, 6, 4, 2, 7, 0 };
        static void Main(string[] args)
        {
            int Contador = 1;
            int copiaA, copiaB;
            Imprimir();
            while (Contador <= myArray.Length)
            {
                for (int i = 0; i < myArray.Length; i++)
                {
                    if (i != myArray.Length - 1)
                    {
                        copiaA = myArray[i];
                        copiaB = myArray[i + 1];
                        if (myArray[i] > myArray[i + 1])
                        {
                            myArray[i + 1] = copiaA;
                            myArray[i] = copiaB;
                        }
                    }
                }
                Contador++;
            }
            Console.WriteLine("");
            Imprimir();
            Console.ReadLine();
        }

        public static void Imprimir()
        {
            for (int i = 0; i < myArray.Length; i++)
            {

                Console.Write(myArray[i] + " ");
            }
        }
    }
}
