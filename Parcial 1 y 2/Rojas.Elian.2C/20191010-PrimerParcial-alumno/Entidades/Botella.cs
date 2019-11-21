using System.Text;

namespace Entidades
{
    public abstract class Botella
    {
        protected int capacidadML;
        protected int contenidoML;
        protected string marca;

        public enum Tipo { Plastico, Vidrio };

        #region Constructores

        /// <summary>
        /// Constructor heredable de tipo Botella , si el contenido supera a la capacidad,
        /// el contenido asignado sera igual a la capacidad total de la botrlla
        /// </summary>
        /// <param name="marca">Nombre de la marca</param>
        /// <param name="capacidadML">Capacidad maxima de la botella</param>
        /// <param name="contenidoML">Contenido en ml de la botella</param>
        protected Botella( string marca, int capacidadML, int contenidoML )
        {
            if (capacidadML < contenidoML)
            {
                contenidoML = capacidadML;
            }

            this.marca = marca;
            this.capacidadML = capacidadML;
            this.contenidoML = contenidoML;
        }

        #endregion Constructores

        #region Propiedades

        /// <summary>
        /// Devuelve el equivalente el litros de la capacidad de la botella
        /// </summary>
        public int Capacidadlitros
        {
            get
            {
                return this.capacidadML / 1000;
            }
        }

        /// <summary>
        /// Devuelve o asigna el contenido a la botella
        /// </summary>
        public int Contenido
        {
            get
            {
                return this.contenidoML;
            }
            set
            {
                this.contenidoML = value;
            }
        }

        /// <summary>
        /// Devuelve el valor en porcentaje de la botella.
        /// </summary>
        public float PorcentajeContenido
        {
            get
            {
                float porcentaje = contenidoML*100 / capacidadML;

                return porcentaje;
            }
        }

        #endregion Propiedades

        #region Metodos

        public abstract int ServirMedida();

        /// <summary>
        /// Genera un informe con todos los datos de la botella.
        /// </summary>
        /// <returns></returns>
        public string GenerarInforme()
        {
            StringBuilder descripcion = new StringBuilder();
            descripcion.AppendFormat("Capacidad (ML){0}\n", this.capacidadML);
            descripcion.AppendFormat("Contenido (ML) {0}\n", this.contenidoML);
            descripcion.AppendFormat("Porcentaje contenido %{0}\n", this.PorcentajeContenido);

            return descripcion.ToString();
        }

        /// <summary>
        /// Genera un informe con todos los datos de la botella.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return GenerarInforme();
        }

        #endregion Metodos
    }
}