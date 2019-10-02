using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EjercicioGuia11
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 numeroIngresado;
            bool fueValido;
            Int32 suma = 0;
            int i = 0;
            bool primeraInstancia = true;
            int min = new int();
            int max = new int(); 


            while (i < 10)
            {

                Console.WriteLine("Ingrese un numero del -100 al 100");
                numeroIngresado = Convert.ToInt32(Console.ReadLine());
                fueValido = Validacion.Validar(numeroIngresado, -100, 100);

                if (fueValido == true)
                {
                    //Primer minimo y maximo
                    if (primeraInstancia == true)
                    {

                        primeraInstancia = false;
                        min = numeroIngresado;
                        max = numeroIngresado;

                    }

                    //Nuevos min max
                    if (numeroIngresado >= max)
                    {
                        max = numeroIngresado;
                    }

                    if (numeroIngresado <= min)
                    {
                        min = numeroIngresado;
                    }

                    // suma y contador

                    suma += numeroIngresado;
                    i++;

                }
                else
                {
                    Console.WriteLine("Numero invalido");
                }

            }

            Console.WriteLine("Suma = " + suma);
            Console.WriteLine("Promedio = " + (suma / 10.0));
       

            Console.ReadKey();
        }
    }
}
