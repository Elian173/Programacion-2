using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Hacer un programa que pida por pantalla la fecha de nacimiento de una persona (día, mes y año) y
calcule el número de días vividos por esa persona hasta la fecha actual (tomar la fecha del sistema
con DateTime.Now).
Nota: Utilizar estructuras selectivas. Tener en cuenta los años bisiestos*/
//NOSE NO TOCAR :)


namespace EjercicioGuia7
{
    class Program
    {
        static void Main(string[] args)
        {
            string año, mes, dia;
            string fecha = "";

            DateTime fechaActual = DateTime.Now;

            DateTime fechaUsuario;

            TimeSpan tiempoQuePaso;

            int edad;

            Console.WriteLine("Ingrese año de nacimiento:");
            año = Console.ReadLine();

            Console.WriteLine("Ingrese mes de nacimiento:");
            mes = Console.ReadLine();

            Console.WriteLine("Ingrese dia de nacimiento:");
            dia = Console.ReadLine();

            fecha = dia + "/" + mes + "/" + año;

            Console.WriteLine("Datetime.now = {0}",fechaActual);
            Console.WriteLine("Cada String = {0}/{1}/{2}", dia , mes , año);
            Console.WriteLine("String Fecha = {0}", fecha);

            fechaUsuario = Convert.ToDateTime(fecha);

            Console.WriteLine("fechaUser datetime = {0}", fechaUsuario);

            tiempoQuePaso = ( fechaActual - fechaUsuario ) ;

            edad = tiempoQuePaso.Days;
            edad = edad / 365;

            Console.WriteLine("Edad = {0}", edad);

            Console.ReadKey();


        }


        private static bool Verificar_Bisiesto(int year) {
            return false;
        }

    }
}
