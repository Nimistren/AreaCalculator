using System.Collections.Generic;
using System.Linq;
using AreaCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AreaCalculatorTests
{
    /// <summary>
    /// Класс для тестирования 
    /// </summary>
    [TestClass]
    public sealed class FigureTests
    {
        /// <summary>
        /// Расчет площадей для коллекции фигур вернет ожидаемый результат
        /// </summary>
        [TestMethod]
        public void GetArea_WithFigureCollection_ExpectedResult()
        {
            // Arrange
            List<Figure> figureList = new()
            {
                new Circle(1),
                new Triangle(1, 1, 1),
            };

            // Act
            List<double> areaList = figureList.Select(figure => figure.GetArea()).ToList();

            // Assert
            CollectionAssert.AreEqual(new List<double>{ 3.14 , 0.433 }, areaList, new Comparer(1E-2));
        }
    }
}
