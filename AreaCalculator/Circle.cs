namespace AreaCalculator
{
    /// <summary>
    /// Круг
    /// </summary>
    public sealed class Circle : Figure
    {
        private const string CurrentFigureName = "Круг";

        /// <summary>
        /// Инициализирует новый экземпляр
        /// </summary>
        /// <param name="radius">Радиус</param>
        public Circle(double radius) : base(CurrentFigureName)
        {
            if (radius <= 0)
                throw new ArgumentException($"Недопустимое значение параметра '{nameof(radius)}', значение должно быть больше 0");
            Radius = radius;
        }

        /// <summary>
        /// Радиус круга
        /// </summary>
        public double Radius { get; }

        /// <summary>
        /// Получить площадь круга
        /// </summary>
        /// <returns>Площадь круга</returns>
        public override double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
