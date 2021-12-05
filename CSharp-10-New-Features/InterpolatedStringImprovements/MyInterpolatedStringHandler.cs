using System;
using System.Runtime.CompilerServices;

namespace InterpolatedStringImprovements
{
    [InterpolatedStringHandler]
    public ref struct MyInterpolatedStringHandler
    {
        public MyInterpolatedStringHandler(int literalLength, int formattedCount)
        {
            Console.WriteLine($"MyInterpolatedStringHandler: literal length: {literalLength}, formattedCount: {formattedCount}");
        }

        public void AppendLiteral(string s)
        {
            Console.WriteLine($"AppendLiteral called: \"{s}\"");
        }

        public void AppendFormatted<T>(T t)
        {
            Console.WriteLine($"AppendFormatted called: \"{t}\" is of type {typeof(T).Name}");
        }
    }
}
