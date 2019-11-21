using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class CentralitaException :Exception
    {
        private string nombreClase;
        private string nombreMetodo;

        #region Propiedades 

        public string NombreClase
        {
            get { return this.nombreClase; }
        }

        public string NombreMetodo
        {
            get { return this.NombreMetodo; }
        }

        #endregion

        #region Metodos


        public CentralitaException(string mensaje, string clase, string metodo, Exception innerExeption):base (mensaje,innerExeption)
        {
            this.nombreMetodo = metodo;
            this.nombreClase = clase;
        }

        public CentralitaException(string mensaje,string clase,string metodo):this(mensaje,clase,metodo,new Exception())
        {
            
        }

        #endregion



    }
}
