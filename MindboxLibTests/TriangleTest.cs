using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindboxLib;

namespace MindboxLibTests
{
    [TestClass]
    public class TriangleTest
    {

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TriangleInitialize_ArgumentNullException()
        {
            var triangle = new Triangle();
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TriangleInitialize_NullReferenceException()
        {
            var triangle = new Triangle(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TriangleInitialize_InvalidNumberOfArguments_Exception()
        {
            var triangle = new Triangle(10);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TriangleInitialize_ArgumentsMustBePositive_Exception()
        {
            var triangle = new Triangle(0, -2, 3);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TriangleInitialize_NotExist_Exception()
        {
            var triangle = new Triangle(1, 1, 2);
        }

        [TestMethod]
        public void TriangleArea_5and4and3_return6()
        {
            //arrange
            double expected = 6;            

            //act
            var triangle = new Triangle(5, 4, 3);
            double actual = triangle.GetArea();            

            //assert
            Assert.AreEqual(expected, actual);                        
        }

        [TestMethod]
        public void TriangleIsRight()
        {
            //arrange  
            bool[] arrExpected = { true, false };
            //bool expected = true;

            //act
            bool[] arrActual = { 
                new Triangle(5, 4, 3).IsRight(),
                new Triangle(1, 1, 1).IsRight()
            };                        

            //assert            
            CollectionAssert.AreEqual(arrExpected, arrActual);            
        }
    }
}
