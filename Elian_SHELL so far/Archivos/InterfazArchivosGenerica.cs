using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    public interface IArchivo <T>
    {
        void Guardar( string archivo, T datos );
        void Leer( string archivo, out T datos );
    }


    public interface IArchivoTexto
    {
        string Texto
        {
            get;
        }
        string Ruta
        {
            get;
        }
    }


    //class ComiqueriaException: Exception, IArchivoTexto
    //{
    //    public ComiqueriaException( string message, Exception innerException ) : base(message, innerException)
    //    {
    //        ArchivoTexto.Escribir(this, true);
    //    }

    //    public string Texto
    //    {
    //        get
    //        {
    //            StringBuilder sb = new StringBuilder();
    //            sb.AppendLine(DateTime.Now.ToString() + ":");
    //            sb.AppendLine(this.Message);
    //            Exception innerException = this.InnerException;
    //            while (innerException != null)
    //            {
    //                sb.AppendLine(innerException.Message);
    //                innerException = innerException.InnerException;
    //            }

    //            return sb.ToString();
    //        }
    //    }

    //    public string Ruta
    //    {
    //        get
    //        {
    //            return String.Format("{0}log.txt", Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
    //        }
    //    }
    //}

}
