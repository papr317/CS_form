using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    // В методе симитировать все возможные исключения (Деление на ноль, nullReference ит.д. - не менее 4). 
    internal class ex_4
    {
        public static void SimulateExceptions()
        {
            // 1. Деление на ноль
            try
            {
                int zero = 0;
                int result = 10 / zero;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"ошибка: {ex.Message}");
            }
            // 2. NullReferenceException
            try
            {
                string str = null;
                int length = str.Length;
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine($"Caught an exception: {ex.Message}");
            }
            // 3. IndexOutOfRangeException
            try
            {
                int[] array = new int[5];
                int value = array[10];
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Caught an exception: {ex.Message}");
            }
            // 4. FormatException
            try
            {
                string invalidNumber = "abc";
                int number = int.Parse(invalidNumber);
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Caught an exception: {ex.Message}");
            }
        }

    }
}
