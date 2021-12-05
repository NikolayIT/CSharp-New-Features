namespace ImprovementsToStructs
{
    public static class Program
    {
        public static void Main()
        {
            // Beginning with C# 10, a left-hand operand of a with expression can also be of a structure type
            var matrixStruct = new Matrix2x2();
            var newMatrix = matrixStruct with { Name = "Mutated matrix" };

            // Beginning with C# 10, a left-hand operand of a with expression can also be of an anonymous type
            var anonymousObject = new { City = "Sofia", Country = "Bulgaria" };
            var newAnonymousObject = anonymousObject with { City = "Plovdiv" };
        }
    }
}
