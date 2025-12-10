using System;

namespace Lab6
{
    /// <summary>
    /// Класс Дробь с кэшированием вещественного значения и интерфейсом IFractionOperations.
    /// </summary>
    public class CachedFraction : Fraction, IFractionOperations
    {
        private double? _cachedValue = null; // Кэш для вещественного значения

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="CachedFraction"/>.
        /// </summary>
        /// <param name="numerator">Числитель.</param>
        /// <param name="denominator">Знаменатель.</param>
        public CachedFraction(int numerator, int denominator) : base(numerator, denominator)
        {
        }

        /// <summary>
        /// Получает вещественное значение дроби. Значение кэшируется после первого вызова.
        /// </summary>
        /// <returns>Вещественное значение.</returns>
        public double GetDoubleValue()
        {
            if (_cachedValue == null)
            {
                _cachedValue = (double)base.Numerator / base.Denominator;
            }
            return _cachedValue.Value;
        }

        /// <summary>
        /// Устанавливает новый числитель и сбрасывает кэш.
        /// </summary>
        /// <param name="numerator">Новый числитель.</param>
        public void SetNumerator(int numerator)
        {
            var oldDenominator = base.Denominator;
            var newFraction = new Fraction(numerator, oldDenominator);
            throw new InvalidOperationException("Объект неизменяем. Операция установки невозможна без создания нового объекта.");
        }

        /// <summary>
        /// Устанавливает новый знаменатель и сбрасывает кэш.
        /// </summary>
        /// <param name="denominator">Новый знаменатель.</param>
        public void SetDenominator(int denominator)
        {
            var oldNumerator = base.Numerator;
            var newFraction = new Fraction(oldNumerator, denominator);
            throw new InvalidOperationException("Объект неизменяем. Операция установки невозможна без создания нового объекта.");
        }
    }
}