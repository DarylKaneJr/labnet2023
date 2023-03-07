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
    public class LogicTests
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CapturarExcepcionTest()
        {
            var list = new List<int>() { 10, 20, 30 };
            foreach (int value in list)
            {
                Console.WriteLine("ELEMENT: {0}", value);
                list.Remove(value);
            }
        }

        [TestMethod()]
        [ExpectedException(typeof(CustomException))]
        public void ThrowCustomExceptionTest()
        {
            string nombre = "NICO123";
            Logic.ThrowCustomException(nombre); 
        }
    }
}