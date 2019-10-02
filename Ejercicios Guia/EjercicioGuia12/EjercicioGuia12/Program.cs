using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Realizar un programa que sume números enteros hasta que el usuario lo determine, por medio de
un mensaje "¿Continuar? (S/N)".
En el método estático ValidaS_N (char c) de la clase ValidarRespuesta, se validará el ingreso de
opciones.
El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó
cualquier otro valor.

*/

namespace EjercicioGuia12
{
    class Program
    {
        static void Main(string[] args)
        {

            bool continuar = true;

            Console.WriteLine("Empieza");
            while (true)
            {

                if (continuar)
                {
                    Console.WriteLine("Seguimos=?");
                    continuar = ValidarRespuesta.ValidaS_N(Convert.ToChar(Console.ReadLine()));
                }
                else
                {
                    break;
                }

            }

            Console.WriteLine("Chau");
            Console.ReadKey();
        }
    }
}
