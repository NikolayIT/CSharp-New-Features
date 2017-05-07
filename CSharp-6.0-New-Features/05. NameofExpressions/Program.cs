using System;

public class Program
{
    public static void Main()
    {
        // Name of static method
        Console.WriteLine(nameof(Main));

        // Name of parameter when creating ArgumentNullException
        try
        {
            var person = new Person(null, null);
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine(ex.Message);
        }

        // Name of instance property
        new Program().NonStaticMethod();

        // Name of methods
        Console.WriteLine(nameof(string.Empty.Normalize));
    }

    public int NonStaticProperty { get; set; }

    public void NonStaticMethod()
    {
        Console.WriteLine(nameof(this.NonStaticProperty));
    }
}
