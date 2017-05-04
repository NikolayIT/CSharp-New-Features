using System.Collections.Generic;

internal class Program
{
    internal static void Main()
    {
        // C# 5.0
        var numbersOldWay = new Dictionary<int, string>
            {
               { 7, "seven" },
               { 9, "nine" },
               { 13, "thirteen" }
            };

        // C# 6.0
        var numbers = new Dictionary<int, string>
        {
            [7] = "seven",
            [9] = "nine",
            [13] = "thirteen"
        };

        // Same as
        // numbers = new Dictionary<int, string>();
        // numbers[7] = "seven";
        // numbers[9] = "nine";
        // numbers[13] = "thirteen";

        // Another example
        var dictionary = new Dictionary<string, string>
        {
            ["C#"] = "A programming language",
            [".NET"] = "A development platform",
        };
    }
}
