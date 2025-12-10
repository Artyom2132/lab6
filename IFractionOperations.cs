namespace Lab6
{
    /// <summary>
    /// Определяет операции для работы с дробью.
    /// </summary>
    public interface IFractionOperations
    {
        /// <summary>
        /// Получает вещественное значение дроби.
        /// </summary>
        /// <returns>Вещественное значение.</returns>
        double GetDoubleValue();

        /// <summary>
        /// Устанавливает новый числитель.
        /// </summary>
        /// <param name="numerator">Новый числитель.</param>
        void SetNumerator(int numerator);

        /// <summary>
        /// Устанавливает новый знаменатель.
        /// </summary>
        /// <param name="denominator">Новый знаменатель. Не может быть равен нулю.</param>
        void SetDenominator(int denominator);
    }
}