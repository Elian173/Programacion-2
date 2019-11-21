using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
namespace EjercicioMetodosExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dia = DateTime.Now;


            Console.WriteLine("Invierno");
            Console.WriteLine(dia.ObtenerPlacaCronica(Estaciones.Invierno));
            Console.WriteLine("Otoño");
            Console.WriteLine(dia.ObtenerPlacaCronica(Estaciones.Otonio));
            Console.WriteLine("Verano");
            Console.WriteLine(dia.ObtenerPlacaCronica(Estaciones.Verano));
            Console.WriteLine("Primavera");
            Console.WriteLine(dia.ObtenerPlacaCronica(Estaciones.Primavera));

            Console.ReadKey();
        }
    }
}
