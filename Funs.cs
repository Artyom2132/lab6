namespace Lab6
{
    /// <summary>
    /// Статический класс, содержащий вспомогательные методы.
    /// </summary>
    public static class Funs
    {
        /// <summary>
        /// Вызывает мяуканье у переданного мяукающего объекта 5 раз.
        /// </summary>
        /// <param name="meowable">Объект, реализующий интерфейс IMeowable.</param>
        public static void MeowsCare(IMeowable meowable)
        {
            for (int i = 0; i < 5; i++)
            {
                meowable.Meow();
            }
        }
    }
}