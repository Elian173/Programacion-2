using System;

namespace EjercicioGuia42
{
    public class UnaException: Exception
    {
        public UnaException( string mensaje, Exception innerException ) : base(mensaje, innerException)
        {
        }
    }
}