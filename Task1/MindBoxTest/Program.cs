using MindBox.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTest
{
    class Program
    {
        static void Main(string[] args)
        {
            IFigure figure1 = new Circle(20);
            IFigure figure2 = new Triangle(5, 6, 7);

            var area1 = figure1.GetArea();
            var area2 = figure2.GetArea();

            Triangle triangle = figure2 as Triangle;

            triangle.IsRectangular();

        }
    }
}
