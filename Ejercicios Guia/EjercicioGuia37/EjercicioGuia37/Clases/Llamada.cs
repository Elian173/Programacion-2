using System.Text;

namespace BibliotecaClases
{
    public class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }

        #region Constructor

        public Llamada( float duracion, string nroDestino, string nroOrigen )
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        #endregion Constructor

        #region Propiedades

        public float Duracion
        {
            get
            {
                return this.duracion;
            }
        }

        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }

        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }

        #endregion Propiedades

        #region Metodos

        //orden
        public static int OrdenarPorDuracion( Llamada llamada1, Llamada llamada2 )
        {
            if (llamada1.Duracion > llamada2.Duracion)
            {
                return -1;
            }
            else if (llamada1.Duracion < llamada2.Duracion)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public string Mostrar()
        {
            StringBuilder texto = new StringBuilder();

            texto.AppendFormat("Duracion : {0} \n", this.Duracion);
            texto.AppendFormat("Destino : {0} \n", this.NroDestino);
            texto.AppendFormat("Origen : {0} \n", this.NroOrigen);

            return texto.ToString();
        }

        #endregion Metodos
    }
}