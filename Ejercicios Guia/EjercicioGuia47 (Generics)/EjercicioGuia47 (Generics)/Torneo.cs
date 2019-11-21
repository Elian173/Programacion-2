using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioGuia47__Generics_
{
    public class Torneo<T> where T : Equipo
    {

        

        #region Atributos

        private List<T> equipos = new List<T>();
        private string nombre;

        public Torneo(string nombre)
        {
            this.nombre = nombre;
        }
        #endregion

        #region Propiedades

        public string JugarPartido
        {
            get
            {
                Random numeroRandom = new Random();

                Equipo equipo1 = this.equipos[numeroRandom.Next(0, this.equipos.Count)];
                Equipo equipo2 = this.equipos[numeroRandom.Next(0, this.equipos.Count)];

                while (equipo1 == equipo2)
                {
                    equipo2 = this.equipos[numeroRandom.Next(0, this.equipos.Count)];
                }


                return CalcularPartido<Equipo>(equipo1, equipo2);
            }
        }


        #endregion

        #region Metodos

        public string Mostrar()
        {
            StringBuilder descripcion = new StringBuilder();

            descripcion.AppendFormat("Torneo: {0}", this.nombre);
            descripcion.AppendLine();
            descripcion.AppendLine("Participantes:");
            descripcion.AppendLine();
            foreach (Equipo equipo in this.equipos)
            {
                descripcion.AppendFormat("{0} \n", equipo.Ficha());
            }

            return descripcion.ToString();

        }

        private string CalcularPartido<U>(U equipo1, U equipo2) where U : Equipo
        {
            StringBuilder descripcion = new StringBuilder();
            Random numeroRandom = new Random();
            int resultado1, resultado2;

            resultado1 = numeroRandom.Next(0, 5);
            resultado2 = numeroRandom.Next(0, 5);

            descripcion.Append("Resultados:");
            descripcion.AppendLine();
            descripcion.AppendFormat("[{0}][{1}] - [{2}] [{3}]", equipo1.Nombre, equipo2.Nombre, resultado1, resultado2);

            return descripcion.ToString();
        }

        #endregion

        #region Sobrecarga operadores

        public static bool operator ==(Torneo<T> torneo, Equipo equipo)
        {
            if (torneo.equipos.Contains(equipo))
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(Torneo<T> torneo, Equipo equipo)
        {
            if (!(torneo == equipo))
            {
                return true;
            }

            return false;
        }

        public static Torneo<T> operator +(Torneo<T> torneo, T equipo)
        {

            if (torneo != equipo)
            {
                torneo.equipos.Add(equipo);
            }

            return torneo;

        }

    }


    #endregion


}
