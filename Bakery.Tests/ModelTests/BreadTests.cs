using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.Tests
{
    [TestClass]
    public class BreadTests
    {
        [TestMethod]
        public void BreadConstructor_CreatesInstanceOfBreadClass_Bread()
        {
            Bread newBread = new Bread(3);
            Assert.AreEqual(typeof(Bread), newBread.GetType());
        }
        [TestMethod]
        public void GetBreadCount_ReturnsBreadCount_Int()
        {
            Bread newBread = new Bread(3);
            int result = newBread.BreadCount;
            Assert.AreEqual(3, result);
        }
        [TestMethod]
        public void BreadCost_ReturnsPriceOfBread_Int()
        {
            Bread newBread = new Bread(3);
            int result = newBread.BreadCost();
            Assert.AreEqual(15, result);
        }
    }
}