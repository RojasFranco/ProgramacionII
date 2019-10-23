using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CentralitaHerencia;
using Ejercicio41;

namespace Ejercicio44
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            //Arrange
            Centralita centralita = new Centralita("Central");

            //Act

            //Assert
            Assert.IsNotNull(centralita.Llamadas, "Error, es null");

        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void TestMetodo2()
        {
            Centralita centralita = new Centralita("Central");

            //Arrange            
            Local local1 = new Local("444", 2, "333", 5);
            Local local2 = new Local("444", 2, "333", 5);

            //Act
            centralita = centralita + local1;
            centralita = centralita + local2;

            //Assert controlado en exception
        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void TestMetodo3()
        {
            Centralita centralita = new Centralita();

            //arrange 
            Provincial provincial1 = new Provincial("333", Provincial.Franja.Franja_1, 3, "444");
            Provincial provincial2 = new Provincial("333", Provincial.Franja.Franja_3, 3, "444");

            //act
            centralita += provincial1;
            centralita += provincial2;

            //Assert es evaluado en la exception
        }

        [TestMethod]
        public void TestMetodo4()
        {
            Centralita centralita = new Centralita();

            //arrange 
            Provincial provincial1 = new Provincial("333", Provincial.Franja.Franja_1, 3, "444");
            Provincial provincial2 = new Provincial("333", Provincial.Franja.Franja_3, 3, "444");
            Local local1 = new Local("444", 2, "333", 5);
            Local local2 = new Local("444", 2, "333", 5);

            //act

            //Assert

            Assert.AreNotEqual(provincial1, local1);
            Assert.AreEqual(local1, local2);
            

        }

    }
}
