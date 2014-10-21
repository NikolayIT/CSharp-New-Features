using System;

namespace _7.NameofExpressions
{
    internal class Program
    {
        internal static void Main()
        {
            Console.WriteLine(nameof(Main));

            try
            {
                var person = new Person(null, null);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            // This is planned but not yet implemented:
            // Console.WriteLine(nameof(default(string).Normalize()));
        }
    }
}
