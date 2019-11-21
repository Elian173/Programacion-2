using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EjercicioGuia42;

/*Tomar el ejercicio 42:
a. Realizar un test unitario para cada método y/o constructor.
b. Cada test deberá validar que el método lance la excepción que le corresponde./*/

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestBuilderClase1()
        {
            bool valid = false;

            try
            {
                Clase1 x = new Clase1();
            }
            catch (DivideByZeroException)
            {
                valid = true;
            }

            Assert.IsTrue(valid);
        }

        [TestMethod]
        public void TestBuilderClase2()
        {

            bool valid = false;

            try
            {
                Clase2 x = new Clase2();
            }
            catch (UnaException)
            {
                valid = true;
            }

            Assert.IsTrue(valid);

        }

        [TestMethod]
        public void TestMethodClase3()
        {

            bool valid = false;
            Clase3 x = new Clase3();
        
            try
            {
                x.Metodo();
            }
            catch (MiException)
            {
                valid = true;
            }

            Assert.IsTrue(valid);

        }

        [TestMethod]
        public void TestMethodClase1()
        {

            bool valid = false;
            

            try
            {
                Clase1.LanzarDividedByZero();
            }
            catch (DivideByZeroException)
            {
                valid = true;
            }

            Assert.IsTrue(valid);

        }




    }
}
