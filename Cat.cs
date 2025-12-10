using System;

namespace Lab6
{
    /// <summary>
    /// Представляет сущность Кота.
    /// </summary>
    public class Cat : IMeowable
    {
        // Поле для хранения имени кота
        private string _name;
        // Поле для подсчёта количества мяуканий
        private int _meowCount;

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Cat"/> с указанным именем.
        /// </summary>
        /// <param name="name">Имя кота.</param>
        public Cat(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Имя кота не может быть пустым.", nameof(name));
            }
            _name = name;
            _meowCount = 0; // Инициализируем счётчик при создании
        }

        /// <summary>
        /// Возвращает имя кота.
        /// </summary>
        public string Name
        {
            get { return _name; }
        }

        /// <summary>
        /// Возвращает количество мяуканий, выполненных котом.
        /// </summary>
        public int MeowCount
        {
            get { return _meowCount; }
        }

        /// <summary>
        /// Возвращает строковое представление кота в формате "кот: Имя".
        /// </summary>
        /// <returns>Строка с описанием кота.</returns>
        public override string ToString()
        {
            return $"кот: {_name}";
        }

        /// <summary>
        /// Выполняет мяуканье один раз и выводит "Имя: мяу!" на экран.
        /// </summary>
        public void Meow()
        {
            Console.WriteLine($"{_name}: мяу!");
            _meowCount++;
        }

        /// <summary>
        /// Выполняет мяуканье N раз и выводит "Имя: мяу-мяу-...-мяу!" на экран.
        /// </summary>
        /// <param name="n">Количество мяуканий.</param>
        public void Meow(int n)
        {
            if (n <= 0)
            {
                Console.WriteLine($"{_name}: (молчит)");
                return;
            }
            string[] meowsArray = new string[n];
            for (int i = 0; i < n; i++)
            {
                meowsArray[i] = "мяу";
            }
            string meows = string.Join("-", meowsArray);

        }
    }
}