using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Peso
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        #region Constructores


        public Peso()
        {
            //Peso.cotizRespectoDolar = 1 / 38.33;
            this.cantidad = 1;
        }

        public Peso( double cantidad ) : this()
        {
            this.cantidad = cantidad;
        }

        public Peso( double cantidad, double cotizacion ) : this(cantidad)
        {

            Peso.cotizRespectoDolar = cotizacion;

        }

        #endregion

        #region Getters


        public static double GetCotizacion()
        {
            return Peso.cotizRespectoDolar;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }
        #endregion


        #region Casting

        //PESO a DOLAR

        public static explicit operator Dolar( Peso p )
        {

            Dolar nuevoDolar = new Dolar(p.GetCantidad() * Peso.GetCotizacion());

            return nuevoDolar;

        }

        //PESO a EURO

        public static explicit operator Euro( Peso p )
        {

            Euro nuevoEuro = new Euro(p.GetCantidad() * Euro.GetCotizacion());

            return nuevoEuro;

        }


        //DOUBLE a PESO

        public static implicit operator Peso( double p )
        {

            Peso nuevoPeso = new Peso(p);

            return nuevoPeso;

        }

        #endregion

        #region Operadores igual:


        public static bool operator ==( Peso p1, Peso p2 )
        {
            if (p1.GetCantidad() == p2.GetCantidad())
            {
                return true;
            }

            return false;

        }

        public static bool operator !=( Peso p1, Peso p2 )
        {

            if (!(p1 == p2))
            {
                return true;
            }

            return false;

        }

        // Peso y dolares

        public static bool operator ==( Peso p, Dolar d )
        {
            return (p == (Peso) d);
        }

        public static bool operator !=( Peso p, Dolar d )
        {
            return (p != (Peso) d);
        }

        #endregion

        #region Operadores Suma


        //Peso con peso
        public static Peso operator +( Peso p1, Peso p2 )
        {
            Peso suma = new Peso(p1.GetCantidad() + p2.GetCantidad());
            return suma;
        }


        //peso con dolar 

        public static Peso operator +( Peso p, Dolar d )
        {
            return p + (Peso)d;
        }




        #endregion


        #region Operadores Resta


        //Peso con peso
        public static Peso operator -( Peso p1, Peso p2 )
        {
            Peso resta = new Peso(p1.GetCantidad() - p2.GetCantidad());
            return resta;
        }


        //peso con dolar 

        public static Peso operator -( Peso p, Dolar d )
        {
            return p - (Peso) d;
        }




        #endregion
    }
}
