using System;
using System.Linq;

/// <summary>
/// Demonstrating Null-propagating operator ?. (a.k.a. Null-conditional Operator)
/// More info: http://roslyn.codeplex.com/discussions/540883
/// </summary>
internal class Program
{
    internal static void Main()
    {
        Customer[] customers = null;
        // Customer[] customers = new Customer[1] { new Customer() { Orders = new List<string> { "order1", "order2" } } };

        int? lengthOrNull = customers?.Length; // null if customers is null
        Console.WriteLine("lengthOrNull.HasValue: {0}", lengthOrNull.HasValue);

        Customer first = customers?[0]; // null if customers is null

        int lengthOrZero = customers?.Length ?? 0; // 0 if customers null
        Console.WriteLine("lengthOrZero: {0}", lengthOrZero);

        int? firstOrdersCount = customers?[0].Orders.Count();
        Console.WriteLine("firstOrdersCount.HasValue: {0}", firstOrdersCount.HasValue);
        Console.WriteLine("firstOrdersCount: {0}", firstOrdersCount);
        // Equivalent to
        int? firstOrdersCount2 = (customers != null) ? (int?)customers[0].Orders.Count() : null;

        // Chaining:
        int? firstOrdersCount3 = customers?[0].Orders?.Count();
    }
}
