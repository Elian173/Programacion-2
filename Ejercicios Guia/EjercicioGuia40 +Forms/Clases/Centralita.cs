using System.Collections.Generic;
using System.Text;

/*CalcularGanancia será privado. Este método recibe un Enumerado TipoLlamada y retornará
el valor de lo recaudado, según el criterio elegido (ganancias por las llamadas del tipo Local,
Provincial o de Todas según corresponda).
m. El método Mostrar expondrá la razón social, la ganancia total, ganancia por llamados locales
y provinciales y el detalle de las llamadas realizadas.
n. La lista sólo se inicializará en el constructor por defecto Centralita().
o. Las propiedades GananciaPorTotal, GananciaPorLocal y GananciaPorProvincial retornarán el
precio de lo facturado según el criterio. Dichos valores se calcularán en el método
CalcularGanancia().
Generar un nuevo proyecto del tipo Console Application llamado Test. El namespace también
deberá llamarse Test. Agregar el siguiente código en el Main para probar la Centralita.*/

namespace BibliotecaClases
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        #region Constructor

        public Centralita( string razonSocial )
        {
            this.listaDeLlamadas = new List<Llamada>();
            this.razonSocial = razonSocial;
        }

        #endregion Constructor

        #region Propiedades

        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }

        public float GananciaPorLocal
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }

        public float GananciaPorTotal
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }

        public float GananciaPorProvincial
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }

        #endregion Propiedades

        #region Metodos

        private float CalcularGanancia( Llamada.TipoLlamada tipo )
        {
            float ganancia = 0;

            foreach (Llamada llamada in listaDeLlamadas)
            {
                if (tipo == Llamada.TipoLlamada.Local)
                {
                    if (llamada is Local)
                        ganancia += ((Local) llamada).CostoLlamada;
                }

                if (tipo == Llamada.TipoLlamada.Provincial)
                {
                    if (llamada is Provincial)
                        ganancia += ((Provincial) llamada).CostoLlamada;
                }

                if (tipo == Llamada.TipoLlamada.Todas)
                {
                    if (llamada is Local)
                        ganancia += ((Local) llamada).CostoLlamada;
                    if (llamada is Provincial)
                        ganancia += ((Provincial) llamada).CostoLlamada;
                }
            }

            return ganancia;
        }

        private string Mostrar()
        {
            StringBuilder texto = new StringBuilder();

            texto.AppendFormat("Central : {0}\n", this.razonSocial);

            foreach (Llamada llamada in listaDeLlamadas)
            {
                texto.Append(llamada.ToString()); // override toString Local y Provincial
            }

            return texto.ToString(); // toString comun
        }

        public void OrdenarLlamadas()
        {
            listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        private void AgregarLlamada( Llamada nuevaLlamada )
        {
            this.listaDeLlamadas.Add(nuevaLlamada);
        }

        public override string ToString()
        {
            return Mostrar();
        }

        #endregion Metodos

        #region Sobrecarga operadores

        public static bool operator ==( Centralita c, Llamada llamada )
        {
            /*
            if (c.listaDeLlamadas.Contains(llamada))
            {
                return true;
            }
            else
            {
                return false;
            }
            */

            foreach (Llamada l in c.listaDeLlamadas)
            {
                if (l == llamada)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=( Centralita c, Llamada llamada )
        {
            if (!(c == llamada))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Centralita operator +( Centralita c, Llamada llamada )
        {
            if (c != llamada)
            {
                c.AgregarLlamada(llamada);
            }

            return c;
        }

        #endregion Sobrecarga operadores
    }
}