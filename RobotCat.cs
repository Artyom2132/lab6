using System;

namespace Lab6
{
    /// <summary>
    /// Пример другого мяукающего объекта.
    /// </summary>
    public class RobotCat : IMeowable
    {
        private string _name;

        public RobotCat(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Имя робокота не может быть пустым.", nameof(name));
            }
            _name = name;
        }

        public void Meow()
        {
            Console.WriteLine($"{_name}: бип-бип-мяу!");
        }
    }
}