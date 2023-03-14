using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab.EF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab.EF.Entities;
using Moq;
using Lab.EF.Data;
using System.Data.Entity;

namespace Lab.EF.Logic.Tests
{
    [TestClass()]
    public class ShippersLogicTests
    {
        [TestMethod()]
        public void GetAllTest()
        {
            var controller = new ShippersLogic();
            Shippers s = new Shippers();
            s.ShipperID = 1;
            s.CompanyName = "Personal";
            s.Phone = "22453656";

            //Act
            controller.Add(s);

        }
    }
}