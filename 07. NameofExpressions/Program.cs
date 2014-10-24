using System;

internal class Program
{
    internal static void Main()
    {
        // Name of static method
        Console.WriteLine(nameof(Main));

        // Name of paramether when creating ArgumentNullException
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

        // This is planned but not yet implemented:
        // Console.WriteLine(nameof(default(string).Normalize()));
    }

    public int NonStaticProperty { get; set; }
    public void NonStaticMethod()
    {
        Console.WriteLine(nameof(NonStaticProperty));
    }
}
