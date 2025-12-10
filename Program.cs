using System;
using System.Collections.Generic;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Задание 1.1: Кот Барсик ---");
            Cat barsik = new Cat("Барсик");
            Console.WriteLine(barsik.ToString()); // кот: Барсик
            barsik.Meow(); // Барсик: мяу!
            barsik.Meow(3); // Барсик: мяу-мяу-мяу!

            Console.WriteLine("\n--- Задание 1.2: Интерфейс Мяуканье ---");
            List<IMeowable> meowables = new List<IMeowable>
            {
                new Cat("Мурзик"),
                new Cat("Рыжик"),
                new RobotCat("РобоКот-3000")
            };
            MeowHelper.MakeMeow(meowables);
            // Вывод:
            // Мурзик: мяу!
            // Рыжик: мяу!
            // РобоКот-3000: бип-бип-мяу!

            Console.WriteLine("\n--- Задание 1.3: Количество мяуканий (новая версия) ---");
            IMeowable m = new Cat("Тимоша"); // Создаем кота
            Funs.MeowsCare(m); // Вызываем метод, который заставляет мяукать 5 раз
            Console.WriteLine($"кот мяукал {((Cat)m).MeowCount} раз"); // Вывод: кот мяукал 5 раз

            Console.WriteLine("\n--- Задание 2: Дроби ---");
            Console.WriteLine("--- Задание 2.1: Создание и операции ---");
            Fraction f1 = new Fraction(1, 3);
            Fraction f2 = new Fraction(2, 3);
            Fraction f3 = new Fraction(1, 9);

            Console.WriteLine($"{f1} + {f2} = {f1 + f2}"); // 1/3 + 2/3 = 1/1
            Console.WriteLine($"{f1} - {f2} = {f1 - f2}"); // 1/3 - 2/3 = -1/3
            Console.WriteLine($"{f1} * {f2} = {f1 * f2}"); // 1/3 * 2/3 = 2/9

            Fraction result = f1 + f2; // 1/1
            Fraction result2 = result / f3; // 1/1 / 1/9 = 9/1
            Fraction finalResult = result2 - 5; // 9/1 - 5 = 4/1
            Console.WriteLine($"({f1} + {f2}) / {f3} - 5 = {finalResult}"); // (1/3 + 2/3) / 1/9 - 5 = 4/1

            Console.WriteLine("\n--- Задание 2.2: Сравнение дробей ---");
            Fraction f4 = new Fraction(2, 6); // Эквивалентно 1/3
            Console.WriteLine($"f1 ({f1}) == f4 ({f4})? {f1.Equals(f4)}"); // True

            Console.WriteLine("\n--- Задание 2.3: Клонирование дроби ---");
            Fraction clonedF1 = (Fraction)f1.Clone();
            Console.WriteLine($"f1: {f1}, clonedF1: {clonedF1}, f1 == clonedF1? {f1.Equals(clonedF1)}"); // True

            Console.WriteLine("\n--- Задание 2.4: Интерфейс IFractionOperations и кэширование ---");
            CachedFraction cf1 = new CachedFraction(1, 3);
            Console.WriteLine($"Вещественное значение cf1: {cf1.GetDoubleValue()}"); // 0.3333333333333333
            Console.WriteLine($"Повторный вызов: {cf1.GetDoubleValue()}"); // 0.3333333333333333 (из кэша)
        }
    }
}