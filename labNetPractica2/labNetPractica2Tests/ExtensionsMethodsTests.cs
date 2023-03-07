using Microsoft.VisualStudio.TestTools.UnitTesting;
using labNetPractica2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica2.Tests
{
    [TestClass()]
    public class ExtensionsMethodsTests
    {
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DividirxCeroTest()
        {
            decimal i = 10;
            ExtensionsMethods.DividorPorCero(i);
        }

        [TestMethod()]
        public void DividirTest()
        {
            decimal i = 10;
            decimal j = 20;
            decimal r = i/ j;
            var resultesperado = "El resultado es " + r + "" + " ..Operacion finalizada";
            var resultadoobtenido = ExtensionsMethods.Dividir(i, j);
            Assert.AreEqual(resultesperado, resultadoobtenido);
        }
    }
}