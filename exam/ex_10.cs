using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using static exam.Program;

namespace exam
{
    internal class ex_10
    {
        private const string JsonString = @"{
            ""id"": 1,
            ""data"": [
                {
                    ""code"": ""00001"",
                    ""name"": ""data1""
                },
                {
                    ""code"": ""00002"",
                    ""name"": ""data2""
                },
                {
                    ""code"": ""00003"",
                    ""name"": ""data3""
                }					
            ]
        }";

        public static string RunExample()
        {
            Console.WriteLine("exemple 10: Работа с JSON");

            // --- a) Десериализация строки в объект ---
            RootObject rootObject = JsonSerializer.Deserialize<RootObject>(JsonString);

            // Проверка десериализации
            Console.WriteLine("\nДесериализация успешна:");
            Console.WriteLine($"ID: {rootObject.id}");
            Console.WriteLine($"Количество элементов 'data' до добавления: {rootObject.data.Count}");

            // --- b) Добавить еще один item в коллекцию data ---
            DataItem newItem = new DataItem
            {
                code = "00004",
                name = "data4"
            };

            rootObject.data.Add(newItem);

            Console.WriteLine($"\nНовый элемент добавлен. Количество элементов 'data' после добавления: {rootObject.data.Count}");

            // --- c) Сериализовать объект обратно в json
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true // с отступами
            };

            string updatedJson = JsonSerializer.Serialize(rootObject, options);

            return updatedJson;
        }
    }
}