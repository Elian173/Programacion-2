using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public abstract class Producto
    {
        private Guid codigo;
        private string descripcion;
        private double precio;
        private int stock;


        #region Propiedades

        public string Descripcion
        {
            get { return this.descripcion; }
        }

        public double Precio
        {
            get { return this.precio; }
            set
            {
                if (value >= 1)
                { this.precio = value; }
            }
        }

        public int Stock
        {
            get { return this.stock; }

            set
            {
                if (value >= 0)
                {
                    this.stock = value;
                }
            }
        }


        #endregion

        #region Metodos

        protected Producto(string descripcion, int stock, double precio)
        {
            this.codigo = Guid.NewGuid();
            this.descripcion = descripcion;
            this.stock = stock;
            this.precio = precio;
        }

        public static explicit operator Guid(Producto p)
        {
            return p.codigo;
        }

        public override string ToString()
        {
            StringBuilder informacion = new StringBuilder();

            informacion.AppendFormat("Descripcion: {0} \n",this.descripcion);
            informacion.AppendFormat("Codigo: {0} \n", this.codigo);
            informacion.AppendFormat("Precio: ${0:C2} \n", this.precio);
            informacion.AppendFormat("Stock: {0} unidades\n", this.stock);

            return informacion.ToString();
        }



        #endregion
    }
}
