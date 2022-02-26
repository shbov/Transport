using System;
using System.IO;
using System.Linq;
using System.Text;
using EKRLib;

namespace ConsoleApp
{
    /// <summary>
    ///     Класс, отвечающий за работу консольного приложения.
    /// </summary>
    internal class Program
    {
        /// <summary>
        ///     Экземпляр класса Random.
        /// </summary>
        private static readonly Random s_rnd = new();

        /// <summary>
        ///     Точка входа.
        /// </summary>
        private static void Main()
        {
            do
            {
                var length = s_rnd.Next(6, 10);
                var transports = new Transport[length];

                for (var i = 0; i < length; i++)
                {
                    transports[i] = GenerateTransport();
                    Console.WriteLine(transports[i].StartEngine());
                }

                Write(transports.Where(item => item is Car).ToArray(), "Cars.txt");
                Write(transports.Where(item => item is MotorBoat).ToArray(), "MotorBoats.txt");

                Console.WriteLine("Повторим? 'Y' – да, иначе – любая клавиша.");
            } while (Console.ReadKey(true).Key == ConsoleKey.Y);
        }

        /// <summary>
        ///     Создание рандомного транспорта.
        /// </summary>
        /// <returns>Ссылка на объект типа Transport(Car/MotorBoat)</returns>
        private static Transport GenerateTransport()
        {
            Transport transport = null;

            do
            {
                try
                {
                    if (s_rnd.Next(0, 1 + 1) == 0)
                        transport = new Car(GenerateModel(), (uint) s_rnd.Next(10, 100));
                    else
                        transport = new MotorBoat(GenerateModel(), (uint) s_rnd.Next(10, 100));
                }
                catch (TransportException e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (transport == null);

            return transport;
        }

        /// <summary>
        ///     Записать все машины/лодки в файл.
        /// </summary>
        /// <param name="transports">Ссылка на массив типа Transport.</param>
        /// <param name="fileName">Название файла.</param>
        private static void Write(Transport[] transports, string fileName)
        {
            var sep = Path.DirectorySeparatorChar;
            try
            {
                using var sw = new StreamWriter($"..{sep}..{sep}..{sep}{fileName}", false, Encoding.Unicode);

                var sb = new StringBuilder();
                foreach (var item in transports) sb.Append(item + Environment.NewLine);

                sw.Flush();
                sw.Write(sb.ToString().TrimEnd());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        ///     Создать рандомную модель транспорта.
        /// </summary>
        /// <returns>Строка.</returns>
        private static string GenerateModel()
        {
            var sb = new StringBuilder();

            for (var i = 0; i < 5; i++)
                if (s_rnd.Next(0, 1 + 1) == 0)
                    sb.Append((char) s_rnd.Next('A', 'Z' + 1));
                else
                    sb.Append((char) s_rnd.Next('0', '9' + 1));

            return sb.ToString();
        }
    }
}