using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos
(excluido el mismo) que son divisores del número.
El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.
Escribir una aplicación que encuentre los 4 primeros números perfectos.
Nota: Utilizar estructuras repetitivas y selectivas.*/

namespace EjercicioGuia4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int encontrados = 0;
            int divisor = 1;
            int suma = 0;
            Console.WriteLine("Numeros perfectos :");
            while (encontrados < 4)
            {
                suma = 0;
                numero++;

                for (divisor = 1; divisor < numero-1; divisor++)
                {
                    if ((numero % divisor) == 0)
                    {
                        suma += divisor;
                    }
                  
                }

                if (suma == numero)
                {
                    encontrados++;
                    Console.WriteLine("{0}", numero);
                 
                }

            }
            Console.ReadKey();

        }
    }
}
