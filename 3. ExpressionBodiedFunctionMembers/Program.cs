namespace _3.ExpressionBodiedFunctionMembers
{
    using System;

    internal class Program
    {
        public static void PrintTime() => Console.WriteLine("Current time: {0}", DateTime.Now.ToString());

        internal static void Main()
        {
            // 1. Expression bodies on method-like members
            PrintTime();
            var point = new Point(37, 77);
            var point2 = point.Clone() as Point;
            point.Move(100, 100);
            point2.Print();

            // 2. Expression bodies on property-like function members
        }
    }
}
