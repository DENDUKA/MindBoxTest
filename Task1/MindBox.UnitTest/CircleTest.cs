using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindBox.Library;
using System;

namespace MindBox.UnitTest
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void TestWrongData()
        {
            var exceptionThrown = false;

            try
            {
                new Circle(0);
            }
            catch (ArgumentException)
            {
                exceptionThrown = true;
            }

            Assert.IsTrue(exceptionThrown);

            exceptionThrown = false;

            try
            {
                new Circle(0,0,-10);
            }
            catch (ArgumentException)
            {
                exceptionThrown = true;
            }

            Assert.IsTrue(exceptionThrown);

            exceptionThrown = false;

            try
            {
                new Circle(-10);
            }
            catch (ArgumentException)
            {
                exceptionThrown = true;
            }

            Assert.IsTrue(exceptionThrown);

            exceptionThrown = false;

            try
            {
                new Circle(10).Radius = -10;
            }
            catch (ArgumentException)
            {
                exceptionThrown = true;
            }

            Assert.IsTrue(exceptionThrown);
        }

        [TestMethod]
        public void TestFunc()
        {
            var circle = new Circle(10);

            Assert.AreEqual(Math.Round(circle.GetArea(), 2), 314.16D);
        }
    }
}
