using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Escribir un programa que imprima por pantalla una pirámide como
la siguiente:
*
***
*****
*******
*********
El usuario indicará cuál será la altura de la pirámide ingresando un número entero positivo. Para el
ejemplo anterior la altura ingresada fue de 5.
Nota: Utilizar estructuras repetitivas y selectivas.*/

namespace EjercicioGuia9
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string piramide = "**";

            Console.WriteLine("Ingrese la altura de la piramide");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero > 1)
            {
                Console.WriteLine("*");
                for (int i = 1; i < numero; i++)
                {
                    Console.WriteLine(piramide);
                    piramide = piramide + "**";
                }

            }

            else
            {
                Console.WriteLine("*");
            }


            Console.ReadKey();

        }
    }
}
