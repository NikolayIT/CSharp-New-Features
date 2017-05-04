using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    internal static void Main()
    {
        // Read number and print the power 2 of the number
        if (int.TryParse(var line = Console.ReadLine(), out int i))
        {
            Console.WriteLine("Result: {0}", (var x = i) * x, x);
        }
        else
        {
            Console.WriteLine("Invalid input: {0}", line);
        }

        // Convert list of strings to list of integers
        var strings = new List<string> { "123", "-5", "1337", "3777" };
        var numbers = from s in strings select int.TryParse(s, out int i) ? i : -1;
    }
}
