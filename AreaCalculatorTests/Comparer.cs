using System;

namespace AreaCalculatorTests
{
    /// <summary>
    /// Класс сравнения двух double
    /// </summary>
    internal sealed class Comparer: System.Collections.IComparer
    {
        private readonly double _epsilon;

        /// <summary>
        /// Инициализирует новый экземпляр
        /// </summary>
        /// <param name="epsilon"></param>
        public Comparer(double epsilon)
        {
            _epsilon = epsilon;
        }

        /// <summary>
        /// Сравнить два числа с учетом погрешности
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int Compare(double x, double y)
        {
            double delta = Math.Abs(x - y);

            return delta < _epsilon ? 0 : x.CompareTo(y);
        }

        /// <summary>
        /// Сравнить два числа с учетом погрешности
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int Compare(object? x, object? y)
        {
            double a = (double)x;
            double b = (double)y;

            double delta = Math.Abs(a - b);
            return delta < _epsilon ? 
                0 : a.CompareTo(b);
        }
    }
}
