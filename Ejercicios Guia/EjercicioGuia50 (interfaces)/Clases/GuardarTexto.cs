using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class GuardarTexto <T,V> :IGuardar<T,V>
    {

        public bool Guardar (T obj)
        {
            return true;
        }

        public V Leer()
        {
            V texto;
            string mensaje = "Texto Leido";

            //??????
            texto = (V)Convert.ChangeType(mensaje, typeof(V));

            return texto;
        }

    }
}
