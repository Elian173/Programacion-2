using System.Text;

namespace Entidades
{
    public class Cerveza: Botella
    {
        private const int MEDIDA = 330;
        private Tipo tipo;

        #region Constructores

        /// <summary>
        /// Constructor entidades tipo "Cerveza"
        /// </summary>
        /// <param name="marca">Nombre de la marca</param>
        /// <param name="capacidadML">Capacidad maxima de la botella</param>
        /// <param name="contenidoML">Contenido en ml de la botella</param>
        /// <param name="tipo">Vidrio o Plastico</param>
        public Cerveza( string marca, int capacidadML, int contenidoML, Tipo tipo ) : base(marca, capacidadML, contenidoML)
        {
            this.tipo = tipo;
        }

        /// <summary>
        /// Constructor entidades tipo "Cerveza" , Se asigna tipo Vidrio por defecto.
        /// </summary>
        /// <param name="marca">Nombre de la marca</param>
        /// <param name="capacidadML">Capacidad maxima de la botella</param>
        /// <param name="contenidoML">Contenido en ml de la botella</param>
        public Cerveza( string marca, int capacidadML, int contenidoML ) : this(marca, capacidadML, contenidoML, Tipo.Vidrio)
        {
        }

        #endregion Constructores

        #region Metodos

        /// <summary>
        /// Genera un informe con todos los datos de la botella de cerveza.
        /// </summary>
        /// <returns></returns>
        protected new string GenerarInforme()
        {
            StringBuilder descripcion = new StringBuilder();

            descripcion.Append("Cerveza\n");
            descripcion.AppendFormat("{0}\n", base.GenerarInforme());
            descripcion.AppendFormat("Medida por defecto {0}\n", Cerveza.MEDIDA);
            descripcion.AppendFormat("Tipo botella {0}\n", this.tipo);

            return descripcion.ToString();
        }

        /// <summary>
        /// Sirve el 80% de 330 Ml (264ml) , retorna el contenido restante
        /// </summary>
        /// <returns></returns>
        public override int ServirMedida()
        {
            int medidaNueva = (int) (MEDIDA * 0.8);

            if (medidaNueva <= this.contenidoML)
            {
                this.contenidoML = (this.contenidoML - medidaNueva);
            }
            else if (medidaNueva > this.contenidoML)
            {
                this.contenidoML = 0;
            }

            return this.contenidoML;
        }

        /// <summary>
        /// Especifica el tipo de botella del objeto cerveza indicado
        /// </summary>
        /// <param name="cerveza"></param>
        public static implicit operator Botella.Tipo( Cerveza cerveza )
        {
            return cerveza.tipo;
        }

        #endregion Metodos
    }
}