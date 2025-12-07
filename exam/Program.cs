using Serilog.Core;
using exam_phereCalculatorLibrary;

namespace exam
{

    internal class Program
    {
        // для 10 
        // Класс для внутреннего объекта в массиве 'data'
        public class DataItem
        {
            public string code { get; set; }
            public string name { get; set; }

            public override string ToString()
            {
                return $"{{ 'code': '{code}', 'name': '{name}' }}";
            }
        }

        // Класс для корневого объекта JSON
        public class RootObject
        {
            public int id { get; set; }
            public List<DataItem> data { get; set; } // Коллекция DataItem
        }

        static void Main(string[] args)
        {
            Console.WriteLine("exam");
            Console.WriteLine("exemple 1");

            string commonAddress = "ул. Пушкина, д. Колотушкина";

            ex_1.Grandparent grandma = new ex_1.Grandparent(commonAddress);
            ex_1.Parent mom = new ex_1.Parent(commonAddress);
            ex_1.Child daughter = new ex_1.Child(commonAddress);

            Console.WriteLine(grandma.ToString());
            mom.Walk("работа");
            daughter.Sleep(8);

            //2
            Console.WriteLine("exemple 2");
            DemoGenericRepository();
        }

        public static void DemoGenericRepository()
        {
            var studentManager = new ex_2.PeopleManager<ex_2.Student>();

            // Добавление
            var student1 = new ex_2.Student(201, "Иван Петров", "1999-05-15", "Группа А");
            studentManager.Add(student1);

            // Добавление других сущностей (пример)
            var pupil1 = new ex_2.PUPIL(202, "Маша Смирнова", "2010-10-01", "5 'В'");

            // Получение и вывод
            Console.WriteLine("Текущий список:");
            // Используем .ForEach() или foreach для вывода
            studentManager.GetAll().ForEach(s => Console.WriteLine(s));

            // Изменение
            var updatedStudent = new ex_2.Student(201, "Иван П. (Обновлено)", "1999-05-15", "Группа Б");
            studentManager.Update(updatedStudent);

            Console.WriteLine("\nПосле обновления:");
            Console.WriteLine(studentManager.GetById(201));

            // Удаление
            studentManager.Delete(201);
            Console.WriteLine("\nПосле удаления, список пуст: " + (studentManager.GetAll().Count == 0));


            //3
            Console.WriteLine("exemple 3");

            double lengthInput;
            double widthInput;
            double heightInput;

            Console.WriteLine("введите длину: ");
            lengthInput = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("введите ширину: ");
            widthInput = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("введите высоту: ");
            heightInput = Convert.ToDouble(Console.ReadLine());


            ex_3.Parallelepiped box = new ex_3.Parallelepiped(lengthInput, widthInput, heightInput);

            // 4. Использование объекта
            Console.WriteLine($"Объем = {box.Volume()}");


            //Console.WriteLine("exemple 4");
            //ex_4.SimulateExceptions();

            Console.WriteLine("exemple 5");
            Console.WriteLine();

            var results = exam.ex_5.RunQueries();

            Console.WriteLine("a) Объединение с повторами:");
            Console.WriteLine(string.Join(",\n", results.a.Select(p => p.ToString())));

            Console.WriteLine("b) Объединение без повторов:");
            Console.WriteLine(string.Join(",\n", results.b.Select(p => p.ToString())));

            Console.WriteLine("c) Родители только из 1 коллекции:");
            Console.WriteLine(string.Join(",\n", results.c.Select(p => p.ToString())));

            Console.WriteLine("d) Общие родители:");
            Console.WriteLine(string.Join(",\n", results.d.Select(p => p.ToString())));

            Console.WriteLine("e) Родители, возраст которых > 40 лет:");
            Console.WriteLine(string.Join(",\n", results.e.Select(p => p.ToString())));

            Console.WriteLine("f) Самый молодой и самый пожилой родители:");
            Console.WriteLine(string.Join(",\n", results.f.Select(p => p.ToString())));

            //найти все простые числа в диапазоне от 1 до 1000, записать их в ло
            Console.WriteLine("exemple 6");
            ex_6.RunExample();

            Console.WriteLine("exemple 7");

            try
            {
                // a) Создать years.txt и записать високосные годы
                int count = ex_7.CreateAndWriteLeapYears();
                Console.WriteLine($"\na) Записано {count} високосных лет в файл: {ex_7.filePath1}");

                // b) Вывести все файлы с рабочего стола
                Console.WriteLine("\nb) Файлы на Рабочем столе:");
                foreach (var file in ex_7.ListDesktopFiles())
                {
                    Console.WriteLine($"  - {file}");
                }

                // c) Скопировать years.txt в years2.txt
                ex_7.CopyFile();
                Console.WriteLine($"\nc) Файл скопирован в: {ex_7.filePath2}");

                // d) Удалить в years2.txt все строки, кроме последней
                string lastLine = ex_7.KeepLastLine();
                Console.WriteLine("\nd) В years2.txt оставлена только последняя строка.");
                Console.WriteLine($"Содержимое years2.txt: {lastLine.Trim()}");

                // e) Вывести содержимое years.txt в ОДНУ СТРОКУ
                string contentOneLine = ex_7.GetContentInOneLine();
                Console.WriteLine("\ne) Содержимое years.txt в ОДНУ СТРОКУ:");
                Console.WriteLine(contentOneLine);

                // f) Удалить файлы years.txt и years2.txt
                var (deleted1, deleted2) = ex_7.DeleteFiles();
                Console.WriteLine("\nf) Удаление созданных файлов...");
                Console.WriteLine($"Файл {ex_7.filePath1}: {(deleted1 ? "Удален" : "Не найден")}");
                Console.WriteLine($"Файл {ex_7.filePath2}: {(deleted2 ? "Удален" : "Не найден")}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n[КРИТИЧЕСКАЯ ОШИБКА ФАЙЛОВЫХ ОПЕРАЦИЙ] {ex.Message}");
            }

            Console.WriteLine("exemple 8");
            //ex_8.RunExample();


            Console.WriteLine("exemple 9");

            // --- Вычисление по радиусу ---
            double radius = 7.5;
            try
            {
                // Вызов метода из подключенной библиотеки
                double volumeR = SphereCalculator.CalculateVolumeByRadius(radius);
                Console.WriteLine($"\nОбъем шара с радиусом r={radius} (через DLL) равен: {volumeR:F4}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            // --- Вычисление по диаметру ---
            double diameter = 15.0;
            try
            {
                // Вызов метода из подключенной библиотеки
                double volumeD = SphereCalculator.CalculateVolumeByDiameter(diameter);
                Console.WriteLine($"Объем шара с диаметром d={diameter} (через DLL) равен: {volumeD:F4}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");

            }
            Console.WriteLine("example 10 ");

            string finalJson = exam.ex_10.RunExample();

            Console.WriteLine("json");
            Console.WriteLine(finalJson);

        }
    }
}