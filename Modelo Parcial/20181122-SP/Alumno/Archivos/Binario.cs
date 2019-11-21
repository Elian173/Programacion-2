using System;
using System.IO;

//Usings
using System.Runtime.Serialization.Formatters.Binary;

//[Serializable] en la clase a guardar , constructor por def

namespace Archivos
{
    internal class Binario<T>: IArchivo<T>
    {
        public void Guardar( string archivo, T datos )
        {
            FileStream fileStream = null;
            BinaryFormatter serializer = new BinaryFormatter();
            try
            {
                fileStream = new FileStream(archivo, FileMode.OpenOrCreate);
                serializer.Serialize(fileStream, datos);
                //return ok
            }
            catch (Exception)
            {
                //return mal
                throw new Exception("ERROR ARCHIVOS BINARIO GUARDAR");
            }
            finally
            {
                if (fileStream != null)
                {
                    fileStream.Close();
                }
            }
        }

        public void Leer( string archivo, out T datos )
        {
            FileStream fileStream = null;
            BinaryFormatter serializer = new BinaryFormatter();

            try
            {
                fileStream = new FileStream(archivo, FileMode.Open);
                datos = (T) serializer.Deserialize(fileStream);

                //return true;
            }
            catch (Exception)
            {
                datos = default(T);
                throw new Exception("ERROR ARCHIVOS BINARIO LEER");
                //return false;
            }
            finally
            {
                if (fileStream != null)
                {
                    fileStream.Close();
                }
            }
        }
    }
}