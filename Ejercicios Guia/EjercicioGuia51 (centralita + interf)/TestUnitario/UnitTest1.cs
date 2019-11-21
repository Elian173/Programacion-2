using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BibliotecaClases;

namespace TestUnitario
{
    [TestClass]
    public class UnitTest1
    {
        /*a. Crear un test unitario que valide que la lista de llamadas de la centralita esté instanciada al
        crear un nuevo objeto del tipo Centralita.
        */
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange 
            Centralita x = new Centralita("Algo");
            //Act

            //Assert
            Assert.IsNotNull(x.Llamadas);
        }

        /*b. Controlar mediante un nuevo método de test unitario que la excepción CentralitaExcepcion
        se lance al intentar cargar una segunda llamada con solamente los mismos datos de origen y
        destino de una llamada Local ya existente.*/
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            Centralita c = new Centralita("Algo");
            Llamada llamada = new Local("aa", 10, "bb", 100);
            Llamada llamada2 = new Local("aa", 120, "bb", 1030);
            bool valido = false;

            //Act
            c = c + llamada;

            try
            {
                c = c + llamada2;
            }
            catch (CentralitaException)
            {
                valido = true;
            }

            //Assert
            Assert.IsTrue(valido);

        }

        /* c.Controlar mediante un nuevo método de test unitario que la excepción CentralitaExcepcion
         se lance al intentar cargar una segunda llamada con solamente los mismos datos de origen y
         destino de una llamada Provincial ya existente.*/
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            Centralita c = new Centralita("Algo");
            Llamada llamada = new Provincial("aa", Provincial.Franja.Franja_1, 100, "bb");
            Llamada llamada2 = new Provincial("aa", Provincial.Franja.Franja_3, 130, "bb");
            bool valido = false;

            //Act
            c = c + llamada;

            try
            {
                c = c + llamada2;
            }
            catch (CentralitaException)
            {
                valido = true;
            }

            //Assert
            Assert.IsTrue(valido);

        }

        /*d. Dentro de un método de test unitario crear dos llamadas Local y dos Provincial, todos con
        los mismos datos de origen y destino. Luego comparar cada uno de estos cuatro objetos
        contra los demás, debiendo ser iguales solamente las instancias de Local y de Provincial
        entre sí.*/
        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            Llamada llamadaProvincial1 = new Provincial("aa", Provincial.Franja.Franja_1, 1000, "bb");
            Llamada llamadaProvincial2 = new Provincial("aa", Provincial.Franja.Franja_3, 130, "bb");
            Llamada llamadaLocal1 = new Local("aa", 1300, "bb", 1040);
            Llamada llamadaLocal2 = new Local("aa", 1050, "bb", 1070);

            //Act


            //Assert
            Assert.IsTrue(llamadaProvincial1 == llamadaProvincial2);
            Assert.IsTrue(llamadaLocal1 == llamadaLocal2);

            //Entre distintos tipos->
            Assert.IsFalse(llamadaLocal1 == llamadaProvincial1);
            Assert.IsFalse(llamadaLocal1 == llamadaProvincial2);

            Assert.IsFalse(llamadaLocal2 == llamadaProvincial1);
            Assert.IsFalse(llamadaLocal2 == llamadaProvincial2);



        }

    }
}
