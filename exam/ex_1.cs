using System;

namespace exam
{
    internal class ex_1
    {
        public abstract class Family
        {
            protected string Type { get; set; }
            protected string Name { get; set; }
            public string Address { get; set; }
            protected int Age { get; set; }
            protected int Height { get; set; }
            protected int Weight { get; set; }

            public abstract string GetDailyActivity();

            public Family(string type, string name, string address, int age, int height, int weight)
            {
                Type = type;
                Name = name;
                Address = address;
                Age = age;
                Height = height;
                Weight = weight;
            }
            public virtual void Walk(string destination)
            {
                Console.WriteLine($"{Name} ({Type}) идёт в {destination}.");
            }

            public virtual void Talk(string message)
            {
                Console.WriteLine($"{Name} ({Type}) говорит: \"{message}\"");
            }

            public virtual void Sleep(int hours)
            {
                Console.WriteLine($"{Name} ({Type}) спит {hours} часов.");
            }

            public override string ToString()
            {
                // Для вывода используем защищенные свойства
                return $"{Type}: {Name}, Адрес: {Address}, Возраст: {Age}, Рост: {Height}, Вес: {Weight}. Занятие: {GetDailyActivity()}";
            }
        }

        // --- Наследники ---

        public class Grandparent : Family
        {
            public Grandparent(string address)
                : base("Grand", "Бабушка", address, 68, 165, 70)
            {
            }

            // Переопределение отличительного действия
            public override string GetDailyActivity()
            {
                return "сидят дома";
            }
        }

        public class Parent : Family
        {
            public Parent(string address)
                : base("Parent", "Мама", address, 40, 170, 65)
            {
            }

            // Переопределение отличительного действия
            public override string GetDailyActivity()
            {
                return "ходят на работу";
            }

            // Пример переопределения общего действия (полиморфизм)
            public override void Walk(string destination)
            {
                Console.WriteLine($" {Name} ({Type}) торопливо идёт на {destination}.");
            }
        }

        public class Child : Family
        {
            public Child(string address)
                : base("Child", "Варвара", address, 10, 140, 40)
            {
            }

            // Переопределение отличительного действия
            public override string GetDailyActivity()
            {
                return "ходят в школу";
            }
        }

        // Демонстрация использования классов

        public static void DemoUsage()
        {
            string commonAddress = "ул. Пушкина, д. Колотушкина";

            Grandparent grandma = new Grandparent(commonAddress);
            Parent mom = new Parent(commonAddress);
            Child daughter = new Child(commonAddress);

            Console.WriteLine(grandma.ToString());
            Console.WriteLine(mom.ToString());
            Console.WriteLine(daughter.ToString());

            Console.WriteLine("\n--- Демонстрация Полиморфизма (Walk) ---");
            grandma.Walk("магазин");
            mom.Walk("совещание");
            daughter.Walk("урок физкультуры");

        }
    }
}