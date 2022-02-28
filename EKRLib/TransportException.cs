using System;
using System.Runtime.Serialization;

namespace EKRLib
{
    /// <summary>
    ///     Класс, отвечающий за работу TransportException.
    /// </summary>
    [Serializable]
    public class TransportException : Exception
    {
        /// <summary>
        ///     Конструктор класса.
        /// </summary>
        public TransportException()
        {
        }

        /// <summary>
        ///     Конструктор класса.
        /// </summary>
        /// <param name="message">Сообщение.</param>
        public TransportException(string message) : base(message)
        {
        }

        /// <summary>
        ///     Конструктор класса.
        /// </summary>
        /// <param name="message">Сообщение.</param>
        /// <param name="innerException">Внутренний exception.</param>
        public TransportException(string message, Exception innerException) : base(message, innerException)
        {
        }

        /// <summary>
        ///     Конструктор класса.
        /// </summary>
        /// <param name="info">Инфо.</param>
        /// <param name="context">Контекст.</param>
        protected TransportException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}