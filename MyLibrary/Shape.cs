using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public interface IShape
    {
        double Square();
    }
    public class Circle : IShape
    {
        public double Radius { get; private set; }
        public Circle(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Incorrect radius is entered!");
            }
            else
            {
                Radius = radius;
            }
        }
        public double Square()
        {
            double square = Math.PI * Radius * Radius;
            return Math.Round(square, 2, MidpointRounding.AwayFromZero);
        }
    }
    public class Triangle : IShape
    {
        public double FirstSide { get; private set; }
        public double SecondSide { get; private set; }
        public double ThirdSide { get; private set; }
        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if(firstSide <= 0 || secondSide <=0 || thirdSide <= 0)
            {
                throw new ArgumentException("Each side of the triangle must have a positive value!");
            }
            else if(firstSide >= (secondSide + thirdSide) ||
                secondSide >= (firstSide + thirdSide) ||
                thirdSide >= (firstSide + secondSide))
            {
                throw new ArgumentException("Each side of the triangle must be less " +
                    "than the sum of the other two sides!");
            }
            else
            {
                FirstSide = firstSide;
                SecondSide = secondSide;
                ThirdSide = thirdSide;
            }
        }
        public double Square()
        {
            double halfPerimeter = (FirstSide + SecondSide + ThirdSide) / 2;
            double square = Math.Sqrt(halfPerimeter * (halfPerimeter - FirstSide) *
                (halfPerimeter - SecondSide) * (halfPerimeter - ThirdSide));
            return Math.Round(square, 2, MidpointRounding.AwayFromZero);
        }
        public bool IsRightTriangle()
        {
            return FirstSide == Math.Sqrt(Math.Pow(SecondSide, 2) + Math.Pow(ThirdSide, 2)) ||
                SecondSide == Math.Sqrt(Math.Pow(FirstSide, 2) + Math.Pow(ThirdSide, 2)) ||
                ThirdSide == Math.Sqrt(Math.Pow(FirstSide, 2) + Math.Pow(SecondSide, 2));
        }
    }
}
