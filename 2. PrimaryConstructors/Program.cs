namespace _2.PrimaryConstructors
{
    using System;

    internal class Program
    {
        internal static void Main()
        {
            var person = new Person("Nikolay", "Kostov");
            Console.WriteLine("{0} {1}", person.FirstName, person.LastName);
        }
    }
}
