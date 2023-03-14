using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab.EF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab.EF.Entities;
using System.Data.Entity;
using Moq;
using Lab.EF.Data;
using Microsoft.AspNetCore.Mvc;

namespace Lab.EF.Logic.Tests
{
    [TestClass()]
    public class ShippersLogicTests
    {
        [TestMethod]
        public void GetAll()
        {
            ShippersLogic lc = new ShippersLogic();
            var list = lc.GetAll();
            Assert.IsNotNull(list);
        }

    }
}