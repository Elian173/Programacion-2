using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace BibliotecaClases
{
    public static class Archivador
    {

        public static void GuardarTexto(string textoAGuardar, string path, bool anexar, string nombreArchivo)
        {

            string rutaConNombre = path + "/" + nombreArchivo + ".txt";
            StreamWriter archivo = null;

            try
            {
                if (!(Directory.Exists(path)))
                {
                    throw new Exception("No existe el directorio");
                }
                else
                {
                    archivo = new StreamWriter(rutaConNombre, anexar);
                    archivo.Write(textoAGuardar);
                }

            }
            finally
            {
                if (archivo != null)
                {
                    archivo.Close();
                }
            }
        }

        public static string Leer(string path)
        {
            const string EXTENSION_VALIDA = ".txt";
            //string rutaConNombre = path + "/" + nombreArchivo + ".txt";
            StreamReader archivo = null;
            string textoGuardado;
            string extensionArchivo = "Invalido";

            try
            {
                /*extensionArchivo = path.Substring(path.Length - 4);
                extensionArchivo = extensionArchivo.ToLower();*/
                extensionArchivo = Path.GetExtension(path);


                if (extensionArchivo != EXTENSION_VALIDA)
                {
                    throw new Exception("Extension del archivo invalida");
                }
                else
                {
                    archivo = new StreamReader(path);
                    textoGuardado = archivo.ReadToEnd();
                    return textoGuardado;
                }

            }
            finally
            {
                if (archivo != null)
                {
                    archivo.Close();
                }
            }
        }
    }

}
