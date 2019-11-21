using System.Text;

namespace BibliotecaClases
{
    public class Local: Llamada , IGuardar<Local>
    {
        protected float costo;
        //Agrego esto ???'
        protected string rutaDeArchivo;

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

        public override float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        #endregion Propiedades

        #region Metodos

        #region Override

        public override bool Equals( object obj )
        {
            if (obj is Local)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        protected override string Mostrar()
        {
            StringBuilder texto = new StringBuilder();

            texto.Append("\nLlamada LOCAL \n");
            texto.Append(base.Mostrar());
            texto.AppendFormat("Costo:{0:0.00} \n", this.CostoLlamada);

            return texto.ToString();
        }

        public override string ToString()
        {
            return Mostrar();
        }

        #endregion Override

        private float CalcularCosto()
        {
            return (this.costo * Duracion);
        }

        #endregion Metodos

        #region Interfaz
        public string RutaDeArchivo
        {
            get { return this.rutaDeArchivo; }

            //?????
            //meto una variable ruta de archivo porque no se que quiere el ej
            set { this.rutaDeArchivo = value; }
        }

        public bool Guardar(Local obj)
        {
            // guardar datos? 
            throw new System.NotImplementedException();
        }

        public Local Leer()
        {
            //Leer lanzará la excepción NotImplementedException.
            throw new System.NotImplementedException();
        }

        #endregion

    }
}