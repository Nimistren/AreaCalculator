using System;
using AreaCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AreaCalculatorTests
{
    /// <summary>
    /// Класс тестирования для <see cref="Circle"/>
    /// </summary>
    [TestClass]
    public sealed class CircleTests
    {
        private const double Delta = 1E-2;

        /// <summary>
        /// Расчет площади фигуры вернет ожидаемый результат
        /// </summary>
        [DataTestMethod]
        [DataRow(1, 3.14)]
        [DataRow(2, 12.56)]
        [DataRow(3, 28.27)]
        [DataRow(3.7, 43.0084)]
        public void GetArea_WithValidTestData_ExpectedResult(double radius, double expectedArea)
        {
            // Arrange
            Circle circle = new(radius);

            // Act
            double area = circle.GetArea();

            // Assert
            Assert.AreEqual(expectedArea, area, Delta);
        }

        /// <summary>
        /// Создание фигуры с некорректных радиусом вызовет InvalidArgumentException
        /// </summary>
        [DataTestMethod]
        [DataRow(-1)]
        [DataRow(0)]
        public void Init_WithInvalidTestData_ThrowArgumentException(double radius)
        {
            // Arrange && Act && Assert
            Assert.ThrowsException<ArgumentException>(() => new Circle(radius));
        }
    }
}