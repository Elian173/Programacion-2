using System.Text;

namespace BibliotecaClases
{
    public class Local: Llamada
    {
        protected float costo;

        #region Constructores

        /*
        public Local(Llamada llamada, float costo)
            : base (llamada.Duracion , llamada.NroDestino , llamada.NroOrigen)
        {
            this.costo = costo;
        }

        public Local(string origen, float duracion,string destino , float costo)
            :this (new Llamada(duracion, destino,origen),costo)
        {
        }
        */

        public Local( string origen, float duracion, string destino, float costo )
            : base(duracion, destino, origen)
        {
            this.costo = costo;
        }

        public Local( Llamada llamada, float costo )
            : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {
        }

        #endregion Constructores

        #region Propiedades

        public float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        #endregion Propiedades

        #region Metodos

        private float CalcularCosto()
        {
            return (this.costo * Duracion);
        }

        public string MostrarLocal()
        {
            StringBuilder texto = new StringBuilder();

            texto.Append("\nLlamada LOCAL \n");
            texto.Append(base.Mostrar());
            texto.AppendFormat("Costo:{0:0.00} \n", this.CostoLlamada);

            return texto.ToString();
        }

        #endregion Metodos
    }
}