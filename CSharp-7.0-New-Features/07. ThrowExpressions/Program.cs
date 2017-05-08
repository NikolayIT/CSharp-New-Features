using System;

public static class Program
{
    public static void Main()
    {
        PrintName("Nikolay");

        var array = new[] { 42 };
        var arrayFirstValue = (array.Length > 0)
                                  ? array[0]
                                  : throw new Exception($"{nameof(array)} contains no elements.");
        Console.WriteLine(arrayFirstValue);
    }

    private static void PrintName(string name)
    {
        Console.WriteLine(name ?? throw new ArgumentNullException());
    }

    public static string DoMagic() => throw new NotImplementedException();
}
