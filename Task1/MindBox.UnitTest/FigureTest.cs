using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindBox.Library;
using System;

namespace MindBox.UnitTest
{
    [TestClass]
    public class FigureTest
    {
        [TestMethod]
        public void TestFunc()
        {
            IFigure figure1 = new Circle(10);

            Assert.AreEqual(Math.Round(figure1.GetArea(), 2), 314.16D);

            IFigure figure2 = new Triangle(6, 8, 10);

            Assert.AreEqual(figure2.GetArea(), 24);
        }
    }
}
