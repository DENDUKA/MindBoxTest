using System;

namespace MindBox.Library
{
    public class Circle : IFigure
    {
        public Circle(double radius)
        {
            Radius = radius;
        }

        public Circle(double x, double y, double radius)
        {
            X = x;
            Y = y;
            Radius = radius;
        }

        public double X { get; set; }

        public double Y { get; set; }

        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                if (value > 0)
                    radius = value;
                else
                    throw new ArgumentException("Радиус должен быть > 0");
            }
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        private double radius;
    }
}
