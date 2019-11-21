using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseDeDatos;
using Entidades;
namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {

                //DAO.InsertarCliente("JUANSITO", "PEREZ", "11111111", DateTime.MinValue);
                //DAO.ModificarCliente(8, "wow", " JAJA", "32423423", DateTime.Now);
                //DAO.BorrarCliente(9);
                // DAOMascotas.InsertarMascota("sincommand", 4);

                List<Cliente> clientes = DAO.LeerClientes();

                foreach(Cliente c in clientes)
                {
                    Console.WriteLine(c.ToString());
                }

                Console.WriteLine("OK");

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

            Console.ReadKey();


        }
    }
}
