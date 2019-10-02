using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moneda;

namespace Moneda
{
    public class Dolar
    {

        private double cantidad;
        private static double cotizRespectoDolar;

        #region Constructores


        public Dolar()
        {
            // Dolar.cotizRespectoDolar = 1;
            this.cantidad = 1;
        }


        public Dolar( double cantidad ) : this()
        {
            this.cantidad = cantidad;
        }


        public Dolar( double cantidad, double cotizacion ) : this(cantidad)
        {
            Dolar.cotizRespectoDolar = cotizacion;
        }

        #endregion

        #region getters
        public static double GetCotizacion()
        {
            return Dolar.cotizRespectoDolar;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }
        #endregion

        #region Casting

        /// <summary>
        /// Transforma un Dolar a Pesos
        /// </summary>
        /// <param name="d"></param>
        public static explicit operator Peso( Dolar d )
        {

            Peso nuevoPeso = new Peso(d.GetCantidad() * (1/Peso.GetCotizacion()) );

            return nuevoPeso;

        }

        /// <summary>
        /// Transforma un Dolar a Euros
        /// </summary>
        /// <param name="d"></param>
        public static explicit operator Euro(Dolar d)
        {

            Euro nuevoEuro = new Euro(d.GetCantidad() * Euro.GetCotizacion());

            return nuevoEuro;

        }


        /// <summary>
        /// Transforma un Double a Dolares
        /// </summary>
        /// <param name="d"></param>
        public static implicit operator Dolar( double d )
        {
            Dolar nuevoDolar = new Dolar(d);
            return nuevoDolar;
        }


        #endregion

        #region Operadores igual:


        public static bool operator ==( Dolar d1, Dolar d2 )
        {
            if (d1.GetCantidad() == d2.GetCantidad())
            {
                return true;
            }

            return false;

        }

        public static bool operator !=( Dolar d1, Dolar d2 )
        {

            if (!(d1 == d2))
            {
                return true;
            }

            return false;

        }


        //Dolar y pesos

        public static bool operator ==( Dolar d, Peso p )
        {
            return (d == (Dolar) p);
        }

        public static bool operator !=( Dolar d, Peso p )
        {
            return (d != (Dolar) p);
        }

        #endregion

        #region Operadores Suma


        //Dolar con Dolar
        public static Dolar operator +( Dolar d1, Dolar d2 )
        {
            Dolar suma = new Dolar(d1.GetCantidad() + d2.GetCantidad());
            return suma;
        }

        //Dolar con Peso

        public static Dolar operator +( Dolar d, Peso p )
        {
            Dolar suma = new Dolar((d + (Dolar) p).GetCantidad());
            return suma;
        }


        #endregion


        #region Operadores Resta


        //Dolar con Dolar
        public static Dolar operator -( Dolar d1, Dolar d2 )
        {
            Dolar resta = new Dolar(d1.GetCantidad() - d2.GetCantidad());
            return resta;
        }

        //Dolar con Peso

        public static Dolar operator -( Dolar d, Peso p )
        {
            Dolar resta = new Dolar((d - (Dolar) p).GetCantidad());
            return resta;
        }


        #endregion

        public static void SetCotizacion( double c )
        {
            new Dolar(1, c);
        }

    }
}
