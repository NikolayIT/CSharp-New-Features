using System;
using System.Linq;

public static class Program
{
    public static void Main()
    {
        var customers = GetCustomers();

        // Before:
        //// int? lengthOrNull = customers != null ? customers.Length : (int?)null;
        // After:
        int? lengthOrNull = customers?.Length; // null if customers is null
        Console.WriteLine("lengthOrNull.HasValue: {0}", lengthOrNull.HasValue);

        // Indexer access:
        var first = customers?[0]; // null if customers is null

        // Used together with the null coalescing operator ??:
        int lengthOrZero = customers?.Length ?? 0; // 0 if customers null
        Console.WriteLine("lengthOrZero: {0}", lengthOrZero);

        // Another example
        int? firstOrdersCount = customers?[0].Orders.Count();
        Console.WriteLine("firstOrdersCount.HasValue: {0}", firstOrdersCount.HasValue);
        Console.WriteLine("firstOrdersCount: {0}", firstOrdersCount);

        // Chaining of null checks before
        ////int? firstOrdersCount2 = (customers != null) ? (customers[0].Orders != null ? customers[0].Orders.Count() : (int?)null) : null;
        // Chaining of null checks after:
        int? firstOrdersCount3 = customers?[0].Orders?.Count();
    }

    private static Customer[] GetCustomers()
    {
        // new Customer[1] { new Customer() { Orders = new List<string> { "order1", "order2" } } }
        return null;
    }
}
