using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        #region Atributos
        private int id;
        private string nombre;
        private string apellido;
        private string dni;
        private DateTime? fechaNacimiento;
        private List<Mascota> mascotas;
        #endregion

        #region propiedades

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public DateTime? FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }

        public List<Mascota> Mascotas
        {
            get { return this.mascotas; }
            set { this.mascotas = value; }
        }
        #endregion

        #region Constructores
        public Cliente(int id, string nombre, string apellido, string dni, DateTime? fechaNac)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.fechaNacimiento = fechaNac;
            this.mascotas = new List<Mascota>();
        }
        #endregion

        #region Metodos

        public override string ToString()
        {
            StringBuilder c = new StringBuilder();

            c.AppendLine("Cliente :");
            c.AppendFormat("{0} {1}\n", this.Nombre, this.Apellido);
            c.AppendFormat("Dni :{0}\n", this.dni);
            if (this.fechaNacimiento != null)
            {
                c.AppendFormat("Fecha Nacimiento :{0}\n", this.FechaNacimiento);
            }
            /*
            c.Append("Mascotas :");

            foreach (Mascota m in this.mascotas)
            {
                c.AppendFormat(m.Nombre);
            }*/

            return c.ToString();
        }

        #endregion



    }
}
