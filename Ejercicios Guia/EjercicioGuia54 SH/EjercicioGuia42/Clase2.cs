using System;

namespace EjercicioGuia42
{
    public class Clase2
    {
        public Clase2()
        {
            try
            {
                new Clase1();
            }
            catch (DivideByZeroException e)
            {
                throw new UnaException("Clas2", e);
            }
        }
    }
}