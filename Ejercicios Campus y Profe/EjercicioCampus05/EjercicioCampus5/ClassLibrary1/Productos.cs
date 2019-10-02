using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClaseEstante;

namespace ClaseProducto
{
    public class Producto
    {
        #region Atributos

        private string codigoDeBarra;
        private float precio;
        private string marca;


        #endregion

        #region Constructor

        public Producto(string marca, string codigoDeBarra, float precio)
        {
            this.codigoDeBarra = codigoDeBarra;
            this.precio = precio;
            this.marca = marca;
        }

        #endregion

        #region Metodos

        public string GetMarca()
        {
            return this.marca;
        }

        public float GetPrecio()
        {
            return this.precio;
        }

        //que muestre 2 decimales XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
        public static string MostrarProducto(Producto p)
        {

            string mostrar = string.Empty;
            mostrar += String.Format("Marca :{0}\n", p.GetMarca());
            mostrar += String.Format("Precio:{0}\n", p.GetPrecio());
            mostrar += String.Format("Codigo de barra:{0:#.00}\n", p.codigoDeBarra);
            return mostrar;

        }

        //sobrecargas

        //explicita
        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }

        // implicitas
        public static bool operator == (Producto a, Producto b)
        {
            if(a is null || b is null)
            {
                return false;
            }

            if (a.codigoDeBarra == b.codigoDeBarra && a.marca == b.marca)
            {

                return true;

            }
            else
            {

                return false;

            }



        }


        public static bool operator !=(Producto a, Producto b)
        {

            if (!((a.codigoDeBarra == b.codigoDeBarra) && (a.marca == b.marca)))
            {

                return true;

            }
            else
            {

                return false;

            }
        }

        #endregion

    }
}

