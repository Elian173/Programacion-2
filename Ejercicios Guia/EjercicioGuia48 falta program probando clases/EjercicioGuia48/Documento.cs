using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioGuia48
{
    public class Documento
    {
        protected int numero;


        public int Numero
        {
            get
            {

                return this.numero;
            }
        }



        public Documento(int numero)
        {
            this.numero = numero;
        }

    }
}
