using System;

namespace Lab6
{
    /// <summary>
    /// Представляет рациональную дробь.
    /// </summary>
    public class Fraction : ICloneable
    {
        // Поля для хранения числителя и знаменателя
        private int _numerator;
        private int _denominator;

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Fraction"/> с указанными числителем и знаменателем.
        /// </summary>
        /// <param name="numerator">Числитель.</param>
        /// <param name="denominator">Знаменатель. Не может быть равен нулю.</param>
        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new DivideByZeroException("Знаменатель дроби не может быть равен нулю.");
            }
            // Нормализация: знаменатель должен быть положительным
            if (denominator < 0)
            {
                numerator = -numerator;
                denominator = -denominator;
            }
            _numerator = numerator;
            _denominator = denominator;
            Simplify();
        }

        /// <summary>
        /// Возвращает числитель дроби.
        /// </summary>
        public int Numerator
        {
            get { return _numerator; }
        }

        /// <summary>
        /// Возвращает знаменатель дроби.
        /// </summary>
        public int Denominator
        {
            get { return _denominator; }
        }

        // Вспомогательный метод для сокращения дроби
        private void Simplify()
        {
            int gcd = Gcd(Math.Abs(_numerator), _denominator);
            _numerator /= gcd;
            _denominator /= gcd;
        }

        // Вспомогательный метод для вычисления НОД
        private static int Gcd(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        /// <summary>
        /// Возвращает строковое представление дроби в формате "числитель/знаменатель".
        /// </summary>
        /// <returns>Строка с дробью.</returns>
        public override string ToString()
        {
            return $"{_numerator}/{_denominator}";
        }

        // Перегрузки операций

        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            int num = f1._numerator * f2._denominator + f2._numerator * f1._denominator;
            int den = f1._denominator * f2._denominator;
            return new Fraction(num, den);
        }

        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            int num = f1._numerator * f2._denominator - f2._numerator * f1._denominator;
            int den = f1._denominator * f2._denominator;
            return new Fraction(num, den);
        }

        public static Fraction operator *(Fraction f1, Fraction f2)
        {
            int num = f1._numerator * f2._numerator;
            int den = f1._denominator * f2._denominator;
            return new Fraction(num, den);
        }

        public static Fraction operator /(Fraction f1, Fraction f2)
        {
            if (f2._numerator == 0)
            {
                throw new DivideByZeroException("Деление на ноль: числитель второй дроби равен нулю.");
            }
            int num = f1._numerator * f2._denominator;
            int den = f1._denominator * f2._numerator;
            return new Fraction(num, den);
        }

        public static Fraction operator +(Fraction f, int n)
        {
            return f + new Fraction(n, 1);
        }

        public static Fraction operator -(Fraction f, int n)
        {
            return f - new Fraction(n, 1);
        }

        public static Fraction operator *(Fraction f, int n)
        {
            return f * new Fraction(n, 1);
        }

        public static Fraction operator /(Fraction f, int n)
        {
            if (n == 0)
            {
                throw new DivideByZeroException("Деление на ноль.");
            }
            return f / new Fraction(n, 1);
        }

        // Для симметрии
        public static Fraction operator +(int n, Fraction f)
        {
            return f + n;
        }

        public static Fraction operator -(int n, Fraction f)
        {
            return new Fraction(n, 1) - f;
        }

        public static Fraction operator *(int n, Fraction f)
        {
            return f * n;
        }

        public static Fraction operator /(int n, Fraction f)
        {
            if (f._numerator == 0)
            {
                throw new DivideByZeroException("Деление на ноль: числитель второй дроби равен нулю.");
            }
            return new Fraction(n, 1) / f;
        }

        /// <summary>
        /// Проверяет, равны ли две дроби по значению (численности и знаменателю).
        /// </summary>
        /// <param name="obj">Объект для сравнения.</param>
        /// <returns>True, если дроби равны; иначе false.</returns>
        public override bool Equals(object obj)
        {
            if (obj is Fraction other)
            {
                return this._numerator == other._numerator && this._denominator == other._denominator;
            }
            return false;
        }

        /// <summary>
        /// Возвращает хэш-код для дроби.
        /// </summary>
        /// <returns>Хэш-код.</returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(_numerator, _denominator);
        }

        /// <summary>
        /// Создаёт новый экземпляр дроби, являющийся копией текущего.
        /// </summary>
        /// <returns>Новый экземпляр <see cref="Fraction"/>.</returns>
        public object Clone()
        {
            return new Fraction(_numerator, _denominator);
        }
    }
}