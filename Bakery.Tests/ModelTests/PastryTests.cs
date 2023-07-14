using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.Tests
{
    [TestClass]
    public class PastryTests
    {
        [TestMethod]
        public void PastryConstructor_CreatesInstanceOfPastryClass_Pastry()
        {
            Pastry newPastry = new Pastry(4);
            Assert.AreEqual(typeof(Pastry), newPastry.GetType());
        }
        [TestMethod]
        public void GetPastryCount_ReturnsPastryCount_Int()
        {
            Pastry newPastry = new Pastry(4);
            int result = newPastry.PastryCount;
            Assert.AreEqual(4, result);
        }
    }
}