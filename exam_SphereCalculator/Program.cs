using System;

namespace exam_phereCalculatorLibrary
{
    // Публичный класс, который будет доступен для вызывающей программы
    public class SphereCalculator
    {
        // Метод для вычисления объема по радиусу (r)
        public static double CalculateVolumeByRadius(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Радиус не может быть отрицательным.");
            }
            // Формула: V = (4/3) * PI * r^3
            return (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
        }

        // Метод для вычисления объема по диаметру (d)
        public static double CalculateVolumeByDiameter(double diameter)
        {
            if (diameter < 0)
            {
                throw new ArgumentException("Диаметр не может быть отрицательным.");
            }
            double radius = diameter / 2.0;

            return CalculateVolumeByRadius(radius);
        }
    }
}