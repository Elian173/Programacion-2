using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioGuia47__Generics_
{
    public abstract class Equipo
    {
        protected string nombre;
        protected DateTime fecha;

        public Equipo (string nombre , DateTime fecha)
        {
            this.nombre = nombre;
            this.fecha = fecha;
        }


        public string Nombre
        {
            get { return this.nombre; }
        }



        public static bool operator ==(Equipo equipo1, Equipo equipo2)
        {
            if (equipo1.fecha == equipo2.fecha)
            {
                if (equipo1.nombre == equipo2.nombre)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(Equipo equipo1, Equipo equipo2)
        {
            if(!(equipo1 == equipo2))
            {
                return true;
            }

            return false;
        }

        public string Ficha()
        {
            StringBuilder descripcion = new StringBuilder();
            descripcion.AppendFormat("{0} fundado el {1}", this.nombre, this.fecha);
            return descripcion.ToString();
        }




    }
}
