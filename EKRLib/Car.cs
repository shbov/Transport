namespace EKRLib
{
    /// <summary>
    ///     Класс Car.
    /// </summary>
    public class Car : Transport
    {
        /// <summary>
        ///     Конструктор класса.
        /// </summary>
        /// <param name="model">Модель.</param>
        /// <param name="power">Мощность.</param>
        public Car(string model, uint power) : base(model, power)
        {
        }

        /// <summary>
        ///     Запуск двигателя.
        /// </summary>
        /// <returns>Строка.</returns>
        public override string StartEngine()
        {
            return $"{Model}: Vroom";
        }

        /// <summary>
        ///     Переопределение метода ToString.
        /// </summary>
        /// <returns>Строка.</returns>
        public override string ToString()
        {
            return $"Car. {base.ToString()}";
        }
    }
}