using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioGuia42
{
    class Program
    {
        static void Main(string[] args)
        {
            Clase3 x = new Clase3();;
            try
            {
                x.Metodo();
               
            }
            catch (MiException e)
            {
                Console.WriteLine("Exceptions:");
                Console.WriteLine("Mensaje -->  " + e.Message + " TIPO: MiException? -->  " + e.GetType());
                Console.WriteLine("Mensaje -->  " + e.InnerException.Message + " TIPO: UnaException?--> " + e.InnerException.GetType());
                Console.WriteLine("Mensaje -->  " + e.InnerException.InnerException.Message + " TIPO--> " + e.InnerException.InnerException.GetType());



                Exception Prueba = new Exception();
                Prueba = e;
                Console.WriteLine("\n dowhile");

                do
                {
                    
                    Console.WriteLine("Mensaje -->  " + Prueba.Message + " TIPO: -->  " + Prueba.GetType());
            
                    Prueba = Prueba.InnerException;
                   

                } while (Prueba != null);

            }


            Console.ReadKey();

        }



    }
}
