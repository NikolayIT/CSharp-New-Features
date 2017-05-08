using System;

// Requires .NET Framework 4.7+
public static class Program
{
    public static void Main()
    {
        // Result from methods as var
        var names = SplitNames("Nikolay S Kostov");
        Console.WriteLine($"{nameof(names.firstName)} = {names.firstName}");
        Console.WriteLine($"{nameof(names.middleName)} = {names.middleName}");
        Console.WriteLine($"{nameof(names.lastName)} = {names.lastName}");

        // Declare 3 variables for each value
        (string fn, string mn, var ln) = SplitNames("Moon Moon");
        Console.WriteLine($"{fn} {ln}");
        
        // Declare 1 variable with 3 fields
        (string fn, string mn, string ln) name = SplitNames("Moon Moon");
        Console.WriteLine($"{name.fn} {name.ln}");

        // Declare tuple
        var tupleDeclaration = (42, "String", new object());
        Console.WriteLine(tupleDeclaration.Item1);
        (int, string str, object) varTuple = (42, "String", new object());
        Console.WriteLine(varTuple.str);
    }

    public static (string firstName, string middleName, string lastName) SplitNames(string name)
    {
        var parts = name.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        switch (parts.Length)
        {
            case 1: return (parts[0], null, null);
            case 2: return (parts[0], null, parts[1]);
            case 3: return (parts[0], parts[1], parts[2]);
            default: throw new ArgumentException("Invalid string for name", nameof(name));
        }
    }

    public static (string title, string description) GetInfo(int id)
        => ("CLR", "Common Language Runtime");
}
