using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Crear una lista, una cola y una pila . 
Cargar la lista con 5 numeros random.
Recorrer y mostrar en una misma linea los numeos en la lista.
Al mismo tienpo cargar los numeros de la pila.
Recorrer la pila, mostrar en una misma linea el contenido y
al mimsmo tiempo cargar cada elemento devuelto en la cola.
Recorrer la cola , mostrar en una misma linea el contenido.
*/

namespace EjProfe2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();
            Stack<int> pila = new Stack<int> (); // para leer pop (lo agarra y Elimina)  y pick (Lo agarra y lo deja)
            Queue<int> cola = new Queue<int>(); // enqueue para ingresar dato y dequeue es como el pop pero FIFO ( first in first out).



            Random numero = new Random();

            for (int i = 0; i < 5; i++)
            {
                lista.Add(numero.Next(0, 100));
            }

            Console.WriteLine("Lista:");

            foreach (int i in lista)
            {
                Console.Write(i);
                Console.Write(" ");
                pila.Push(i); // stack , ultimo en entrar , el primero en salir.
            }
            Console.WriteLine();


            Console.WriteLine("pila");
            foreach (int i in pila)
            {
                Console.Write(i);
                Console.Write(" ");
                cola.Enqueue(i); // cola , primero en entrar , primero en salir.
            }
            Console.WriteLine();


            Console.WriteLine("Cola ");
            for(int i = 0; i<5; i++)
            {
                Console.Write(cola.Dequeue()); // o pop en la pila sino se traba
                Console.Write(" ");
            }

            Console.ReadKey();


        }


        private static int Ordenar(int a, int b)
        {
            int valor = new int();

            if (a == b)
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
