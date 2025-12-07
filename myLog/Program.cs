using Serilog;
using Serilog.Core;
using System;

namespace MyLog
{
    internal class Program
    {
        private static Logger logger;

        static void Main(string[] args)
        {
            // 1. Конфигурация логгера
            logger = new LoggerConfiguration()
                // !!! Внимание: используйте Path.Combine для надежности путей.
                .WriteTo.File($"logs/{DateTime.Now:dd.MM.yyyy}.log",
                    outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss} [{Level:u3}] {Message:lj}{NewLine}{Exception}")
                .CreateLogger();

            logger.Information("Application started successfully.");

            Console.WriteLine("Факториал числа (N!)");

            Console.Write("Введите целое число (0-20): ");

            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                logger.Information("User input accepted: {Input}", input);

                long result = CalculateFactorial(number);

                Console.WriteLine($"Факториал числа {number} ({number}!) = {result}");
                logger.Information("Factorial calculated: {Number}! = {Result}", number, result);
            }
            else
            {
                // Логирование ошибки, если ввод недействителен
                logger.Error("Invalid input received: '{Input}'. Cannot calculate factorial.", input);
                Console.WriteLine("Ошибка: Введите корректное целое число.");
            }

            logger.Information("Application finished.");
            // Обязательно выполните Flush, чтобы убедиться, что все ожидающие логи записаны в файл
            Log.CloseAndFlush();
            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }

        public static long CalculateFactorial(int n)
        {
            // Логирование условий и крайних случаев
            if (n < 0)
            {
                logger.Warning("Attempted to calculate factorial for a negative number: {Number}. Returning 1.", n);
                // Факториал отрицательного числа не определен, возвращаем 1 или обрабатываем ошибку.
                return 1;
            }
            if (n > 20) // long может безопасно хранить до 20!
            {
                logger.Error("Number {Number} is too large. Factorial calculation will overflow.", n);
                Console.WriteLine("Предупреждение: Число слишком большое. Результат будет неточным.");
                // Намеренно оставляем переполнение для демонстрации
            }

            // Логирование начала расчета
            logger.Debug("Starting factorial calculation for {N}", n);

            long fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }

            // Логирование завершения расчета
            logger.Debug("Factorial calculation complete.");
            return fact;
        }
    }
}