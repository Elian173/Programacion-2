using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billetes;


namespace EjercicioGuia20a
{
    class Program
    {
        static void Main( string[] args )
        {

            //Cotizaciones->
            new Dolar(1, 1);
            new Peso(1, 0.5);
            new Euro(1, 2);
            Console.WriteLine("Dolar =  1 , Peso igual 1/2 Dolar , Euro = 2 Dolares");



            #region Prueba constructores

            /*
             * 
             * 

            //Prueba constructores-
            //DOLAR

            Dolar dolarA = new Dolar();
            Console.WriteLine("DOLAR VACIO Cantidad: {0}  Cotizacion(static) {1}", dolarA.GetCantidad(), Dolar.GetCotizacion());

            Dolar dolarB = new Dolar(100);
            Console.WriteLine("DOLAR solo CANT(100) Cantidad: {0}  Cotizacion(static) {1}", dolarB.GetCantidad(), Dolar.GetCotizacion());

            Dolar dolarC = new Dolar(110, 5.3);
            Console.WriteLine("DOLAR CANT(110) Cantidad: {0}  Cotizacion (5,3) (static) {1}", dolarC.GetCantidad(), Dolar.GetCotizacion());

            Console.WriteLine("DOLAR A denuevo Cantidad: {0}  Cotizacion(static) {1}", dolarA.GetCantidad(), Dolar.GetCotizacion());

            */

            /*
            //Prueba constructores-
            //Euro

            Euro euroA = new Euro();
            Console.WriteLine("Euro VACIO Cantidad: {0}  Cotizacion(static) {1}", euroA.GetCantidad(), Euro.GetCotizacion());

            Euro euroB = new Euro(100);
            Console.WriteLine("Euro solo CANT(100) Cantidad: {0}  Cotizacion(static) {1}", euroB.GetCantidad(), Euro.GetCotizacion());

            Euro euroC = new Euro(110, 5.3);
            Console.WriteLine("Euro CANT(110) Cantidad: {0}  Cotizacion (5,3) (static) {1}", euroC.GetCantidad(), Euro.GetCotizacion());

            Console.WriteLine("Euro A denuevo Cantidad: {0}  Cotizacion(static) {1}", euroA.GetCantidad(), Euro.GetCotizacion());
            */


            /*

            //Prueba constructores-
            //PESO

            Peso pesoA = new Peso();
            Console.WriteLine("Peso VACIO Cantidad: {0}  Cotizacion(static) {1}", pesoA.GetCantidad(), Peso.GetCotizacion());

            Peso pesoB = new Peso(100);
            Console.WriteLine("Peso solo CANT(100) Cantidad: {0}  Cotizacion(static) {1}", pesoB.GetCantidad(), Peso.GetCotizacion());

            Peso pesoC = new Peso(110, 3.1);
            Console.WriteLine("Peso CANT(110) Cantidad: {0}  Cotizacion (3,1) (static) {1}", pesoC.GetCantidad(), Peso.GetCotizacion());

            
            Console.WriteLine("Peso A denuevo Cantidad: {0}  Cotizacion(static) {1}", pesoA.GetCantidad(), Peso.GetCotizacion());

            */

            #endregion



            #region Prueba de casteo

            Console.WriteLine("+++++++++Prueba casteo++++++++++++++++++");
            //Dolar A Pesos y peso a dolar

            Dolar dolarX = new Dolar(100);
            Peso pesoX = new Peso(1000);
            Euro euroX = new Euro(2000);


            Euro pesoEnEuros;
            Euro dolarEnEuros;
            Dolar euroEnDolares;
            Peso euroEnPesos;
            Dolar pesoEnDolares;
            Peso dolarEnPesos;

            Console.WriteLine("CANTIDADES : ");
            Console.WriteLine("Dolar : {0} , Cotiz : {1}", dolarX.GetCantidad(),Dolar.GetCotizacion());
            Console.WriteLine("Peso : {0} , Cotiz : {1}", pesoX.GetCantidad(),Peso.GetCotizacion());
            Console.WriteLine("Euro : {0} , Cotiz : {1} ", euroX.GetCantidad(),Euro.GetCotizacion());


            Console.WriteLine();
            

            pesoEnDolares = (Dolar) pesoX;
            euroEnDolares = (Dolar) euroX;
            Console.WriteLine("Peso en Dolares {0}", pesoEnDolares.GetCantidad());
            Console.WriteLine("Euro en Dolares {0}", euroEnDolares.GetCantidad());

            Console.WriteLine();

            dolarEnPesos = (Peso) dolarX;
            euroEnPesos = (Peso) euroX;
    
            Console.WriteLine("Dolar en Pesos {0}", dolarEnPesos.GetCantidad());
            Console.WriteLine("Euro en Pesos {0}", euroEnPesos.GetCantidad());

            Console.WriteLine();

            pesoEnEuros = (Euro) pesoX;
            dolarEnEuros = (Euro) dolarX;

            Console.WriteLine("Peso en Euros {0}", pesoEnEuros.GetCantidad());
            Console.WriteLine("Dolar en Euros {0}", dolarEnEuros.GetCantidad());

            Console.WriteLine();
            
            //Double a peso y dolar


            pesoX = 2100;
            dolarX = 2000;
            euroX = 2300;
            Console.WriteLine("dolar = double (2000): {0}", dolarX.GetCantidad());
            Console.WriteLine("peso = double (2100){0}", pesoX.GetCantidad());
            Console.WriteLine("euro = double (2300){0}", euroX.GetCantidad());



            #endregion



            #region Prueba de operadores ==
            /*
                        Console.WriteLine("++++++++++++++++PRUEBA OPERADORES == ++++++++++++++");

                        Peso a = new Peso(100);
                        Peso b = new Peso(100);
                        Peso c = new Peso(110);

                        Console.WriteLine("++++++++++++++++COMPARACION ENTRE MISMA CLASE ++++++++++++++");
                        Console.WriteLine("Peso A = {0} Peso B = {1} Peso C = {2}", a.GetCantidad() , b.GetCantidad() , c.GetCantidad()) ;
                        Console.WriteLine( "a = b {0}" ,a == b);
                        Console.WriteLine("a = c {0}", a == c);
                        Console.WriteLine("a != b {0}", a != b);
                        Console.WriteLine("a != c {0}", a != c);

                        Console.WriteLine("++++++++++++++++COMPARACION ENTRE DOLAR Y PESO ++++++++++++++");

                        Peso px = new Peso(1000 , 0.1);

                        Dolar dy = new Dolar(100);

                        Console.WriteLine( "Dolar = 100  , Pesos = 1000 , 1000 pesos son 100 dolares");
                        Console.WriteLine("DOLARS == PESOS :" + ( dy == px));
                        Console.WriteLine("DOLARS != PESOS :" + (dy != px));

                        Console.WriteLine("pesos == dolars :" + (px == dy));
                        Console.WriteLine("pesos != dolars :" + (px != dy));

             */
            #endregion



            #region Prueba de operadores +
            /*

                    Peso pa = new Peso(1000);
                    Peso pb = new Peso(1200);
                    Dolar da = new Dolar(100);
                    Dolar db = new Dolar(120);

                    Console.WriteLine("100 PESOS SON 1 DOLAR");
                    Console.WriteLine("PA = 1000 , PB = 1200 , DA = 100 , DB = 120");

                    Console.WriteLine("Suma entre pesos");

                    Console.WriteLine((pa + pb).GetCantidad());

                    Console.WriteLine("Suma entre dolares");
                    Console.WriteLine((da+db).GetCantidad());

                    Console.WriteLine();
                    Console.WriteLine("Dolar A + Peso A");
                    Console.WriteLine("EN DOLARES : {0}", (da+pa).GetCantidad() );
                    Console.WriteLine("Casting a PESOS : {0} " , ( (Peso)(da + pa) ).GetCantidad());
                    Console.WriteLine();
                    Console.WriteLine("Peso A + Dolar A");
                    Console.WriteLine("EN PESOS : {0}" , (pa + da).GetCantidad());
                    Console.WriteLine("Casting a DOLARES : {0}", ( (Dolar)(pa + da) ).GetCantidad());


            */
            #endregion



            #region Prueba de operadores -
            /*

            Peso pa = new Peso(1000);
            Peso pb = new Peso(1200);
            Dolar da = new Dolar(100);
            Dolar db = new Dolar(120);

            Console.WriteLine("100 PESOS SON 1 DOLAR");
            Console.WriteLine("PA = 1000 , PB = 1200 , DA = 100 , DB = 120");

            Console.WriteLine("Resta entre pesos");

            Console.WriteLine((pa - pb).GetCantidad());

            Console.WriteLine("Resta entre dolares");
            Console.WriteLine((da - db).GetCantidad());

            Console.WriteLine();
            Console.WriteLine("Dolar A - Peso A");
            Console.WriteLine("EN DOLARES : {0}", (da - pa).GetCantidad());
            Console.WriteLine("Casting a PESOS : {0} ", ((Peso) (da - pa)).GetCantidad());
            Console.WriteLine();
            Console.WriteLine("Peso A + Dolar A");
            Console.WriteLine("EN PESOS : {0}", (pa - da).GetCantidad());
            Console.WriteLine("Casting a DOLARES : {0}", ((Dolar) (pa - da)).GetCantidad());
            
            */
            #endregion




            Console.ReadKey();

        }
    }
}
