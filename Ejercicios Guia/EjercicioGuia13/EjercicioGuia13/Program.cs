using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
/*

13. Desarrollar una clase llamada Conversor, que posea dos métodos de clase (estáticos):
string DecimalBinario(double). Convierte un número de entero a binario.
double BinarioDecimal(string). Convierte un número binario a entero

*/


namespace EjercicioGuia13
{
    class Program
    {
        static void Main( string[] args )
        {
            double number;

            string binary;

            Console.WriteLine("Ingrese un numero comun : ");
            number = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese un numero binario : ");
            binary = Console.ReadLine();


            Console.WriteLine("El numero comun " + number + " en binario es : "+ Conversor.DecimalBinario(number) );

            Console.WriteLine("El numero binario " + binary + " en decimal es : " + Conversor.BinarioDecimal(binary));

            Console.ReadKey();

        }
    }
}
