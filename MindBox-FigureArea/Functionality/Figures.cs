using System;
using System.Collections.Generic;
using System.Text;

namespace MindBox_FigureArea.Functionality
{

    public class Circle : AbstractFigure
    {
        public int Radius { get; set; }
        public double Area { get; set; }

        // единственный конструктор, принимающий радиус круга
        // при объявлении нового круга вызывается метод CalculateArea, и её результат записывается в переменную Area, которая доступна для чтения другим классам
        public Circle(int radius)
        {
            Radius = radius;
            Area = CalculateArea();
        }

        #region Circle Methods

        // расчёт площади круга по радиусу
        // реализация абстрактного метода
        protected override double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        #endregion
    }

    public class Triangle : AbstractFigure
    {
        public int Side1 { get; set; }
        public int Side2 { get; set; }
        public int Side3 { get; set; }
        public double Area { get; set; }

        // единственный конструктор, принимающий три стороны треугольника
        // при объявлении нового треугольника вызывается метод CalculateArea, и её результат записывается в переменную Area, которая доступна для чтения другим классам
        public Triangle(int side1, int side2, int side3)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
            Area = CalculateArea();
        }

        #region Triangle Methods

        // расчёт площади треугольника по трём сторонам
        // реализация абстрактного метода
        protected override double CalculateArea()
        {
            // нахождение периметра - полусуммы трёх сторон треугольника
            var p = (Side1 + Side2 + Side3) / 2;
            // формула Герона
            return Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
        }

        // метод определяет, является ли треугольник прямоугольным по трём сторонам
        // возвращает true или false
        public bool CheckRightTriangle()
        {
            // теорема Пифагора: если сумма квадратов катетов равна квадрату гипотенузы, треугольник является прямоугольным
            return (Math.Pow(Side1, 2) == Math.Pow(Side2, 2) + Math.Pow(Side3, 2))
                || (Math.Pow(Side2, 2) == Math.Pow(Side1, 2) + Math.Pow(Side3, 2))
                || (Math.Pow(Side3, 2) == Math.Pow(Side1, 2) + Math.Pow(Side2, 2));
        }

        #endregion
    }
}
