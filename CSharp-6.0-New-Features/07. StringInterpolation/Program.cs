using System;

public static class Program
{
    public static void Main()
    {
        // Using interpolated strings
        var versionInformation =
            $"{Environment.OSVersion}; .NET CLR {Environment.Version}; {Environment.ProcessorCount} cores";
        Console.WriteLine(versionInformation);

        // Expressions are allowed in interpolated strings
        Console.WriteLine($"Sum of 2+2 = {2 + 2}");

        // Combining nameof() with interpolated strings
        var value = 42;
        Console.WriteLine($"{nameof(value)} = {value}");

        // Escaping '{' and '}'
        Console.WriteLine($"{{ value: {value} }}");
    }
}
