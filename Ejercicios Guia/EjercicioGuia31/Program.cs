using System;
using Entidades;
namespace Ejercicio31FIX
{
    internal class Program
    {
        private static void Main( string[] args )
        {
            PuestoAtencion puesto = new PuestoAtencion(PuestoAtencion.Puesto.caja1);

            Negocio negocio = new Negocio("he");

            Cliente clientes = new Cliente(0,"E");

            string a = "A";

            for (int i = 0; i < 10; i++)
            {
                clientes = new Cliente(i,a+=a);
                Console.WriteLine("{0}",clientes.Nombre);
                Console.WriteLine( negocio.ClientesPendientes );
                negocio.Cliente = clientes;
            }

            Console.ReadKey();




            Console.ReadKey();
        }
    }
}