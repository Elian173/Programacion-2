using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosExtension
{
    public static class Extensiones
    {
        public static int CantidadPalabras(this string texto)
        {
            /*
            int cantidad = 1;
            foreach(char c in texto)
            {
                if(c == ' ')
                {
                    cantidad++;
                }
            }

            return cantidad;*/

            string[] palabras = texto.Split(' ');
            return palabras.Count();
        }

    }
}
