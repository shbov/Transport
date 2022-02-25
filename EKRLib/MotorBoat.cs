namespace EKRLib
{
    /// <summary>
    ///     Класс MotorBoat.
    /// </summary>
    public class MotorBoat : Transport
    {
        /// <summary>
        ///     Конструктор класса.
        /// </summary>
        /// <param name="model">Модель.</param>
        /// <param name="power">Мощность.</param>
        public MotorBoat(string model, uint power) : base(model, power)
        {
        }

        /// <summary>
        ///     Запуск двигателя.
        /// </summary>
        /// <returns>Строка.</returns>
        public override string StartEngine()
        {
            return $"{Model}: Brrrbrr";
        }

        /// <summary>
        ///     Переопределение метода ToString.
        /// </summary>
        /// <returns>Строка.</returns>
        public override string ToString()
        {
            return $"MotorBoat. {base.ToString()}";
        }
    }
}