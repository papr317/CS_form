using System;
using Serilog;


namespace exam
{
    internal class ex_6
    {
        // Инициализация логгера
        private static ILogger logger = new LoggerConfiguration()
            .WriteTo.File("logs\\exam_log.txt", rollingInterval: RollingInterval.Day)
            .CreateLogger();

        // Метод для определения, является ли число простым
        private static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
        public static void RunExample()
        {
            logger.Information("Application started. Searching for prime numbers from 1 to 1000.");

            try
            {
                for (int i = 1; i <= 1000; i++)
                {
                    if (IsPrime(i))
                    {
                        logger.Information("Простое число найдено: {Number}", i);
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "An error occurred while finding prime numbers.");
            }
            finally
            {
                logger.Information("Application ended.");
                Log.CloseAndFlush();
            }
        }
    }
}