using System;

namespace InitOnlyProperties
{
    public static class Program
    {
        public static void Main()
        {
            var personWithConstructor = new Person("Niki", 3);
            Console.WriteLine(personWithConstructor);

            var personWithInitialization = new Person { Name = "Niki", Age = 10 };
            Console.WriteLine(personWithInitialization);

            var point = new Point(1, 2);
            var mutatedPoint = point with { X = 2, Y = 3 };
            Console.WriteLine(mutatedPoint.ToString());
        }
    }
}
