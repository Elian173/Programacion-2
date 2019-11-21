using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComiqueriaLogic;

namespace ComprobantesLogic
{
    public class Factura: Comprobante
    {
        public enum TipoFactura
        {
            A, B, C, D
        }

        private TipoFactura tipoFactura;
        private DateTime fechaVencimiento;

        #region Constructor
        public Factura( Venta venta, int diasParaVencimiento, TipoFactura tipoFactura ) : base(venta)
        {
            this.tipoFactura = tipoFactura;
            this.fechaVencimiento = DateTime.Today.AddDays(diasParaVencimiento);
        }
        public Factura( Venta venta, TipoFactura tipoFactura ) : this(venta, 15, tipoFactura)
        {
        }


        #endregion

        #region Propiedades


        #endregion

        #region Metodos

        public override bool Equals( object obj )
        {
            if (base.Equals(obj) && obj is Factura)
            {
                if (((Factura) obj).tipoFactura == this.tipoFactura)
                {
                    return true;
                }

            }

            return false;

        }

        public override string GenerarComprobante()
        {

            StringBuilder descripcion = new StringBuilder();
            double precioUnitarioTotal = (((Producto) Venta).Precio) * this.Venta.Cantidad;
            double precioFinal = Venta.CalcularPrecioFinal(precioUnitarioTotal, this.Venta.Cantidad);


            descripcion.AppendFormat("Factura: {0}\n", this.tipoFactura);
            descripcion.AppendLine();
            descripcion.AppendFormat("Fecha emision: {0}\n", this.fechaEmision);
            descripcion.AppendFormat("Fecha vencimiento: {0}\n", this.fechaVencimiento);
            descripcion.AppendLine();
            descripcion.AppendFormat("Producto: {0}\n", (Producto) this.Venta);
            descripcion.AppendFormat("Cantidad: {0}\n", this.Venta.Cantidad);
            descripcion.AppendFormat("Precio unitario: {0:00}\n", ((Producto) Venta).Precio);
            descripcion.AppendLine();
            descripcion.AppendFormat("Precio unitario por la cantidad: {0}\n",precioUnitarioTotal) ;
            descripcion.AppendFormat("Importe IVA: {0}\n", precioFinal - precioUnitarioTotal);
            descripcion.AppendFormat("Importe TOTAL: {0}\n", precioFinal);


            return descripcion.ToString();
        }


        #endregion

    }
}
