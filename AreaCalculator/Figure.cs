namespace AreaCalculator
{
    /// <summary>
    /// Базовая фигура
    /// </summary>
    public abstract class Figure
    {
        /// <summary>
        /// Инициализирует новый экземпляр
        /// </summary>
        /// <param name="name">Название фигуры</param>
        protected Figure(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Название фигуры
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Получить площадь фигуры
        /// </summary>
        /// <returns>Площадь фигуры</returns>
        public abstract double GetArea();

    }
}
