using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mascota
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private int idHumano;

        public int IdHumano
        {
            get { return idHumano; }
            set { idHumano = value; }
        }

    }
}
