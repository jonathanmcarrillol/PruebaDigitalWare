using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[5];
            Random rnd = new Random();
            int NumMayor = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = rnd.Next(1, 100);
                Console.Write(myArray[i] + " ");


            }
            //int[] myArray = { 10 , 11, 10 , 2 , 3 };
            Console.WriteLine();
            for (int i = 0; i < myArray.Length; i++)
            {
                if (NumMayor <= myArray[i])
                {
                    NumMayor = myArray[i];
                }             
            }
            Console.WriteLine(NumMayor);

            Console.ReadLine();

        }
    }
}
