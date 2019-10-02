using BibliotecaClases;
using System;

namespace EjercicioGuia37
{
    internal class Program
    {
        private static void Main( string[] args )
        {
            // Mi central
            Centralita c = new Centralita("Fede Center");

            // Mis 4 llamadas
            Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
            Provincial l2 = new Provincial("Morón", Provincial.Franja.Franja_1, 21, "Bernal");
            Local l3 = new Local("Lanús", 45, "San Rafael", 1.99f);
            Provincial l4 = new Provincial(Provincial.Franja.Franja_3, l2);

            // Las llamadas se irán registrando en la Centralita.

            //La centralita mostrará por pantalla todas las llamadas según las vaya registrando.
            Console.WriteLine("AÑADO ll 1 ");
            // c.Llamadas.Add(l1);
            c = c + l1;

            Console.WriteLine("AÑADO ll 2 ");
            //c.Llamadas.Add(l2);
            c = c + l2;

            Console.WriteLine("AÑADO ll 3 ");
            //c.Llamadas.Add(l3);
            c = c + l3;

            Console.WriteLine("AÑADO ll 4 ");
            //c.Llamadas.Add(l4);
            c = c + l4;

            Console.WriteLine("ORDENO");

            c.OrdenarLlamadas();

            Console.WriteLine(c.ToString());

            Console.WriteLine("_______Ganancia total provincial__________");
            Console.WriteLine(c.GananciaPorProvincial);
            Console.WriteLine("_______Ganancia total Local:___");
            Console.WriteLine(c.GananciaPorLocal);
            Console.WriteLine("_______Ganancia total__________");
            Console.WriteLine(c.GananciaPorTotal);

            Console.ReadKey();
        }
    }
}