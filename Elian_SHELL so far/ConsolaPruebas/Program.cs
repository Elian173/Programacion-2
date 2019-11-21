using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjetoPruebas;
using System.IO;
using Archivos;
using Excepciones;

namespace ConsolaPruebas
{
    class Program
    {
        static void Main( string[] args )
        {
            ObjetoPrueba o = new ObjetoPrueba("elian", 1);


            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            //TEXTO

            // Archivos.Texto texto = new Archivos.Texto();
            //texto.Guardar(path+"/Arch.txt", "HOLA JAJA");
            //string x = "";
            //texto.Leer(path + "/Arch.txt", out x);
            //Console.WriteLine(x);
            //Console.ReadKey();


            //XML

            //Xml<ObjetoPrueba> xml = new Xml<ObjetoPrueba>();
            //path = path + "arch.xml";
            //xml.Guardar(path, o);
            //Console.WriteLine("Guardo");
            //Console.ReadKey();
            //Console.WriteLine("LEO");
            //ObjetoPrueba x = null;
            //xml.Leer(path,out x);
            //Console.WriteLine(x.ToString());
            //Console.ReadKey();


            //BINARIO

            //Binario<ObjetoPrueba> bin = new Binario<ObjetoPrueba>();
            //path = path + "arch.bin";
            //bin.Guardar(path, o);
            //Console.WriteLine("Guardo");
            //Console.ReadKey();
            //Console.WriteLine("LEO");
            //ObjetoPrueba x = null;
            //bin.Leer(path, out x);
            //Console.WriteLine(x.ToString());
            //Console.ReadKey();

        }
    }

}
