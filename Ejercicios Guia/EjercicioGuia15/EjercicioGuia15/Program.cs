using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Realizar un programa que permita realizar operaciones matemáticas simples (suma, resta,
multiplicación y división). Para ello se le debe pedir al usuario que ingrese dos números y la
operación que desea realizar (pulsando el caracter +, -, * ó /).
El usuario decidirá cuándo finalizar el programa.
Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):
a. Calcular (público): Recibirá tres parámetros, el primer número, el segundo número y la
operación matemática. El método devolverá el resultado de la operación.
b. Validar (privado): Recibirá como parámetro el segundo número. Este método se debe
utilizar sólo cuando la operación elegida sea la DIVISIÓN. Este método devolverá
TRUE si el número es distinto de CERO.
*/
namespace EjercicioGuia15
{
    class Program
    {
        static void Main(string[] args)
        {
            double numeroA, numeroB;
            char operador;
            char continua = 's';
            double resultado = new double();

            while (continua == 's')
            {

                //primer numero
                Console.WriteLine("Ingrese el primer numero a operar");

                while (!(double.TryParse(Console.ReadLine(), out numeroA)))
                {
                    Console.WriteLine("Error , Ingrese el primer numero a operar");


                }

                //segundo numero
                Console.WriteLine("Ingrese el segundo numero a operar");

                while (!(double.TryParse(Console.ReadLine(), out numeroB)))
                {
                    Console.WriteLine("Error , Ingrese el segundo numero a operar");
                }


                //operador
                Console.WriteLine("Ingrese el operador");

                while (!Calculadora.ValidOperationSign(operador = Convert.ToChar(Console.ReadLine())))
                {
                    Console.WriteLine("Error , Ingrese un operador valido");
                }

                if (resultado == 0 && operador == '/')
                {
                    Console.WriteLine("Se intento dividir por 0");
                }

                resultado = Calculadora.Calcular(numeroA , numeroB , operador);

                Console.WriteLine("Resultado: "+ resultado );

                Console.WriteLine("Hacer otra operacion? S , si , otra cosa No");
                continua = Convert.ToChar(Console.ReadLine());

            }

        }

    }
}
