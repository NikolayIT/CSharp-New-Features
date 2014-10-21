namespace _1.AutoPropertyEnhancements
{
    using System;

    internal class Program
    {
        internal static void Main()
        {
            // Initializers for auto-properties
            var person = new Person();
            Console.WriteLine("{0} {1}", person.FirstName, person.LastName);

            // Getter-only auto-properties
            var readOnlyPerson = new ReadOnlyPerson();
            Console.WriteLine("{0} {1}", readOnlyPerson.FirstName, readOnlyPerson.LastName);
        }
    }
}
