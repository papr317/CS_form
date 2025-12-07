using System;

namespace exam
{
    internal class ex_8
    {

        // a) Метод с обычными аргументами (; 

        public static double CalculateAreaByValue(double length, double width, double height)
        {
            // Аргументы передаются по значению. Метод возвращает результат напрямую.
            return 2 * (length * width + length * height + width * height);
        }
        // b) Метод с аргументом ref
        public static void CalculateAreaByRef(double length, double width, double height, ref double resultArea)
        {
            resultArea = 2 * (length * width + length * height + width * height);
        }

        // c) Метод с аргументом outt
        public static void CalculateAreaByOut(double length, double width, double height, out double area)
        {
            area = 2 * (length * width + length * height + width * height);
        }

        // d) Метод с использованием кортеей

        public static double CalculateAreaByTuple((double l, double w, double h) dimensions)
        {

            double l = dimensions.l;
            double w = dimensions.w;
            double h = dimensions.h;

            return 2 * (l * w + l * h + w * h);
        }
    }
}