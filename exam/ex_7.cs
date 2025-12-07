using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace exam
{
    internal class ex_7
    {
        private static readonly string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public static readonly string filePath1 = Path.Combine(desktopPath, "years.txt");
        public static readonly string filePath2 = Path.Combine(desktopPath, "years2.txt");

        // a) Создание years.txt и запись високосных летe
        public static int CreateAndWriteLeapYears()
        {
            var years = Enumerable.Range(1900, 2023 - 1900 + 1)
                .Where(year => DateTime.IsLeapYear(year))
                .Select(y => y.ToString())
                .ToList();

            File.WriteAllLines(filePath1, years);
            return years.Count;
        }

        // b) Вывод всех файлов с рабочего стола
        public static IEnumerable<string> ListDesktopFiles()
        {
            return Directory.GetFiles(desktopPath)
                            .Select(f => Path.GetFileName(f));
        }

        // c) Копирование years.txt в years2.txt
        public static void CopyFile()
        {
            File.Copy(filePath1, filePath2, true);
        }

        // d) Удаление всех строк, кроме последней, в years2.txt (возвращает последнюю строку)
        public static string KeepLastLine()
        {
            var lines = File.ReadAllLines(filePath2);
            if (lines.Length > 0)
            {
                string lastLine = lines.Last();
                File.WriteAllText(filePath2, lastLine + Environment.NewLine);
                return lastLine;
            }
            return "Файл пуст.";
        }

        // e) Получение содержимого years.txt в одну строку
        public static string GetContentInOneLine()
        {
            return string.Join(" ", File.ReadAllLines(filePath1));
        }

        // f) Удаление файлов
        public static (bool deleted1, bool deleted2) DeleteFiles()
        {
            bool deleted1 = false;
            if (File.Exists(filePath1))
            {
                File.Delete(filePath1);
                deleted1 = true;
            }
            bool deleted2 = false;
            if (File.Exists(filePath2))
            {
                File.Delete(filePath2);
                deleted2 = true;
            }
            return (deleted1, deleted2);
        }
    }
}