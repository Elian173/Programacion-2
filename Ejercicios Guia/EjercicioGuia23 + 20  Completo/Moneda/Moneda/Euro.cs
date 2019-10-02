using System;
using System.Collections.Generic;
using System.Text;

namespace Moneda
{
    public class Euro
    {


        private double cantidad;
        private static double cotizRespectoDolar;

        #region Constructores


        public Euro()
        {
            // Dolar.cotizRespectoDolar = 1;
            this.cantidad = 1;
        }


        public Euro( double cantidad ) : this()
        {
            this.cantidad = cantidad;
        }


        public Euro( double cantidad, double cotizacion ) : this(cantidad)
        {
            Euro.cotizRespectoDolar = cotizacion;
        }

        #endregion

        #region getters
        public static double GetCotizacion()
        {
            return Euro.cotizRespectoDolar;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }
        #endregion

        #region Casting

        /// <summary>
        /// Transforma un Euro a peso
        /// </summary>
        /// <param name="e"></param>
        /// 
        public static explicit operator Peso( Euro e )
        {

            Dolar auxDolar = new Dolar();
            Peso nuevoPeso = new Peso();

            auxDolar = (Dolar) e;

            nuevoPeso = (auxDolar.GetCantidad() * (1/Peso.GetCotizacion()));


            return nuevoPeso;


        }

        /// <summary>
        /// Transforma un Euro a DOLAR
        /// </summary>
        /// <param name="e"></param>
        public static explicit operator Dolar( Euro e )
        {

            Dolar nuevoDolar = new Dolar( e.GetCantidad() * (1/Euro.GetCotizacion()) );

            return nuevoDolar;

        }





        /// <summary>
        /// Transforma un Double a Dolares
        /// </summary>
        /// <param name="e"></param>
        public static implicit operator Euro( double e )
        {
            Euro nuevoDolar = new Euro(e);
            return nuevoDolar;
        }



        #endregion

        #region Operadores igual:


        public static bool operator ==( Euro e1, Euro e2 )
        {
            if (e1.GetCantidad() == e2.GetCantidad())
            {
                return true;
            }

            return false;

        }

        public static bool operator !=( Euro e1, Euro e2 )
        {

            if (!(e1 == e2))
            {
                return true;
            }

            return false;

        }


        //Dolar y pesos

        public static bool operator ==( Euro e, Peso p )
        {
            return (e == (Euro) p);
        }

        public static bool operator !=( Euro d, Peso p )
        {
            return (d != (Euro) p);
        }

        #endregion

        #region Operadores Suma


        //Dolar con Dolar
        public static Euro operator +( Euro e1, Euro e2 )
        {
            Euro suma = new Euro(e1.GetCantidad() + e2.GetCantidad());
            return suma;
        }

        //Dolar con Peso

        public static Euro operator +( Euro e, Peso p )
        {
            Euro suma = new Euro((e + (Euro) p).GetCantidad());
            return suma;
        }


        #endregion


        #region Operadores Resta


        //Dolar con Dolar
        public static Euro operator -( Euro e1, Euro e2 )
        {
            Euro resta = new Euro(e1.GetCantidad() - e2.GetCantidad());
            return resta;
        }

        //Dolar con Peso

        public static Euro operator -( Euro e, Peso p )
        {
            Euro resta = new Euro((e - (Euro) p).GetCantidad());
            return resta;
        }


        #endregion


        public static void SetCotizacion(double c)
        {
            new Euro(1, c);
        }





    }
}
