using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*en un ej de consoloa crear una lista con 5 nros aleatorios 
Recorres y mostrar en una misma lineas los nomeros en la lista
Ordenarlos de forma descente 
Recorrer y mostrar el contenido de la lista
ordenada en una misma lista*/

namespace EjProfe1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>() ;
            Random numero = new Random();

            for(int i = 0; i<5; i++)
            {
                lista.Add(numero.Next(0,100));
            }


            /*
            
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine( "{0}",lista[i] );
            }

            */


            foreach (int i in lista)
            {
                Console.Write(i);
                Console.Write(" ");
            }


            Console.WriteLine("_______");

            lista.Sort(Ordenar);

            foreach (int i in lista)
            {
                Console.Write(i);
                Console.Write(" ");
            }



            Console.ReadKey();



        }


        private static int Ordenar(int a, int b)
        {
            int valor = new int();

            if(a == b)
            {
                valor = 0;
            }

            if (a < b)
            {
                valor = 1;
            }

            if (a > b)
            {
                valor = -1;
            }

            return valor;

        }

    }
}
