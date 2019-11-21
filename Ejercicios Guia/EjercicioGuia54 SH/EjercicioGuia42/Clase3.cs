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
            catch (UnaException ex)
            {
                throw new MiException("clase3", ex);
            }
        }
    }
}