using System;

public static class Program
{
    public static void Main()
    {
        // Using interpolated strings
        var cores = Environment.ProcessorCount;
        var versionInformation =
            $"{Environment.OSVersion}; .NET CLR {Environment.Version}; {cores} core{(cores == 1 ? null : "s")}";
        Console.WriteLine(versionInformation);

        // Expressions are allowed in interpolated strings
        Console.WriteLine($"Sum of 2+2 = {2 + 2}");

        // Combining nameof() with interpolated strings
        var value = 42;
        Console.WriteLine($"{nameof(value)} = {value:F3}");

        // Escaping '{' and '}' for JSON strings for example
        Console.WriteLine($"{{ value: {value} }}");
    }
}
