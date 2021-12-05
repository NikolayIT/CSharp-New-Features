using System;

namespace ImprovementsToStructs
{
    public struct Matrix2x2
    {
        public Matrix2x2()
        {
            this.Name = "<empty>";
            Console.WriteLine("Created 2x2 matrix.");
        }

        public string Name { get; set; }

        public int[,] Data { get; set; } = new int[2, 2];
    }
}
