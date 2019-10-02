using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Partiendo de la base del ejercicio anterior, se pide realizar un programa que imprima por pantalla
una pirámide como la siguiente:
    *
   ***
  *****
 *******
*********
Nota: Utilizar estructuras repetitivas y selectivas.*/

//new.datetime(año,mes,dias)) -> datetime.now.days
namespace EjercicioGuia10
{
    class Program
    {
        static void Main(string[] args)
        {
            int filas;
            int cantidadEspacios;
            int astericosEnBase = 1;
            int asteriscosEnFila = 1;

            Console.WriteLine("Ingrese la altura de la piramide");
            filas = Convert.ToInt32(Console.ReadLine());

            //determino la cantidad de * en la base de la piramide-

            for (int i = 1; i < filas; i++)
            {
                astericosEnBase += 2;
            }

            //veo cuantos espacios va a haber en el primer renglon-

            cantidadEspacios = (astericosEnBase - 1) / 2;

            //hago la piramide-

            for (int i = 0; i < filas; i++)
            {

                for (int j = 0; j < cantidadEspacios; j++)
                    Console.Write(" ");

                for (int j = 0; j < asteriscosEnFila; j++)
                    Console.Write("*");

                Console.WriteLine();

                cantidadEspacios--;
                asteriscosEnFila += 2;


            }

            Console.ReadKey();

        }
    }
}
