using System.Text;

namespace BibliotecaClases
{
    public abstract class Llamada
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

        //Tendrá definida la propiedad de sólo lectura CostoLlamada que también será abstracta.
        public abstract float CostoLlamada
        {
            get;
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

        protected virtual string Mostrar()
        {
            StringBuilder texto = new StringBuilder();

            texto.AppendFormat("$LLAMADA$Duracion : {0} \n", this.Duracion);
            texto.AppendFormat("$LLAMADA$Destino : {0} \n", this.NroDestino);
            texto.AppendFormat("$LLAMADA$Origen : {0} \n", this.NroOrigen);

            return texto.ToString();
        }

        #endregion Metodos

        

        #region Sobrecarga operadores

        public static bool operator ==( Llamada l1, Llamada l2 )
        {
            if ((l1.nroDestino == l2.nroDestino) && (l1.nroOrigen == l2.nroOrigen) && (l1.Equals(l2)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=( Llamada l1, Llamada l2 )
        {
            if (!(l1 == l2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion Sobrecarga operadores
    }
}