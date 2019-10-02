using System.Collections.Generic;
using System.Linq;

namespace Entidades
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        #region Constructor

        private Negocio()
        {
            this.clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(PuestoAtencion.Puesto.caja1);
        }

        public Negocio( string nombre ) : this()
        {
            this.nombre = nombre;
        }
        #endregion Constructor

        #region Propiedades

        public Cliente Cliente
        {
            get
            {
                return clientes.Dequeue();
            }

            set
            {
                if (!(clientes.Contains(value)))
                {
                    clientes.Enqueue(value);
                }
            }
        }

        public int ClientesPendientes
        {
            get
            {
                return clientes.Count();
            }
        }

        #endregion Propiedades

        #region Operadores

        public static bool operator ==( Negocio n, Cliente c )
        {
            if (n.clientes.Contains(c))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=( Negocio n, Cliente c )
        {
            if (!(n == c))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator +( Negocio n, Cliente c )
        {
            if (n != c)
            {
                n.Cliente = c;
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ~( Negocio n)
        {
            PuestoAtencion.Atender(n.Cliente);
            return true;
        }

        #endregion Operadores
    }
}