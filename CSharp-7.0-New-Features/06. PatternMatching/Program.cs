using System;

public static class Program
{
    public static void Main()
    {
        PrintStars(10);

        object obj = "42";
        if (obj is int i || (obj is string s && int.TryParse(s, out i)))
        {
            Console.WriteLine(i);
        }

        SwitchStatementsWithPatterns(new Rectangle { Width = 2, Height = 2 });
    }

    public static void PrintStars(object obj)
    {
        if (obj is null) // constant pattern "null"
        {
            return;
        }

        if (obj is string _) // discarding the variable
        {
            Console.WriteLine($"{obj} is string!");
        }

        if (!(obj is int i)) // type pattern "int i"
        {
            return;
        }

        Console.WriteLine(new string('*', i));
    }

    private static void SwitchStatementsWithPatterns(object shape)
    {
        switch (shape)
        {
            case Circle c:
                Console.WriteLine($"circle with radius {c.Radius}");
                break;
            case Rectangle s when s.Width == s.Height:
                Console.WriteLine($"{s.Width} x {s.Height} square");
                break;
            case Rectangle r:
                Console.WriteLine($"{r.Width} x {r.Height} rectangle");
                break;
            case string _: // discarding the variable
                Console.WriteLine($"{shape} is string");
                break;
            case null:
                throw new ArgumentNullException(nameof(shape));
            default:
                Console.WriteLine("<unknown shape>");
                break;
        }
    }
}
