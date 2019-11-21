using System;

namespace EjercicioGuia42
{
    public class MiException: Exception
    {
        public MiException( string mensaje, Exception innerException ) : base(mensaje, innerException)
        {
        }
    }
}