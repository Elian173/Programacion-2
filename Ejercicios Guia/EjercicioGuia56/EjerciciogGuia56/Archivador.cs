using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EjerciciogGuia56
{
    public static class Archivador
    {

        public static void GuardarTexto(string textoAGuardar, string path, bool anexar)
        {

            StreamWriter archivo = null;

            try
            {
                  archivo = new StreamWriter(path, anexar);
                  archivo.Write(textoAGuardar);
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
                    archivo.Close();
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