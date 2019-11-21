using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioGuia42
{
    public class Clase3
    {

        public void Metodo()
        {
            try
            {
                new Clase2();
            }
            catch(UnaException ex)
            {
                throw new MiException("clase3", ex);
            }

        }


    }
}
