using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//COSAS DE SERIALIZAR
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace EjercicioGuia57
{
    public class Persona
    {
        private string nombre;
        private string apellido;

        #region Constructores
        public Persona()
        {

        }

        public Persona(string nombre ,string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
        #endregion

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }


        #region Metodos

        public static void Guardar(Persona persona, string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof (Persona));
            XmlTextWriter writer = new XmlTextWriter(path, Encoding.UTF8);

            serializer.Serialize(writer, persona);
            writer.Close();

        }

        public static Persona Leer(string path)
        {

            Persona persona;
            XmlTextReader reader = new XmlTextReader(path);
            XmlSerializer serializer = new XmlSerializer(typeof(Persona));

            persona =(Persona) serializer.Deserialize(reader);
            reader.Close();

            return persona;
        }

        public override string ToString()
        {
            StringBuilder desc = new StringBuilder();

            desc.Append(this.Nombre);
            desc.Append("--");
            desc.AppendLine(this.Apellido);

            return desc.ToString();
        }

        #endregion

    }
}
