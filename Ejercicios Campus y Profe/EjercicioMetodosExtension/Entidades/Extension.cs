using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Extension
    {
        public static string ObtenerPlacaCronica(this DateTime dato, Estaciones estacion)
        {
            DateTime fechaActual = dato.Date;
            DateTime comienzoEstacion;
            
            switch (estacion)
            {
                case Estaciones.Verano:
                    comienzoEstacion = new DateTime(fechaActual.Year, 12, 21);
                    break;
                case Estaciones.Primavera:
                    comienzoEstacion = new DateTime(fechaActual.Year, 9, 21);
                    break;
                case Estaciones.Otonio:
                    comienzoEstacion = new DateTime(fechaActual.Year, 3, 21);
                    break;
                case Estaciones.Invierno:
                    comienzoEstacion = new DateTime(fechaActual.Year, 6, 21);
                    break;
                default:comienzoEstacion = new DateTime();
                    break;
            }

            if(fechaActual > comienzoEstacion)
            {
                comienzoEstacion = comienzoEstacion.AddYears(1);
                
            }

            double diasQueFaltan = (comienzoEstacion - fechaActual).TotalDays;

            return "Faltan " + diasQueFaltan + " dias";
        }

    }
}
