using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioGuia16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1, alumno2, alumno3;
            alumno1 = new Alumno("perez", 1, "pepe");
            alumno2 = new Alumno("gonzales", 2, "juan");
            alumno3 = new Alumno("aaaaa", 3, "jaja");

            byte notaIngresada1;
            byte notaIngresada2;


            //notas 1

            Console.WriteLine("Ingrese la nota 1 de el alumno 1");
            notaIngresada1 = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Ingrese la nota 2 de el alumno 1");
            notaIngresada2 = Convert.ToByte(Console.ReadLine());

            //final 1
            alumno1.CalcularFinal(notaIngresada1, notaIngresada2);
            //estudiar 1
            alumno1.Estudiar(notaIngresada1, notaIngresada2);

            //notas 2 

            Console.WriteLine("Ingrese la nota 1 de el alumno 2");
            notaIngresada1 = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Ingrese la nota 2 de el alumno 2");
            notaIngresada2 = Convert.ToByte(Console.ReadLine());

            //final 2
            alumno2.CalcularFinal(notaIngresada1, notaIngresada2);
            ////estudiar 2
            alumno2.Estudiar(notaIngresada1, notaIngresada2);


            //notas 3

            Console.WriteLine("Ingrese la nota 1 de el alumno 3");
            notaIngresada1 = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Ingrese la nota 2 de el alumno 3 ");
            notaIngresada2 = Convert.ToByte(Console.ReadLine());

            //final 3
            alumno3.CalcularFinal(notaIngresada1, notaIngresada2);
            //estudiar 3
            alumno3.Estudiar(notaIngresada1, notaIngresada2);


            Console.Clear();

            Console.WriteLine(alumno1.Mostrar());
            Console.WriteLine();
            Console.WriteLine(alumno2.Mostrar());
            Console.WriteLine();
            Console.WriteLine(alumno3.Mostrar());

            Console.ReadKey();
        }
    }
}
