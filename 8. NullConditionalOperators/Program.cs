namespace _8.NullConditionalOperators
{
    using System;
    using System.Linq;

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
        }
    }
}
