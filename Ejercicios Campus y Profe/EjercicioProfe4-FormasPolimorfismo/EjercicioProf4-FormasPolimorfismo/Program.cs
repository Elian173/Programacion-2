using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
/*En el método Main:
a. Crear una lista de figuras.
b. Agregarle una figura de cada tipo.
c. Recorrer la lista mostrando el resultado del método Dibujar, el área y el
perímetro de cada figura, y el tipo (GetType())./
*/
namespace EjercicioProf4_FormasPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figura> figuras = new List<Figura>();

            Circulo circulo = new Circulo(10);
            Cuadrado cuadrado = new Cuadrado(10);
            Rectangulo rectangulo = new Rectangulo(10, 20);

            figuras.Add(circulo);
            figuras.Add(cuadrado);
            figuras.Add(rectangulo);
            int i = 1;

            foreach (Figura f in figuras)
            {
                Console.WriteLine("Figura {0}" , i);
                Console.WriteLine("Dibujar: {0}", f.Dibujar());
                Console.WriteLine("Tipo: {0}", f.GetType());
                Console.WriteLine("Perimetro: {0}", f.CalcularPerimetro());
                Console.WriteLine("Superficie: {0}", f.CalcularSuperficie());
                Console.WriteLine("___________________");
                i++;
            }

            Console.WriteLine("8. Responder para cada figura:");
            Console.WriteLine("a.Explicar el resultado del método Dibujar para cada caso.");
            Console.WriteLine("i. ¿Por qué el método Dibujar del cuadrado no muestra “Dibujando Cuadrado ?");
            Console.WriteLine("ii. ¿Por qué no muestra Dibujando Forma ?");
            Console.WriteLine("b. ¿Por qué la clase cuadrado no debe implementar el método Dibujar ? ¿Las");
            Console.WriteLine("otras clases están obligadas a hacerlo ?");
            Console.WriteLine("c. ¿Por qué la clase cuadrado no debe implementar el método");
            Console.WriteLine("CalcularSuperficie ? ¿Las otras clases están obligadas a hacerlo ? ");

            Console.ReadKey();
        }
    }
}
