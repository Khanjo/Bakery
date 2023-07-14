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
            Bread newBread = new Bread();
            Assert.AreEqual(typeof(Bread), newBread.GetType());
        }
    }
}