using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[6];
            Random rnd = new Random();
            int ValorSuma10 = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = rnd.Next(1, 10);
                Console.Write(myArray[i] + " ");


            }
           //int[] myArray = { 1 , 3 , 4 , 2 , 7 , 0};
            Console.WriteLine();
            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = i+1; j < myArray.Length; j++)
                {
                    if (myArray[i] + myArray[j] == 10)
                    {
                        ValorSuma10 = 10;
                        Console.WriteLine(myArray[i] + " " + myArray[j]);
                    }
                }
            }

            Console.ReadLine();

        }
    }
}
