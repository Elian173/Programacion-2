using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetodosExtension;

namespace MetodosExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = "hola me llamo Elian";

            Console.WriteLine(texto);
            Console.WriteLine("Cantidad palabras:");
            Console.WriteLine(texto.CantidadPalabras());
            Console.ReadKey();
        }
    }
}
