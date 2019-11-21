using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos

{
    //Delegado:
    public delegate void DelegadoString( string x );

    public class Persona
    {
        #region Atributos
        private string nombre;

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                if (this.EventoString != null)
                {
                    if (value != this.nombre)
                    {
                        EventoString.Invoke("Se modifico nombre");
                    }

                    this.nombre = value;

                }
            }
        }

        private string apellido;

        public string Apellido
        {
            get
            {
                return apellido;
            }
            set
            {
                if (this.EventoString != null)
                {
                    if (value != this.apellido)
                    {
                        EventoString.Invoke("Se modifico apellido");
                    }

                    this.apellido = value;

                }
            }
        }
        #endregion

        //evento
        public event DelegadoString EventoString;

        #region Metodos

        public Persona()
        {
            this.nombre = string.Empty;
            this.Apellido = string.Empty;
        }

        public string Mostrar()
        {
            StringBuilder desc = new StringBuilder();
            desc.AppendFormat("Nombre : {0} , Apellido {1} \n", Nombre, Apellido);

            if (this.EventoString != null)
            {
                EventoString.Invoke(desc.ToString());
            }

            return desc.ToString();
        }

        #endregion
    }


}
