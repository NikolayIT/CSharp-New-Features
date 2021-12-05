using System;

namespace NativeSizedIntegers
{
    public static class Program
    {
        public static void Main()
        {
            unsafe
            {
                Console.WriteLine($"size of nint = {sizeof(nint)}");
                Console.WriteLine($"size of nuint = {sizeof(nuint)}");

                // output when run in a 64-bit process
                //size of nint = 8
                //size of nuint = 8

                // output when run in a 32-bit process
                //size of nint = 4
                //size of nuint = 4
            }
        }
    }
}
