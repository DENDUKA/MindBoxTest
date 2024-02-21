using System;
using System.Linq;

namespace MindBox.Library
{
    public class Triangle : IFigure
    {
        public Triangle(double a, double b, double c)
        {
            SetSides(a, b, c);
        }

        public double SideA
        {
            get
            {
                return sides[0];
            }
            set
            {
                sides[0] = value;
                IsValid();
            }
        }

        public double SideB
        {
            get
            {
                return sides[1];
            }
            set
            {
                sides[1] = value;
                IsValid();
            }
        }

        public double SideC
        {
            get
            {
                return sides[2];
            }
            set
            {
                sides[2] = value;
                IsValid();
            }
        }

        public void SetSides(double a, double b, double c)
        {
            sides[0] = a;
            sides[1] = b;
            sides[2] = c;

            IsValid();
        }

        public double GetArea()
        {
            //Полупериметр
            var semiP = sides.Sum() / 2;

            return Math.Sqrt(semiP * (semiP - sides[0]) * (semiP - sides[1]) * (semiP - sides[2]));
        }

        public bool IsRectangular()
        {
            var max = sides.Max();

            return Math.Pow(max, 2) == sides.Where(x => x != max).Sum(x => x * x);
        }

        private void IsValid()
        {
            if (sides.Any(x => x <= 0))
            {
                throw new ArgumentOutOfRangeException("Длина должнга быть > 0");
            }

            if (!(
                sides[0] < sides[1] + sides[2] &&
                sides[1] < sides[0] + sides[2] &&
                sides[2] < sides[0] + sides[1]))
            {
                throw new ArgumentException("Ни одна из сторон не должна быть >= сумме остальных двух");
            }
        }

        private double[] sides = new double[3];
    }
}
