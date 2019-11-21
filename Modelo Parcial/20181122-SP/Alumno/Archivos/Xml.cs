using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//USINGS 
using System.Xml;
using System.Xml.Serialization;

//Constructor por defecto , [XMLInclude(typeof(Clase))] en la base x cada heredada

namespace Archivos
{
    public class Xml <T> : IArchivo <T>
    {

        public void Guardar( string archivo, T datos )
        {
            XmlTextWriter writer = null;
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            try
            {
                writer = new XmlTextWriter(archivo,Encoding.UTF8);
                serializer.Serialize(writer, datos);
                //return ok
            }
            catch (Exception)
            {
                //return mal
                throw new Exception("ERROR ARCHIVOS XML GUARDAR");
            }
            finally
            {
                if(writer != null)
                {
                    writer.Close();
                }
            }
        }

        public void Leer( string archivo, out T datos )
        {

            XmlTextReader reader = null;
            XmlSerializer serializer = new XmlSerializer(typeof(T));
           
            try
            {
                
                reader = new XmlTextReader(archivo);
                datos = (T) serializer.Deserialize(reader);
           
                //return true;
            }
            catch (Exception)
            {
                datos = default(T) ;
                throw new Exception("ERROR ARCHIVOS XML LEER");
                //return false;
            }
            finally
            {
                reader.Close();
            }


        }
    }



}

