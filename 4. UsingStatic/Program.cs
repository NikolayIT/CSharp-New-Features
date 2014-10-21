namespace _4.UsingStatic
{
    using System.Linq;

    using System.Console;
    using System.Math;

    internal class Program
    {
        internal static void Main()
        {
            // Using static
            WriteLine(Pow(2, 10));

            // Using static in combination with extension methods
            var oddNumbersGenerator = new UsingExtensionMethodsStaticClass();
            oddNumbersGenerator.GetOddNumbersBetween(1, 10).ToList().ForEach(WriteLine);
        }
    }
}
