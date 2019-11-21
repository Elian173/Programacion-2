using System;

//Usings
using System.IO;

//Utiles
//File.Exists();
//File.Copy();
//File.Delete;
//Directory,Delete() -> Solo si esta vacios
//Directory.Exists()
//GetFiles(STRING) -> Devuelve los nombres de archivo del directorio especificado

//Envitoment.GetFolderPath(Environment.SpecialFolder.Desktop / MyDocuments / ProgramFiles)


namespace Archivos
{
    public class Texto: IArchivo<string>
    {
        public void Guardar( string archivo, string datos ) //no append
        {
            StreamWriter writer = null;

            //Si solo me dan el nombre del archivo y no la ruta
            //string rutaCompleta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //archivo = rutaCompleta + '/' + archivo;
            //
            try
            {
                writer = new StreamWriter(archivo, false); //no append
                writer.Write(datos);
            }
            catch (Exception)
            {
                throw new Exception("Error archivos texto");
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
            }
        }

        public void Leer( string archivo, out string datos )
        {
            StreamReader reader = null;

            //Si solo me dan el nombre del archivo y no la ruta
            //string rutaCompleta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //archivo = rutaCompleta + '/' + archivo;
            //

            try
            {
                reader = new StreamReader(archivo);
                datos = reader.ReadToEnd();
            }
            catch(Exception)
            {
                datos = "Error de lectura!";

            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
        }
    }
}