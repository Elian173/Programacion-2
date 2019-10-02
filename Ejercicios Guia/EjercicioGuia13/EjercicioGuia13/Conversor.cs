using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*

13. Desarrollar una clase llamada Conversor, que posea dos métodos de clase (estáticos):
string DecimalBinario(double). Convierte un número de entero a binario.
double BinarioDecimal(string). Convierte un número binario a entero

*/

namespace Entidades
{
    public class Conversor
    {

        public static string DecimalBinario( double number )
        {
            return Convert.ToString(BitConverter.DoubleToInt64Bits(number), 2);
        }


        public static double BinarioDecimal( string binary )
        {
            return BitConverter.Int64BitsToDouble(Convert.ToInt64(binary, 10));
        }

    }
}
