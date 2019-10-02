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
    public class Calculadora
    {

        public static double Calcular(double primerNumero, double segundoNumero, char operacion)
        {
            double resultado = new double();

            switch (operacion)
            {
                case '+':
                    resultado = primerNumero + segundoNumero;
                    break;
                case '-':
                    resultado = primerNumero - segundoNumero;
                    break;
                case '*':
                    resultado = primerNumero * segundoNumero;
                    break;
                case '/':
                    if( Validar(segundoNumero))
                    {
                        resultado = primerNumero / segundoNumero;
                        break;
                    }
                    resultado = 0;
                    break;
            }

            return resultado;

        }

        private static bool Validar(double segundoNumero)
        {
            if (segundoNumero != 0)
            {
                return true;
            }

            return false;
        }

        public static bool ValidOperationSign(char operacion)
        {

            if (operacion == '+' || operacion == '-' || operacion == '*' || operacion == '/')
            {
                return true;
            }

            return false;
        }

    }
}
