namespace _2.PrimaryConstructors
{
    using System;

    internal class Program
    {
        internal static void Main()
        {
            // Parameters on classes and structs
            var person = new Person("Nikolay", "Kostov");
            Console.WriteLine("{0} {1}", person.FirstName, person.LastName);

            // Primary constructor bodies
            var personWithPrimaryConstructorBody
                = new PersonWithPrimaryConstructorBody("Nikolay", "Kostov"); // try with null
            Console.WriteLine("{0} {1}",
                personWithPrimaryConstructorBody.FirstName,
                personWithPrimaryConstructorBody.LastName);

            // Call base initializer
            try
            {
                throw new BufferFullException();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught: {0}", ex.Message);
            }
        }
    }
}
