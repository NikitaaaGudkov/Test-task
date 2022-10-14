using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Tests
{
    [TestClass()]
    public class MyTests
    {
        [TestMethod()]
        public void CircleSquare_10_314point16returned()
        {
            // arrange
            double radius = 10;
            double expected = 314.16;

            // act
            Circle circle = new Circle(radius);
            double actual = circle.Square();

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void CreateCircle_minus5_Exception()
        {
            // arrange
            double radius = -5;

            // act
            Circle circle = new Circle(radius);

            // assert
        }

        [TestMethod()]
        public void TriangleSquare_3and4and5_6returned()
        {
            // arrange
            double firstSide = 3;
            double secondSide = 4;
            double thirdSide = 5;
            double expected = 6;

            // act
            Triangle triangle = new Triangle(firstSide, secondSide, thirdSide);
            double actual = triangle.Square();

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TriangleIsRightTriangle_3and4and5_trueReturned()
        {
            // arrange
            double firstSide = 3;
            double secondSide = 4;
            double thirdSide = 5;
            bool expected = true;

            // act
            Triangle triangle = new Triangle(firstSide, secondSide, thirdSide);
            bool actual = triangle.IsRightTriangle();

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void CreateTriangleWithNegativeSides_7and8andMinus9_Exception()
        {
            // arrange
            double firstSide = 7;
            double secondSide = 8;
            double thirdSide = -9;

            // act
            Triangle triangle = new Triangle(firstSide, secondSide, thirdSide);

            // assert
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void CreateTriangleWithNonExistentSides_1and2and10_Exception()
        {
            // arrange
            double firstSide = 1;
            double secondSide = 2;
            double thirdSide = 10;

            // act
            Triangle triangle = new Triangle(firstSide, secondSide, thirdSide);

            // assert
        }
    }
}