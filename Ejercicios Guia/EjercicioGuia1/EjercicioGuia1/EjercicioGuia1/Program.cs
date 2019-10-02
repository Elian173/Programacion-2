using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
            /*Ingresar 5 números por consola, guardándolos en una variable escalar. Luego calcular y mostrar: el
            valor máximo, el valor mínimo y el promedio.*/
namespace EjercicioGuia1
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;
            string vString;
            double suma = 0;
            int max = 0;
            int min = 0;


            for(int i = 0; i < 5; i++){

                Console.WriteLine("Numero {0}:",i);

                vString = Console.ReadLine();

                valor = Convert.ToInt32(vString);

                if (i == 0)
                {
                    max = valor;
                    min = valor;
                }

                if(valor > max)
                {
                    max = valor;
                }

                if (valor < min)
                {
                    min = valor;
                }

                suma = valor + suma;

            }
            Console.Clear();
            Console.WriteLine("Total:{0}", suma);
            Console.WriteLine("Max:{0}", max);
            Console.WriteLine("Min:{0}", min);
            Console.WriteLine("Promedio:{0}", suma / 5.0);


            Console.ReadKey(); 


        }
    }
}
