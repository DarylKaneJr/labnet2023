using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab.EF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic.Tests
{
    [TestClass()]
    public class CustomersLogicTests
    {
        [TestMethod()]
        public void GetAllTest()
        {
            CustomersLogic sp = new CustomersLogic();
            var result = sp.GetAll();
            Assert.AreEqual(91,result.Count());
        }
    }
}