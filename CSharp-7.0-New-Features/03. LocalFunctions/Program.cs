using System;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine(ConcatenateStrings("a", "b", "c", "d"));
        Console.WriteLine(UsingClosure("a", "b", "c", "d"));
    }

    private static string UsingClosure(string a, string b, string c, string d)
    {
        string Concatenate()
        {
            return a + b + c + d;
        }

        return Concatenate();
    }

    public static string ConcatenateStrings(string a, string b, string c, string d)
    {
        void Validate(string paramName, object param)
        {
            if (param == null)
            {
                throw new ArgumentException($"{paramName} cannot be null", paramName);
            }
        }

        Validate(nameof(a), a);
        Validate(nameof(b), b);
        Validate(nameof(c), c);
        Validate(nameof(d), d);

        return $"{a}{b}{c}{d}";
    }
}
