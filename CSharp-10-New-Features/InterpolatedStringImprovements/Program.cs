using System;
using System.Text;

namespace InterpolatedStringImprovements
{
    public static class Program
    {
        // Constant interpolated strings
        const string FirstName = "Niki", LastName = "Kostov";
        const string FullName = $"{FirstName} {LastName}";

        public static void Main()
        {
            // Interpolated string handlers
            var sb = new StringBuilder();
            sb.Append($"Hello {Environment.UserName}, how are you?");

            // StringBuilder is using InterpolatedStingHandler
            // to optimize performance and reduce string allocations
            // The call above will be equivalent to:
            sb.Append("Hello ");
            sb.Append(Environment.UserName);
            sb.Append(", how are you?");

            InterpolatedStringHandlerExample($"Hello {Environment.UserName}, how are you?");
        }

        public static void InterpolatedStringHandlerExample(MyInterpolatedStringHandler handler)
        {
        }
    }
}
