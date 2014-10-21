namespace _2.PrimaryConstructors
{
    using System;

    internal class Program
    {
        internal static void Main()
        {
            var person = new Person("Nikolay", "Kostov");
            Console.WriteLine("{0} {1}", person.FirstName, person.LastName);

            var personWithPrimaryConstructorBody
                = new PersonWithPrimaryConstructorBody("Nikolay", "Kostov"); // try with null
            Console.WriteLine("{0} {1}",
                personWithPrimaryConstructorBody.FirstName,
                personWithPrimaryConstructorBody.LastName);

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
