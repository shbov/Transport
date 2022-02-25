namespace EKRLib
{
    /// <summary>
    ///     Абстрактный класс Transport
    /// </summary>
    public abstract class Transport
    {
        private string _model;

        private uint _power;

        /// <summary>
        ///     Конструктор класса.
        /// </summary>
        /// <param name="model">Модель.</param>
        /// <param name="power">Мощность.</param>
        protected Transport(string model, uint power)
        {
            Model = model;
            Power = power;
        }

        /// <summary>
        ///     Модель транспорта.
        /// </summary>
        /// <exception cref="TransportException"></exception>
        public string Model
        {
            get => _model;
            set
            {
                if (!checkModelInput(value))
                    throw new TransportException($"Недопустимая модель {value}");

                _model = value;
            }
        }

        /// <summary>
        ///     Мощность транспорта.
        /// </summary>
        /// <exception cref="TransportException"></exception>
        public uint Power
        {
            get => _power;
            set
            {
                if (!checkPowerInput(value))
                    throw new TransportException("мощность не может быть меньше 20 л.с.");

                _power = value;
            }
        }

        /// <summary>
        ///     Являются ли входные данные для мощности корректными?
        /// </summary>
        /// <param name="value">Входные данные.</param>
        /// <returns>true – корректны, false – нет.</returns>
        private bool checkPowerInput(uint value)
        {
            return value >= 20;
        }

        /// <summary>
        ///     Являются ли входные данные для модели корректными?
        /// </summary>
        /// <param name="value">Входные данные.</param>
        /// <returns>true – корректны, false – нет.</returns>
        private bool checkModelInput(string value)
        {
            if (string.IsNullOrEmpty(value))
                return false;

            if (value.Length != 5)
                return false;

            foreach (var item in value)
                if (item is (< 'A' or > 'Z') and (< '0' or > '9'))
                    return false;

            return true;
        }

        /// <summary>
        ///     Переопределение метода ToString.
        /// </summary>
        /// <returns>Строка.</returns>
        public override string ToString()
        {
            return $"Model: {Model}, Power: {Power}";
        }

        /// <summary>
        ///     Запуск двигателя.
        /// </summary>
        /// <returns>Строка.</returns>
        public abstract string StartEngine();
    }
}