using System.Collections.Generic;

namespace Lab6
{
    /// <summary>
    /// Статический класс, содержащий методы для работы с мяукающими объектами.
    /// </summary>
    public static class MeowHelper
    {
        /// <summary>
        /// Вызывает мяуканье у каждого объекта в переданной коллекции.
        /// </summary>
        /// <param name="meowables">Коллекция мяукающих объектов.</param>
        public static void MakeMeow(IEnumerable<IMeowable> meowables)
        {
            foreach (var meowable in meowables)
            {
                meowable.Meow();
            }
        }
    }
}