using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindBox.Library;
using System;

namespace MindBox.UnitTest
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void TestWrongData()
        {
            var triangle = new Triangle(5, 6, 7);

            var exceptionThrown = false;

            try
            {
                new Triangle(1, 2, 3);
            }
            catch (ArgumentException)
            {
                exceptionThrown = true;
            }

            Assert.IsTrue(exceptionThrown);

            exceptionThrown = false;

            try
            {
                new Triangle(1, 2, -3);
            }
            catch (ArgumentOutOfRangeException)
            {
                exceptionThrown = true;
            }

            Assert.IsTrue(exceptionThrown);

            exceptionThrown = false;

            try
            {
                var triangle2 = new Triangle(1, 2, 3);
                triangle2.SideA = 0;
            }
            catch (ArgumentException)
            {
                exceptionThrown = true;
            }

            Assert.IsTrue(exceptionThrown);

            exceptionThrown = false;

            try
            {
                var triangle2 = new Triangle(1, 2, 3);
                triangle2.SideB = 0;
            }
            catch (ArgumentException)
            {
                exceptionThrown = true;
            }

            Assert.IsTrue(exceptionThrown);

            exceptionThrown = false;

            try
            {
                var triangle2 = new Triangle(1, 2, 3);
                triangle2.SideC = 0;
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
            var triangle = new Triangle(6, 8, 10);

            var area = triangle.GetArea();

            Assert.AreEqual(area, 24);

            Assert.IsTrue(triangle.IsRectangular());

            triangle.SideA = 10;

            Assert.IsFalse(triangle.IsRectangular());

            triangle.SideB = 6;

            Assert.IsFalse(triangle.IsRectangular());

            triangle.SideC = 8;

            Assert.IsTrue(triangle.IsRectangular());
        }
    }
}