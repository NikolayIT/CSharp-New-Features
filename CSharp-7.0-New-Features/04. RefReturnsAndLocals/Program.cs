using System;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("======== Ref return and local ref");
        var movies = new[] { "The Matrix", "Ex Machina", "Morgan", "Chappie" };
        Console.WriteLine($"Original value of {nameof(movies)}[1]: {movies[1]}");
        ref string result = ref FindString(1, movies);
        Console.WriteLine($"Return value of result: {result}");
        result = "CHANGED";
        Console.WriteLine($"New value of result: {result}");
        Console.WriteLine($"{nameof(movies)}[1]: {movies[1]} // We've changed the value of {nameof(movies)}[1]");
        Console.WriteLine();

        Console.WriteLine("======== Local ref");
        var oldVariable = "OLD VALUE";
        ref var newVariable = ref oldVariable; // newVariable is now pointing to oldVariable
        newVariable = "NEW VALUE";
        Console.WriteLine($"Value of {nameof(oldVariable)}: {oldVariable}");
    }

    public static ref string FindString(int index, string[] names)
    {
        if (names.Length > 0)
        {
            return ref names[index]; // return the storage location, not the value    
        }

        throw new IndexOutOfRangeException($"{nameof(index)} {index} not found.");
    }
}
