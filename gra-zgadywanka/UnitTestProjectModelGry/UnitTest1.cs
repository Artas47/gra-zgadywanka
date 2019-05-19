using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModelGry;

namespace UnitTestProjectModelGry
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Losuj_OK()
        {
            //arrange-act-assert

            //arrange
            int min = 1;
            int max = 10;
            //act
            int wylos = Gra.Losuj(min, max);

            //Assert
            Assert.IsTrue(wylos >= min && wylos <= max);
        }
    }
}
