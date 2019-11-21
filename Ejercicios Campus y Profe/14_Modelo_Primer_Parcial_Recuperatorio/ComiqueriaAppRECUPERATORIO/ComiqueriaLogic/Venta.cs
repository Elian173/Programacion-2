using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public sealed class Venta
    {
        private DateTime fecha;
        private static int porcentajeIva;
        private double precioFinal;
        private Producto producto;
        private int cantidad; //recup

        #region Propiedades
        
        internal DateTime Fecha
        {
            get { return this.fecha; }
        }

        //recup
        public int Cantidad
        {
            get
            {
                return this.cantidad;
            }

        }
        #endregion

        #region Metodos

        static Venta()
        {
            porcentajeIva = 21;
        }

        internal Venta(Producto producto, int cantidad)
        {
            this.producto = producto;
            Vender(cantidad);
            this.cantidad = cantidad;//recup
        }

        private void Vender(int cantidad)
        {
            this.producto.Stock = this.producto.Stock - cantidad;
            this.fecha = DateTime.Now;
            this.precioFinal = CalcularPrecioFinal(producto.Precio, cantidad);
        }

        public static double CalcularPrecioFinal(double precioUnidad, int cantidad)
        {
            double total;
            total = (precioUnidad * cantidad);
            total = total + (total * (porcentajeIva / 100));
            return total;
        }

        public string ObtenerDescripcionBreve()
        {
            StringBuilder descripcion = new StringBuilder();
            descripcion.AppendFormat("{0} - {1} - ${2:0.00}", this.fecha, this.producto.Descripcion, this.precioFinal);
            return descripcion.ToString();
        }

        //recup

        public static explicit operator Producto(Venta venta)
        {
            return venta.producto;
        }
        //


        #endregion 


    }
}
