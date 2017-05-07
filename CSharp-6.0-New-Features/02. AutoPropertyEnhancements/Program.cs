using System;

public static class Program
{
    public static void Main()
    {
        // Initializers for auto-properties
        var person = new Person();
        Console.WriteLine("{0} {1}", person.FirstName, person.LastName);

        // Getter-only auto-properties
        var readOnlyPerson = new ReadOnlyPerson("Nikolay");
        Console.WriteLine("{0} {1}", readOnlyPerson.FirstName, readOnlyPerson.LastName);
    }
}
