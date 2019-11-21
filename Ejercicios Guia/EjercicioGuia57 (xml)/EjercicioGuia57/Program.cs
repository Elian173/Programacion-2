using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioGuia57
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Persona p = new Persona("Hola", "sssss");
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                Console.WriteLine("Guarda");
                Console.WriteLine();
                Persona.Guardar(p, path + "\\archivo.xml");
                Console.ReadKey();

                Console.Clear();
                Console.WriteLine("Lee");
                Console.WriteLine();
                Persona leida = Persona.Leer(path + "\\archivo.xml");
                Console.WriteLine(leida.ToString());

                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("Algo salio mal");
                Console.ReadKey();
            }
           


        }
    }
}
