using AreaCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AreaCalculatorTests
{
    /// <summary>
    /// Класс тестирования для <see cref="Triangle"/>
    /// </summary>
    [TestClass]
    public sealed class TriangleTests
    {
        private const double Delta = 1E-3;

        /// <summary>
        /// Расчет площади фигуры вернет ожидаемый результат
        /// </summary>
        [DataTestMethod]
        [DataRow(1, 1, 1, 0.433)]
        [DataRow(1, 2, 2, 0.968)]
        public void GetArea_WithValidTestData_ExpectedResult(double a, double b, double c, double expectedArea)
        {
            // Arrange
            Triangle triangle = new(a, b, c);

            // Act
            double area = triangle.GetArea();

            // Assert
            Assert.AreEqual(expectedArea, area, Delta);
        }

        /// <summary>
        /// Создание фигуры с недопустимыми длинами сторон вызовет исключение
        /// </summary>
        [DataTestMethod]
        [DataRow(1, 2, 4)]
        [DataRow(2, 4, 1)]
        [DataRow(4, 1, 2)]
        public void Init_WithInvalidTestData_ThrowException(double a, double b, double c)
        {
            // Arrange && Act && Assert
            Assert.ThrowsException<ArgumentException>(() => new Triangle(a, b, c));
        }

        /// <summary>
        /// Проверка треугольника на то является ли он прямоугольным вернет ожидаемый результат
        /// </summary>
        [DataTestMethod]
        [DataRow(3, 4, 5, true)]
        [DataRow(1, 1, 1, false)]
        public void IsRightTriangle_WithValidTestData_ExpectedResult(double a, double b, double c, bool expectedIsRightTriangle)
        {
            // Arrange
            Triangle triangle = new(a, b, c);

            // Act
            bool isRightTriangle = triangle.IsRightTriangle();

            // Assert
            Assert.AreEqual(expectedIsRightTriangle, isRightTriangle);
        }
    }
}