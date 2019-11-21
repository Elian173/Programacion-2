using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//falta ordenar por fecha AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
namespace ComiqueriaLogic
{
    public class Comiqueria
    {
        List<Producto> productos;
        List<Venta> ventas;

        #region Indexador

        public Producto this[Guid codigo]
        {
            get
            {
                foreach (Producto productoX in productos)
                {
                    if ((Guid)productoX == codigo)
                    {
                        return productoX;
                    }
                }
                return null;
            }
        }

        #endregion

        #region Metodos
        public Comiqueria()
        {
            this.productos = new List<Producto>();
            this.ventas = new List<Venta>();
        }

        public void Vender(Producto producto)
        {
            Vender(producto, 1);
        }

        public void Vender(Producto producto, int cantidad)
        {
            Venta nuevaVenta = new Venta(producto, cantidad);
            this.ventas.Add(nuevaVenta);
        }

        public string ListarVentas()
        {
            StringBuilder descripciones = new StringBuilder();

            //this.ventas.Sort(DateTime.Compare());

            this.ventas = this.ventas.OrderBy(ventaX => ventaX.Fecha).ToList();

            foreach (Venta venta in this.ventas)
            {
                descripciones.AppendLine(venta.ObtenerDescripcionBreve());
            }

            return descripciones.ToString();
        }

        public Dictionary<Guid, string> ListarProductos()
        {
            Dictionary<Guid, string> listaProductos = new Dictionary<Guid, string>();

            foreach (Producto producto in this.productos)
            {
                listaProductos.Add((Guid)producto, producto.Descripcion);
            }

            return listaProductos;

        }

        #endregion

        #region Sobrecarga operadores

        public static bool operator ==(Comiqueria comiqueria, Producto producto)
        {
            foreach (Producto productoX in comiqueria.productos)
            {
                if (productoX.Descripcion == producto.Descripcion)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(Comiqueria comiqueria, Producto producto)
        {
            if (!(comiqueria == producto))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Comiqueria operator +(Comiqueria comiqueria, Producto producto)
        {

            if (comiqueria != producto)
            {
                comiqueria.productos.Add(producto);
            }

            return comiqueria;

        }

        #endregion
    }
}
