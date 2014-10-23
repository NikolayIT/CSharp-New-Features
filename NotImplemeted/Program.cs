namespace NotImplemeted
{
    using System;

    /* // Private protected modifier
    public class Test
    {
        private protected int Age { get; set; }
    }
    */

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
        }
    }
}
