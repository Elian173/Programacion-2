using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Archivos;
using ObjetoPruebas;
using System.IO;
namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException))]
        public void TestText()
        {
            ObjetoPrueba o = new ObjetoPrueba("elian", 1);
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string errorLectura = "";
            string textoLeido = "";
            Archivos.Texto texto = new Archivos.Texto();


            texto.Guardar(path + "/Arch.txt", "HOLA JAJA");

            texto.Leer(path + "/Arch.txt", out textoLeido);

            texto.Leer(path + "No existe", out errorLectura);



            Assert.AreEqual(textoLeido, "HOLA JAJA");
            Assert.AreEqual(errorLectura, "Error de lectura!");

        }




        [TestMethod]
        public void TestXml()
        {
            ObjetoPrueba o = new ObjetoPrueba("elian", 1);
            ObjetoPrueba x = null;

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            Xml<ObjetoPrueba> xml = new Xml<ObjetoPrueba>();
            path = path + "arch.xml";


            xml.Guardar(path, o);
            xml.Leer(path, out x);


            Assert.AreEqual(o.Nombre,x.Nombre);
            Assert.AreEqual(o.ID, x.ID);

        }



        [TestMethod]
        public void TextBinario()
        {
            ObjetoPrueba o = new ObjetoPrueba("elian", 1);
            ObjetoPrueba x = null;

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            Binario<ObjetoPrueba> bin = new Binario<ObjetoPrueba>();
            path = path + "arch.bin";


            bin.Guardar(path, o);
            bin.Leer(path, out x);


            Assert.AreEqual(o.Nombre, x.Nombre);
            Assert.AreEqual(o.ID, x.ID);

        }
    }
}




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