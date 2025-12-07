using System;
using System.Collections.Generic;
using System.Linq;

namespace exam
{
    public class Parent
    {
        public string Name { get; set; }
        public int age { get; set; }
        public string gender { get; set; }

        // Переопределение для корректного сравнения по содержимому
        public override bool Equals(object obj)
        {
            if (obj is Parent other)
            {
                return age == other.age && gender == other.gender;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(age, gender);
        }

        public override string ToString()
        {
            return $"{{ age = {age}, gender = \"{gender}\" }}";
        }
    }

    internal class ex_5
    {
        private static List<Parent> parents_1 = new List<Parent>()
        {
            new Parent(){ Name = "P1A", age = 40, gender = "m"},
            new Parent(){ Name = "P1B", age = 45, gender = "m"},
            new Parent(){ Name = "P1C", age = 50, gender = "f"},
            new Parent(){ Name = "P1D", age = 41, gender = "m"}
        };

        private static List<Parent> parents_2 = new List<Parent>()
        {
            new Parent(){ Name = "P2A", age = 53, gender = "f"},
            new Parent(){ Name = "P2B", age = 38, gender = "m"},
            new Parent(){ Name = "P2C", age = 41, gender = "m"},
            new Parent(){ Name = "P2D", age = 62, gender = "f"}
        };

        public static (IEnumerable<Parent> a, IEnumerable<Parent> b, IEnumerable<Parent> c, IEnumerable<Parent> d, IEnumerable<Parent> e, IEnumerable<Parent> f) RunQueries()
        {
            var combinedWithDuplicates = parents_1.Concat(parents_2);

            var unionWithoutDuplicates = parents_1.Union(parents_2);

            var parentsOnlyIn1 = parents_1.Except(parents_2);

            var commonParents = parents_1.Intersect(parents_2);

            var allParents = parents_1.Concat(parents_2);
            var olderThan40 = allParents.Where(p => p.age > 40).Distinct();

            var allAges = allParents.Select(p => p.age);
            int minAge = allAges.Min();
            int maxAge = allAges.Max();

            var youngestAndOldest = allParents
                .Where(p => p.age == minAge || p.age == maxAge)
                .Distinct();

            return (combinedWithDuplicates, unionWithoutDuplicates, parentsOnlyIn1, commonParents, olderThan40, youngestAndOldest);
        }
    }
}