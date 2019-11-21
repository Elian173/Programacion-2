using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComiqueriaLogic;

namespace ComprobantesLogic
{
    public abstract class Comprobante
    {
        protected DateTime fechaEmision;
        private Venta venta;

        #region Constructor

        protected Comprobante( Venta venta )
        {
            this.fechaEmision = venta.Fecha;
            this.venta = venta;
        }

        #endregion

        #region Propiedades

        internal Venta Venta
        {
            get
            {
                return this.venta;
            }
        }


        #endregion


        #region Metodos

        public abstract string GenerarComprobante();

        public override bool Equals( object obj )
        {
            if (!(obj is null))
            {
                if (obj is Comprobante)
                {
                    if (((Comprobante) obj).fechaEmision == this.fechaEmision)
                    {
                        return true;
                    };
                }
            }
            return false;
        }

        #endregion



    }
}
