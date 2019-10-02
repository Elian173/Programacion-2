using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Un centro numérico es un número que separa una lista de números enteros (comenzando en 1) en
dos grupos de números, cuyas sumas son iguales.
El primer centro numérico es el 6, el cual separa la lista (1 a 8) en los grupos: (1; 2; 3; 4; 5) y (7; 8)
cuyas sumas son ambas iguales a 15. El segundo centro numérico es el 35, el cual separa la lista (1 a
49) en los grupos: (1 a 34) y (36 a 49) cuyas sumas son ambas iguales a 595.
Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el número que el
usuario ingrese por consola.
Nota: Utilizar estructuras repetitivas y selectivas.*/


namespace EjercicioGuia5
{
    class Program
    {
        static void Main(string[] args)
        {

            int nIngresado;
            int centro = 0;
            int sumaA = 0;
            int sumaB = 0;
            int encontro = 0;
            Console.WriteLine("Ingrese un numero : ");
            nIngresado = Convert.ToInt32(Console.ReadLine());

            do
            {
                sumaA = 0;
                sumaB = 0;
                centro++;

                for (int i = centro ; i <= nIngresado ; i++)
                {
                    sumaA += i; 
                }

                for (int j = centro; j >= 1; j--)
                {
                    sumaB += j;
                }

                if(sumaA == sumaB)
                {
                    Console.WriteLine("Centro = {0}", centro);
                    encontro = 1;
                    break;
                }

            } while (centro < nIngresado);


            if(encontro == 0)
            {
                Console.WriteLine("No tiene centro");
            }

            Console.ReadKey();
        }
    }
}
