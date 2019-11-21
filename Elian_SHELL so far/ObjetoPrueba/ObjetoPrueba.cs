using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ObjetoPruebas
{
    [Serializable]
    public class ObjetoPrueba
    {
        public ObjetoPrueba()
        {

        }
        public ObjetoPrueba(string nombre , int id)
        {
            this.nombre = nombre;
            this.id = id;
        }
        private string nombre;

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        private int id;

        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public override string ToString()
        {
            return this.nombre +" "+this.id;
        }

    }
}
