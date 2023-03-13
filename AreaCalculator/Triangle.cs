namespace AreaCalculator
{
    /// <summary>
    /// Треугольник
    /// </summary>
    public sealed class Triangle : Figure
    {
        private const double Delta = 1E-9;
        private const string CurrentFigureName = "Треугольник";

        /// <summary>
        /// Инициализирует новый экземпляр
        /// </summary>
        /// <param name="a">Сторона a</param>
        /// <param name="b">Сторона b</param>
        /// <param name="c">Сторона c</param>
        public Triangle(
            double a,
            double b,
            double c) : base(CurrentFigureName)
        {
            if (!IsTriangleExist(a, b, c))
                throw new ArgumentException($"Невозможно описать треугольник с длинами сторон: {a}, {b}, {c}");

            A = a;
            B = b;
            C = c;
        }

        /// <summary>
        /// Первая сторона треугольника
        /// </summary>
        public double A { get; }

        /// <summary>
        /// Вторая сторона треугольника
        /// </summary>
        public double B { get; }

        /// <summary>
        /// Третья сторона треугольника
        /// </summary>
        public double C { get; }

        /// <summary>
        /// Является прямоугольным треугольником
        /// </summary>
        /// <returns></returns>
        public bool IsRightTriangle()
        {
            return Math.Abs(A * A + B * B - C * C) < Delta ||
                   Math.Abs(A * A + C * C - B * B) < Delta ||
                   Math.Abs(C * C + B * B - A * A) < Delta;
        }

        /// <summary>
        /// Получить площадь треугольника
        /// </summary>
        /// <returns>Площадь треугольника</returns>
        public override double GetArea()
        {
            double halfPerimeter = (A + B + C) / 2;
            double area = Math.Sqrt(halfPerimeter * (halfPerimeter - A) *
                              (halfPerimeter - B) *
                              (halfPerimeter - C));

            return area;
        }

        /// <summary>
        /// Проверка на корректность длин сторон треугольника
        /// </summary>
        /// <param name="a">Сторона a</param>
        /// <param name="b">Сторона b</param>
        /// <param name="c">Сторона c</param>
        /// <returns></returns>
        private static bool IsTriangleExist(double a, double b, double c)
        {
            return (a + b > c) && (b + c > a) && (a + c) > b;
        }
    }
}
