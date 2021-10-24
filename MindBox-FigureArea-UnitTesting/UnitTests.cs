using System;
using NUnit.Framework;
using MindBox_FigureArea;

namespace MindBox_FigureArea_UnitTesting
{

    // класс для тестов методов круга
    [TestFixture]
    public class CircleTests
    {
        [Test]
        public void CircleArea()
        {
            //arrange
            MindBox_FigureArea.Functionality.Circle circle = new MindBox_FigureArea.Functionality.Circle(3);

            //act
            var correctArea = Math.PI * Math.Pow(3, 2);
            var area = circle.Area;
            
            //assert
            Assert.AreEqual(correctArea, area);
        }
    }

    // класс для тестов методов треугольника
    [TestFixture]
    public class TriangleTests
    {
        [Test]
        public void TriangleArea()
        {
            //arrange
            MindBox_FigureArea.Functionality.Triangle triangle = new MindBox_FigureArea.Functionality.Triangle(5, 12, 13);
            
            //act
            var area = triangle.Area;
            
            //assert
            Assert.AreEqual(30, area);
        }
        
        [Test]
        public void TriangleIsRight()
        {
            //arrange
            MindBox_FigureArea.Functionality.Triangle triangle = new MindBox_FigureArea.Functionality.Triangle(5, 12, 13);
            
            //act
            bool isRight = triangle.CheckRightTriangle();
            
            //assert
            Assert.IsTrue(isRight);
        }
    }
}