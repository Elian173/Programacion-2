/*Puesto Atención:
a. numeroActual es estático y privado. Se inicializará en el constructor de clase con valor 0.
b. El método Atender simulará un tiempo de atención a un cliente: recibirá un cliente, simulará
un tiempo de atención mediante el método de clase Sleep de la clase Thread (perteneciente
al espacio de nombre System.Threading) y retornará true para indicar el final de la atención.
c. NumeroActual es una propiedad estática, encargada de incrementar en 1 al atributo
numeroActual y luego retornarlo.*/

//ACA TA TODO MAL PUESTO ES UN TYPE
namespace Entidades
{
    public class PuestoAtencion
    {
        private static int numeroActual;

        public enum Puesto { caja1, caja2 };

        private Puesto puesto;

        #region Constructores

        static PuestoAtencion()
        {
            numeroActual = 0;
        }

        public PuestoAtencion( Puesto puesto )
        {
            this.puesto = puesto;
        }

        #endregion Constructores

        #region Propiedades

        public static int NumeroActual
        {
            get
            {
                PuestoAtencion.numeroActual++;
                return PuestoAtencion.numeroActual;
            }
        }

        #endregion Propiedades

        #region Metodos

        public static bool Atender( Cliente cliente )
        {
            System.Threading.Thread.Sleep(1000);
            return true;
        }

        #endregion Metodos
    }
}