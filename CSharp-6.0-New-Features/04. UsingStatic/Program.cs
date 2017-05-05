using static System.Console;
using static System.Linq.Enumerable;
using static System.Math;

internal class Program
{
    internal static void Main()
    {
        // Using static
        WriteLine(Pow(2, 10));

        // Using static in combination with extension methods
        Range(1, 10).ToList().ForEach(WriteLine);
    }
}
