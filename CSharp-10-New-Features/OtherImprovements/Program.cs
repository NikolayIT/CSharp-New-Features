using System;
using System.Runtime.CompilerServices;

namespace OtherImprovements
{
    public static class Program
    {
        public static void Main()
        {
            // Extended property patterns
            var person = new Person();
            person.Address = new Address();
            person.Address.City = new City("Sofia");
            // C# 9: person is Person { Address: { City: { Name: "Sofia" } } }
            if (person is Person { Address.City.Name: "Sofia" })
            {
                Console.WriteLine("person is a Person class with city name of Sofia");
            }

            // Mix declarations and variables in deconstruction
            int a, b;
            (a, b) = (1, 2);
            (var c, var d) = (3, 4);
            (a, var e) = (1, 5); // Works in C# 10 onwards
            Console.WriteLine($"a = {a}; e = {e}");

            // Get expression from a method call
            CheckExpression(a > 5 && b < 6);
            CheckExpression(true);
            CheckExpression(true && false || true && !false);
            // ExampleOfEasierArgumentException(null);
        }

        private static void CheckExpression(
            bool condition,
            [CallerArgumentExpression("condition")] string message = null)
        {
            Console.WriteLine($"Condition: {message}");
        }

        private static void ExampleOfEasierArgumentException(Person person)
        {
            // No need to pass in the parameter name here
            ArgumentNullException.ThrowIfNull(person);
            // Before C# 10: throw new ArgumentNullException(nameof(person));
        }
    }
}
