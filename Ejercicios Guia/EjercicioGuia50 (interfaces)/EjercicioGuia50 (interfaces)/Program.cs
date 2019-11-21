using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;
namespace EjercicioGuia50__interfaces_
{
    class Program
    {
        static void Main(string[] args)
        {

            Serializar<int, string> serializar = new Serializar<int, string>();
            Console.WriteLine(serializar.Leer());
            Console.WriteLine(serializar.Guardar(10));


            GuardarTexto<int, string> guardarTexto = new GuardarTexto<int, string>();
            Console.WriteLine(guardarTexto.Leer());
            Console.WriteLine(guardarTexto.Guardar(10));


            Console.ReadKey();


        }
    }
}
