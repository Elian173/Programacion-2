using System.Text;

namespace Entidades
{
    public class Agua: Botella
    {
        private const int MEDIDA = 400;

        #region Constructor

        /// <summary>
        /// Constructor de entidades tipo "AGUA"
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="capacidadML"></param>
        /// <param name="contenidoML"></param>
        public Agua( string marca, int capacidadML, int contenidoML ) : base(marca, capacidadML, contenidoML)
        {
        }

        #endregion Constructor

        #region Metodos

        /// <summary>
        /// Resta una medida al contenido de la botella de agua.
        /// </summary>
        /// <param name="medida">Es la medida a restar</param>
        /// <returns></returns>
        public int ServirMedida( int medida )
        {
            if (medida <= this.contenidoML)
            {
                this.contenidoML = (this.contenidoML - medida);
            }
            else if (medida > this.contenidoML)
            {
                this.contenidoML = 0;
            }

            return this.contenidoML;
        }

        /// <summary>
        /// Resta 400 al contenido de la botella
        /// </summary>
        /// <returns></returns>
        public override int ServirMedida()
        {
            return (this.ServirMedida(MEDIDA));
        }

        /// <summary>
        /// Genera un informe con todos los datos correspondientes a la botella de agua
        /// </summary>
        /// <returns></returns>
        protected new string GenerarInforme()
        {
            StringBuilder descripcion = new StringBuilder();

            descripcion.Append("Agua\n");
            descripcion.AppendFormat("{0}\n", base.GenerarInforme());
            descripcion.AppendFormat("Medida por defecto{0}\n", Agua.MEDIDA);

            return descripcion.ToString();
        }

        #endregion Metodos
    }
}