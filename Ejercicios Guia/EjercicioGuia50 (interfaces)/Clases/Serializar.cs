using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Serializar<S, V> : IGuardar<S, V>
    {
        public bool Guardar(S obj)
        {
            return true;
        }

        public V Leer()
        {
            V texto ;
            string mensaje = "Objeto Leido";

            //??????
            texto = (V)Convert.ChangeType(mensaje, typeof(V));

            return texto;
        }


    }
}
