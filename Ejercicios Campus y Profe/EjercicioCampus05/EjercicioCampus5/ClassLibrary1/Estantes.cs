using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClaseProducto;

namespace ClaseEstante
{
    public class Estante
    {

        private Producto[] productos;
        private int ubicacionEstante;


        #region Constructores 

        private Estante(int capacidad)
        {
            productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }

        #endregion

        #region metodos

        public Producto[] GetProductos()
        {
            return this.productos;
        }

        public static string MostrarEstante(Estante e)
        {
            string mostrar = string.Empty;

            mostrar += String.Format("Ubicacion del estante :{0}\n", e.ubicacionEstante);
            mostrar += String.Format("Productos:\n");

            for (int i = 0; i < e.productos.Length; i++)
            {

                mostrar += String.Format(ClaseProducto.Producto.MostrarProducto(e.productos[i]));

            }

            return mostrar;
        }

        #endregion

        #region sobrecargas

        public static bool operator ==(Estante e, Producto p)
        {
            int i;
            bool existe = false;

            for (i = 0; i < e.productos.Length; i++)
            {
                if (e.productos[i] == p)
                {
                    existe = true;
                    break;
                }
            }

            return existe;
        }

        public static bool operator !=(Estante e, Producto p)
        {

            if (!(e == p))
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        //adicion
        public static bool operator +(Estante e, Producto p)
        {

            bool noExiste = true;
            bool hayLugar = false;


            if (e == p) // el estante ya tiene el producto
            {
                noExiste = false;
            }

            else // el estante no tiene producto , veo si hay lugar

            {

                for (int i = 0; i < e.productos.Length; i++)
                {
                    if (e.productos[i] is null)
                    {
                        hayLugar = true;
                        e.productos[i] = p;
                        break;
                    }

                }

            }

            if (hayLugar == true && noExiste == true)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        //sustraccion
        //adicion
        public static Estante operator -(Estante e, Producto p)
        {

            bool Existe = true;

            if (e != p) // el estante no tiene ese producto
            {
                Existe = false;
            }
            else // el estante tiene ese producto , lo borro
            {
                for (int i = 0; i < e.productos.Length; i++)
                {
                    if (e.productos[i] == p)
                    {
                        e.productos[i] = null;
                        break;
                    }
                }

            }


            if (Existe == true)
            {
                return e;
            }
            else
            {
                return null;
            }





        }
        #endregion


    }


}
