using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario
por consola.
Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%).*/




namespace EjercicioGuia3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            bool primo = true;

            Console.WriteLine("Ingrese un numero : ");

            numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Numeros primos desde el 2 al " + numero);

            while (numero != 1)
            {

                primo = true;

                for(int i = 2; i < numero; i++)
                {
                    if(numero % i == 0) {

                        if(numero != i)
                        {
                            primo = false;
                            break;
                        }

                    }

                }

                if(primo == true)
                {
                    Console.WriteLine("{0}", numero);
                }

                numero--;
            
            }

            Console.ReadKey();
            
        }
    }
}
