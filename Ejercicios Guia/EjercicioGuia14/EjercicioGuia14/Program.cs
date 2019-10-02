using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Realizar una clase llamada CalculoDeArea que posea 3 métodos de clase (estáticos) que realicen el
cálculo del área que corresponda:
a. double CalcularCuadrado(double)
b. double CalcularTriangulo(double, double)
c. double CalcularCirculo(double)
El ingreso de los datos como la visualización se deberán realizar desde el método Main().*/

namespace EjercicioGuia14
{
    class Program
    {
        static void Main(string[] args)
        {

            double cuadrado = new double();
            double trianguloBase = new double(), trianguloAltura = new double();
            double circuloRadio = new double();


            //Cuadrado
            Console.WriteLine("Ingrese un lado de un cuadrado");

            while (!(double.TryParse(Console.ReadLine(), out cuadrado)))
            {
                Console.WriteLine("Error , Ingrese el lado de un cuadrado");
            }


            //Triangulo
            Console.WriteLine("Ingrese la base de un triangulo");

            while (!(double.TryParse(Console.ReadLine(), out trianguloBase)))
            {
                Console.WriteLine("Error , Ingrese la base de un triangulo");
            }


            Console.WriteLine("Ingrese la Altura del triangulo");

            while (!(double.TryParse(Console.ReadLine(), out trianguloAltura)))
            {
                Console.WriteLine("Error , Ingrese la Altura del triangulo");
            }

            //Circulo

            Console.WriteLine("Ingrese el Radio de un circulo");

            while (!(double.TryParse(Console.ReadLine(), out circuloRadio)))
            {
                Console.WriteLine("Error , Ingrese el Radio de un circulo");
            }



            Console.WriteLine("Area del cuadrado = " + CalculoDeArea.CalcularCuadrado(cuadrado));
            Console.WriteLine("Area del triangulo = " + CalculoDeArea.CalcularTriangulo(trianguloBase, trianguloAltura));
            Console.WriteLine("Area del circulo = " + CalculoDeArea.CalcularCirculo(circuloRadio));

            Console.ReadKey();

        }
    }
}