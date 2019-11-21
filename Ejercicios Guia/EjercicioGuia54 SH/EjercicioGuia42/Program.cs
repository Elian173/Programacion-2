using System;
using System.Text;
using IO;

namespace EjercicioGuia42
{
    internal class Program
    {
        private static void Main( string[] args )
        {
            Clase3 x = new Clase3();
            ;
            try
            {
                x.Metodo();
            }
            catch (MiException prueba)
            {
                Exception mensaje = new Exception();
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                mensaje = prueba;

                do
                {
                    
                    ArchivoTexto.GuardarTexto("Mensaje -->  " + prueba.Message + " TIPO: -->  " + prueba.GetType() + "           ", path,
                    true,"Exception");


                    mensaje = mensaje.InnerException;


                } while (mensaje != null);


            }


            Console.ReadKey();
        }
    }
}