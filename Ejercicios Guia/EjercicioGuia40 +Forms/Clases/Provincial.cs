using System.Text;

namespace BibliotecaClases
{
    public class Provincial: Llamada
    {
        public enum Franja { Franja_1, Franja_2, Franja_3 };

        protected Franja FranjaHoraria;

        #region Constructores

        public Provincial( string origen, Franja miFranja, float duracion, string destino ) : base(duracion, destino, origen)
        {
            this.FranjaHoraria = miFranja;
        }

        public Provincial( Franja miFranja, Llamada llamada ) : this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
        {
        }

        #endregion Constructores

        #region Propiedades

        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        #endregion Propiedades

        #region Metodos

        #region Override

        public override bool Equals( object obj )
        {
            if (obj is Provincial)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return Mostrar();
        }

        protected override string Mostrar()
        {
            StringBuilder texto = new StringBuilder();

            texto.Append("\nLlamada Provincial \n");
            texto.Append(base.Mostrar());
            texto.AppendFormat("Costo:{0:0.00} \n", this.CostoLlamada);
            texto.AppendFormat("{0}\n", this.FranjaHoraria);

            return texto.ToString();
        }

        #endregion Override

        private float CalcularCosto()
        {
            float costo;

            switch (this.FranjaHoraria)
            {
                case Franja.Franja_1:
                costo = 0.99f;
                break;

                case Franja.Franja_2:
                costo = 1.25f;
                break;

                case Franja.Franja_3:
                costo = 0.66f;
                break;

                default:
                return 0f;
            }

            return costo * duracion;
        }

        #endregion Metodos
    }
}