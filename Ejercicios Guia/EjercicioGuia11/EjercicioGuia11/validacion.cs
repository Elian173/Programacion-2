using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioGuia11
{
    public class Validacion
    {
        public Int32 valor;
        public Int32 min;
        public Int32 max;

        public static bool Validar(int valor, int min, int max)
        {
            bool esValido = false;

            if (valor < max && valor > min)
            {
                esValido = true;
            };

            return esValido;
        }
    }
}
