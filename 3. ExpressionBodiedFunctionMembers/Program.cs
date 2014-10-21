namespace _3.ExpressionBodiedFunctionMembers
{
    using System;

    internal class Program
    {
        public static void PrintTime() => Console.WriteLine("Current time: {0}", DateTime.Now.ToString());

        internal static void Main()
        {
            // 1. Expression bodies on method-like members
            Console.WriteLine("1. Expression bodies on method-like members");
            PrintTime();
            var point = new Point(37, 77);
            var point2 = point.Clone() as Point;
            point.Move(100, 100);
            point2.Print();
            Console.WriteLine();

            // 2. Expression bodies on property-like function members
            Console.WriteLine("2. Expression bodies on property-like function members");
            var person = new Person("John", "Smith");
            person.Children.Add(new Person("Junior 1", "Smith"));
            person.Children.Add(new Person("Junior 2", "Smith"));
            person.Children.Add(new Person("Junior 3", "Smith"));
            Console.WriteLine(person.Name);
            Console.WriteLine(person["Junior 2 Smith"].Name);
        }
    }
}
