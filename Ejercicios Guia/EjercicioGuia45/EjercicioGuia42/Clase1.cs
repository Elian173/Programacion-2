using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioGuia42
{
    public class Clase1
    {
        public Clase1()
        {
            try
            {
                LanzarDividedByZero();
            }
            catch(DivideByZeroException ex)
            {
                throw ex;
            }
        }



        public static void LanzarDividedByZero()
        {

            throw new DivideByZeroException();

        }

    }
}
