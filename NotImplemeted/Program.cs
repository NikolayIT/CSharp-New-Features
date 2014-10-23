namespace NotImplemeted
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    internal class Program
    {
        internal static void Main()
        {
            /* // Binary literals and digit separators
            var bits = 0b00101110;
            var hex = 0x00_2E;
            var dec = 1_234_567_890;
            */

            /* // Indexed member initializer
            var obj = new JObject { $x = 3, $y = 7 };
            // Equivalent to
            var obj = new JObject();
            obj["first"] = "Nikolay";
            obj["last"] = "Kostov";
            */

            /* // Indexed member access
            obj.$name = obj.$first + " " + obj.$last;
            // Equivalent to
            obj["name"] = obj["first"] + " " + obj["last"];
            Console.WriteLine(obj["name"]);
            */

            /* // Event initializers
            var fsw = new FileSystemWatcher { Changed += FswCh };
            */

            /* // Constructor Inference
            var tuple = new Tuple(3, "three", true);
            // Instead of
            var tuple2 = new Tuple<int, string, bool>(3, "three", true);
            */

            /* // Semicolon operator
            var result = (var x = 4; Console.Write(x); x * x);
            */

            /* // String interpolation
            var str = $"{hello}, {world}!";
            */
        }

        /* // Params IEnumerable<>
        static decimal Avg(params IEnumerable<int> numbers)
        {
            int sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }

            int count = numbers.Count();

            if (count == 0)
            {
                return 0;
            }

            return (decimal)sum / count;
        }
        */

        private static void Fsw_Changed(object sender, FileSystemEventArgs e)
        {
            throw new NotImplementedException();
        }
    }

    /* // Private protected modifier
    public class Test
    {
        private protected int Age { get; set; }
    }
    */

    /* // Constructor assignment to getter-only auto-properties
    // http://roslyn.codeplex.com/discussions/568824
    public class Class
    {
        public int P { get; }
        public Class()
        {
            P = 15;
        }
    }
    */
}
