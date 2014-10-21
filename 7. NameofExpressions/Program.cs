using System;

namespace _7.NameofExpressions
{
    internal class Program
    {
        internal static void Main()
        {
            try
            {
                var person = new Person(null, null);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
