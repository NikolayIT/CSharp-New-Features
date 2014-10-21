using System;

namespace _5.ExceptionFilters
{
    internal class Program
    {
        internal static void Main()
        {
            Person person = null;
            try
            {
                string firstName = "Nikolay";
                string lastName = null;
                person = new Person(firstName, lastName);
            }
            catch (ArgumentNullException ex) if (ex.ParamName == "firstName")
            {
                Console.WriteLine("First name is null");
            }
            catch (ArgumentNullException ex) if (ex.ParamName == "lastName")
            {
                Console.WriteLine("Last name is null");
            }

            if (person != null)
            {
                Console.WriteLine(person.Name);
            }
        }
    }
}
