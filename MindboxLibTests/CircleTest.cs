using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindboxLib;

namespace MindboxLibTests
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CircleInitialize_ArgumentNullException()
        {
            var circle = new Circle();
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void CircleInitialize_NullReferenceException()
        {
            var circle = new Circle(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CircleInitialize_InvalidNumberOfArguments_Exception()
        {
            var circle = new Circle(1, 2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CircleInitialize_ArgumentsMustBePositive_Exception()
        {
            var circle = new Circle(-1);
        }

        [TestMethod]
        public void CircleArea_radius_4()
        {
            //arrange
            double expected = 50.2654824574;
            var delta = expected * Math.Pow(10, -6);

            //act
            var shape = new Circle(4);
            double actual = shape.GetArea();

            //assert
            Assert.AreEqual(expected, actual, delta);
            //Assert.ThrowsException();
        }
    }
}
