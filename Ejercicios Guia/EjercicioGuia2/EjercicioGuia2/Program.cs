using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Ingresar un número y mostrar: el cuadrado y el cubo del mismo. Se debe validar que el número sea
mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
Nota: Utilizar el método ‘Pow’ de la clase Math para realizar la operación.*/

namespace EjercicioGuia2
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero;

            do {

                Console.WriteLine("Ingerese un numero : ");
                numero = Convert.ToInt32(Console.ReadLine());


                if (numero < 0)
                {
                    Console.WriteLine("Error reingresar numero");
                }

            } while (numero < 0);

            Console.Clear();
            Console.WriteLine("Numero = {0} ",numero);
            Console.WriteLine("Cuadrado = {0} ", Math.Pow(numero,2));
            Console.WriteLine("Cubo = {0} ", Math.Pow(numero, 3));


            Console.ReadKey();

        }


    }
}
