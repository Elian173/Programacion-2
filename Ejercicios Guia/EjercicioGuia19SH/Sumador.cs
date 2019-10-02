using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioGuia19
{
    public class Sumador
    {

        int cantidadSumas;

        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
            return;
        }

        public Sumador()
        {
            this.cantidadSumas = 0;
            return;
        }


        long Sumar(long a , long b)
        {
            this.cantidadSumas++;
            long total = a + b;
            return total;
        }

        string Sumar(string a, string b)
        {
            this.cantidadSumas++;
            string total = a + b;
            return total;
        }



    }
}
