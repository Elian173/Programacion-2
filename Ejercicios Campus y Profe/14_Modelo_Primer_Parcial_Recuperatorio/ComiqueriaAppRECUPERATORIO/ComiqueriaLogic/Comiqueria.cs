using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComprobantesLogic;

//falta ordenar por fecha AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
namespace ComiqueriaLogic
{
    public class Comiqueria
    {
        private List<Producto> productos;
        public List<Venta> ventas;           //SOLO PARA TEST PUBLIC
        public static Stack<Comprobante> comprobantes; //SOLO PARA TEST PUBLIC

        #region Indexadores

        public Producto this[Guid codigo]
        {
            get
            {
                foreach (Producto productoX in productos)
                {
                    if ((Guid) productoX == codigo)
                    {
                        return productoX;
                    }
                }
                return null;
            }
        }
        /*Tendrá un indexador de solo lectura que recibirá como parámetro un Producto y un booleano.
         * Devolverá una List<Comprobante> con los comprobantes correspondientes a ese producto 
         * (comparar los códigos de los productos, el que recibe como parámetro y el de la venta del comprobante).
         * Si el booleano es true la lista deberá estar ordenada por fecha de emisión (misma fecha de la venta) de
         * la más antigua a la más reciente, sino deberá mostrarse tal como lo devuelve la pila.*/

        public List<Comprobante> this[Producto producto, bool ordenar]
        {
            get
            {
                List<Comprobante> nuevaLista = new List<Comprobante>();

                foreach (Comprobante comprobante in comprobantes)
                {
                    if ((Guid) ((Producto) comprobante.Venta) == (Guid) producto)
                    {
                        nuevaLista.Add(comprobante);
                    }
                }

                if (ordenar == true)
                {
                    nuevaLista = nuevaLista.OrderBy(o => o.Venta.Fecha).ToList();
                }

                return nuevaLista;

            }
        }


        #endregion

        #region Metodos

        static Comiqueria()
        {
            Comiqueria.comprobantes = new Stack<Comprobante>();
        }

        public Comiqueria()
        {
            this.productos = new List<Producto>();
            this.ventas = new List<Venta>();
        }


        public void Vender( Producto producto )
        {
            Vender(producto, 1);
        }

        public void Vender( Producto producto, int cantidad )
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
                listaProductos.Add((Guid) producto, producto.Descripcion);
            }

            return listaProductos;

        }

        public bool AgregarComprobante( Comprobante comprobante )
        {

            if (this != comprobante)
            {
                Comiqueria.comprobantes.Push(comprobante);
                return true;
            }
            return false;
        }


        //SOLO PARA TEST PUBLIC
        public bool AgregarComprobante( Venta venta )
        {
            Factura factura = new Factura(venta, Factura.TipoFactura.B);
            this.AgregarComprobante(factura);
            return true;
        }
             
        #endregion

        #region Sobrecarga operadores

        public static bool operator ==( Comiqueria comiqueria, Producto producto )
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

        public static bool operator !=( Comiqueria comiqueria, Producto producto )
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

        public static Comiqueria operator +( Comiqueria comiqueria, Producto producto )
        {

            if (comiqueria != producto)
            {
                comiqueria.productos.Add(producto);
            }

            return comiqueria;

        }

        public static bool operator ==( Comiqueria comiqueria, Comprobante comprobante )
        {

                if (Comiqueria.comprobantes.Contains(comprobante))
                {
                    return true;
                }

            return false;
        }

        public static bool operator !=( Comiqueria comiqueria, Comprobante comprobante )
        {
                if (!(comiqueria == comprobante))
                {
                    return true;
                }

            return false;
        }

        #endregion

    }
}
