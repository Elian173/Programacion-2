using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;

namespace EjercicioGuia67
{
    class Program
    {
        static void Main(string[] args)
        {
            Temporizador temporizador = new Temporizador();

            temporizador.Activo = false;//No esta iniciado no hace nada
            temporizador.Activo = true; // Se inicia pero no se lanza nada porque no hay nada asociado.
            temporizador.Activo = false;// lo paro
            Console.ReadKey();


            temporizador.Intervalo = 1000; // inicio el intervalo
            temporizador.EventoTiempo += MostrarFecha;//Asigno metodo al evento
            temporizador.EventoTiempo += MostrarGuionsito;//Asigno metodo al evento

            temporizador.Activo = true;// No deberia tirar error al activar sobre un activo.

            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("Puedo seguir usando el main , cambio intervalo a 500");
            temporizador.Intervalo = 500;
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("Parar?");
            Console.ReadKey();

            temporizador.Activo = false;
            temporizador.Activo = false;// No deberia tirar error.

            Console.Clear();
            Console.WriteLine("Paro");
            Console.ReadKey();

        }

        public static void MostrarFecha()
        {
            Console.WriteLine(DateTime.Now);
        }
        public static void MostrarGuionsito()
        {
            Console.WriteLine("__________________");
        }
    }
}
