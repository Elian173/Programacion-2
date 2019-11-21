using System.Collections.Generic;
using System.Linq;

namespace Entidades
{
    public class Cantina
    {
        private List<Botella> botellas;
        private int espaciosTotales;
        private static Cantina singleton = null;

        #region Constructor

        private Cantina( int espacios )
        {
            if (Cantina.singleton == null)
            {
                this.botellas = new List<Botella>();
            }
            this.espaciosTotales = espacios;
        }

        #endregion Constructor

        #region Propiedades

        public List<Botella> Botellas
        {
            get
            {
                return this.botellas;
            }
        }

        #endregion Propiedades

        #region Metodos

        public static Cantina GetCantina( int espacios )
        {
            if (Cantina.singleton is null)
            {
                Cantina.singleton = new Cantina(espacios);
                return Cantina.singleton;
            }
            else
            {
                Cantina.singleton.espaciosTotales = espacios;
                return Cantina.singleton;
            }
        }

        public static bool operator +( Cantina c, Botella b )
        {
            if (c.espaciosTotales > c.botellas.Count())
            {
                c.botellas.Add(b);
                return true;
            }

            return false;
        }

        #endregion Metodos
    }
}