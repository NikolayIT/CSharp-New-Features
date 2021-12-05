using System;

namespace StaticAbstractInInterfaces
{
    public static class Program
    {
        public static void Main()
        {
            var digit = OneDigitNumber.Parse("2");
            Console.WriteLine(digit.Value);
        }
    }
}
